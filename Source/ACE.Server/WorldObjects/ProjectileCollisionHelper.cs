using System;
using ACE.Common;
using ACE.Entity.Enum;
using ACE.Server.Entity;
using ACE.Server.Entity.Actions;
using ACE.Server.Managers;
using ACE.Server.Network.GameMessages.Messages;

namespace ACE.Server.WorldObjects
{
    /// <summary>
    /// Helper class for arrows / bolts / thrown weapons
    /// outside of the WorldObject hierarchy
    /// </summary>
    public static class ProjectileCollisionHelper
    {
        public static void OnCollideObject(WorldObject worldObject, WorldObject target)
        {
            if (!worldObject.PhysicsObj.is_active()) return;

            //Console.WriteLine($"Projectile.OnCollideObject - {WorldObject.Name} ({WorldObject.Guid}) -> {target.Name} ({target.Guid})");

            if (worldObject.ProjectileTarget == null || worldObject.ProjectileTarget != target)
            {
                //Console.WriteLine("Unintended projectile target! (should be " + ProjectileTarget.Guid.Full.ToString("X8") + " - " + ProjectileTarget.Name + ")");
                OnCollideEnvironment(worldObject);
                return;
            }

            // take damage
            var sourceCreature = worldObject.ProjectileSource as Creature;
            var sourcePlayer = worldObject.ProjectileSource as Player;
            var targetCreature = target as Creature;

            DamageEvent damageEvent = null;

            if (targetCreature != null)
            {
                if (sourcePlayer != null)
                {
                    // player damage monster or player
                    damageEvent = sourcePlayer.DamageTarget(targetCreature, worldObject);

                    if (!damageEvent.Evaded)
                        sourceCreature.TryCastAssessCreatureAndPersonDebuffs(targetCreature, CombatType.Missile);

                    targetCreature.OnAttackReceived(sourceCreature, CombatType.Missile, damageEvent.IsCritical);

                    if (damageEvent != null && damageEvent.HasDamage)
                    {
                        worldObject.EnqueueBroadcast(new GameMessageSound(worldObject.Guid, Sound.Collision, 1.0f));

                        if(!(target is Player) && !damageEvent.Evaded && (worldObject.WeenieType == WeenieType.Missile || worldObject.WeenieType == WeenieType.Ammunition) && Common.ConfigManager.Config.Server.WorldRuleset == Common.Ruleset.CustomDM)
                        {
                            var rng = ThreadSafeRandom.NextInterval(0);
                            if (rng < 0.25) // 25% chance the ammo will be preserved
                            {
                                int currentAmount;
                                if (targetCreature.ammoHitWith.TryGetValue(worldObject.WeenieClassId, out currentAmount))
                                    currentAmount++;
                                else
                                    currentAmount = 1;
                                targetCreature.ammoHitWith[worldObject.WeenieClassId] = currentAmount;
                            }
                        }
                    }
                }
                else if (sourceCreature != null && sourceCreature.AttackTarget != null)
                {
                    var targetPlayer = sourceCreature.AttackTarget as Player;

                    damageEvent = DamageEvent.CalculateDamage(sourceCreature, targetCreature, worldObject);

                    if (!damageEvent.Evaded)
                        sourceCreature.TryCastAssessCreatureAndPersonDebuffs(targetCreature, CombatType.Missile);

                    targetCreature.OnAttackReceived(sourceCreature, CombatType.Missile, damageEvent.IsCritical);

                    if (targetPlayer != null)
                    {
                        // monster damage player
                        if (damageEvent.HasDamage)
                        {
                            targetPlayer.TakeDamage(sourceCreature, damageEvent);

                            // blood splatter?

                            if (damageEvent.ShieldMod != 1.0f)
                            {
                                var shieldSkill = targetPlayer.GetCreatureSkill(Skill.Shield);
                                Proficiency.OnSuccessUse(targetPlayer, shieldSkill, shieldSkill.Current);   // ??
                            }
                        }
                        else
                            targetPlayer.OnEvade(sourceCreature, CombatType.Missile);
                    }
                    else
                    {
                        // monster damage pet
                        if (damageEvent.HasDamage)
                        {
                            targetCreature.TakeDamage(sourceCreature, damageEvent.DamageType, damageEvent.Damage);

                            // blood splatter?
                        }

                        if (!(targetCreature is CombatPet))
                        {
                            // faction mobs and foetype
                            sourceCreature.MonsterOnAttackMonster(targetCreature);
                        }
                    }
                }

                // handle target procs
                if (damageEvent != null && damageEvent.HasDamage)
                {
                    // Ok... if we got here, we're likely in the parallel landblock physics processing.
                    // We're currently on the thread for worldObject, but we're wanting to perform some work on sourceCreature which can result in a new spell being created
                    // and added to the sourceCreature's current landblock, which, could be on a separate thread.
                    // Any chance of a cross landblock group work (and thus cross thread), should be enqueued onto the target object to maintain thread safety.
                    if (sourceCreature.CurrentLandblock == null || sourceCreature.CurrentLandblock == worldObject.CurrentLandblock)
                        sourceCreature.TryProcEquippedItems(targetCreature, false);
                    else
                        sourceCreature.EnqueueAction(new ActionEventDelegate(() => sourceCreature.TryProcEquippedItems(targetCreature, false)));
                }
            }

            worldObject.CurrentLandblock?.RemoveWorldObject(worldObject.Guid, showError: !worldObject.PhysicsObj.entering_world);
            worldObject.PhysicsObj.set_active(false);

            worldObject.HitMsg = true;
        }

        public static void OnCollideEnvironment(WorldObject worldObject)
        {
            if (!worldObject.PhysicsObj.is_active()) return;

            // do not send 'Your missile attack hit the environment' messages to player,
            // if projectile is still in the process of spawning into world.
            if (worldObject.PhysicsObj.entering_world)
                return;

            //Console.WriteLine($"Projectile.OnCollideEnvironment({WorldObject.Name} - {WorldObject.Guid})");

            worldObject.CurrentLandblock?.RemoveWorldObject(worldObject.Guid, showError: !worldObject.PhysicsObj.entering_world);
            worldObject.PhysicsObj.set_active(false);

            if (worldObject.ProjectileSource is Player player)
            {
                player.Session.Network.EnqueueSend(new GameMessageSystemChat("Your missile attack hit the environment.", ChatMessageType.Broadcast));
            }
            else if (worldObject.ProjectileSource is Creature creature)
            {
                creature.MonsterProjectile_OnCollideEnvironment();
            }

            worldObject.HitMsg = true;
        }
    }
}
