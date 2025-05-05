SELECT
    Name,
    Department,
    Salary,
    ROW_NUMBER() OVER(PARTITION BY Department ORDER BY Salary DESC) AS RowNum
FROM Employees;

-- ROW_NUMBER() GIVES A PARTICULAR NUMBER TO A ROW