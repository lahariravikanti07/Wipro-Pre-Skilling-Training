CREATE PROCEDURE GetHigherEndProduts
AS 
BEGIN
   SELECT ProductID, ProductName, Price
   FROM Products
   WHERE Price > 60000.00;
END;