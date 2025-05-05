BEGIN TRANSACTION;

DELETE FROM Students WHERE Marks < 60;

-- Realized it's a mistake!
ROLLBACK;