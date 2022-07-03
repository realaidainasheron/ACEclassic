UPDATE aceclassic_shard.biota_properties_int
SET value = 4096
WHERE type = 9
AND value = 16
AND object_id IN
(
  SELECT id 
  FROM aceclassic_shard.biota
  WHERE weenie_Class_Id = 36
);