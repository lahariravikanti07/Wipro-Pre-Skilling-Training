SELECT
    Name,
    Department,
    Salary,
    AVG(Salary) OVER() AS AvgSalary -- calculates average over all rows
FROM Employees;

-- OVER() DEFINES THE 'WINDOW' OVER WHICH THE FUNCTION OPERATES