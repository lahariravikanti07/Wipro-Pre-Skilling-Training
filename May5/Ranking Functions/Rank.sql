SELECT
    Name,
    Salary,
    RANK() OVER(ORDER BY Salary DESC) AS RankBySalary
FROM Employees;

--Gives same rank for ties, skips the next number