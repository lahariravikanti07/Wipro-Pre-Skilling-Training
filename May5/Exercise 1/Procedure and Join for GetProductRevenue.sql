CREATE PROCEDURE GetProductRevenue
     @ProductID INT
AS
BEGIN
    SELECT SUM(O.Quantity * Price) AS TotalRevenue
    FROM Orders o 
    JOIN Products p ON o.ProductID = p.ProductID
    WHERE o.ProductID = @ProductID;
END;