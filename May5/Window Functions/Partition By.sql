SELECT
    Name,
    Department,
    Salary,
    AVG(Salary) OVER(PARTITION BY Department) AS DeptAvgSalary
FROM Employees;

-- Partitions the data by department, then calculates the average within each group.