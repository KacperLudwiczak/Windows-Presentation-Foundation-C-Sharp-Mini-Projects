--SELECT * FROM Animal
--SELECT * FROM ZOO

-- Show all animals that are in Tokyo
SELECT A.Name FROM Animal A INNER JOIN ZooAnimal ZA ON A.Id = ZA.AnimalId WHERE ZA.ZooId = 1

SELECT * FROM Animal A INNER JOIN ZooAnimal ZA ON A.Id = ZA.AnimalId WHERE ZA.ZooId = 1