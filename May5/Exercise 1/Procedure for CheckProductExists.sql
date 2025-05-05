CREATE PROCEDURE CheckProductExists
   @ProductID INT
AS
BEGIN
   IF EXISTS (SELECT 1 FROM Products WHERE ProductID = @ProductID)
      BEGIN
        PRINT 'Product Exists';
      END
      ELSE 
      BEGIN
        PRINT ' Product Not Found';
      END
END;
      