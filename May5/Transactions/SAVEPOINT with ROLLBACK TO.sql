BEGIN TRANSACTION;

UPDATE Employees
SET Salary = Salary + 1000
WHERE EmpID = 1;

SAVE TRANSACTION IncreaseJohn;

UPDATE Employees
SET Salary = Salary + 1000
WHERE EmpID = 2;

-- Oops, rollback second increment only
ROLLBACK TRANSACTION IncreaseJohn;

COMMIT;