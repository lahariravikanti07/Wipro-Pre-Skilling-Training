using System;
using System.Data;
using System.Data.SqlClient;

class InsertOrderTransaction
{
    static void Main()
    {
        InsertOrderWithDetails();
    }

    static void InsertOrderWithDetails()
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=SSPI";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            SqlTransaction transaction = conn.BeginTransaction();

            try
            {
                // 1. Insert into Orders
                SqlCommand insertOrder = new SqlCommand(@"
                    INSERT INTO Orders (CustomerID, OrderDate, RequiredDate, ShipCountry)
                    VALUES (@CustomerID, @OrderDate, @RequiredDate, @ShipCountry);
                    SELECT SCOPE_IDENTITY();", conn, transaction);

                insertOrder.Parameters.AddWithValue("@CustomerID", "ALFKI");
                insertOrder.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                insertOrder.Parameters.AddWithValue("@RequiredDate", DateTime.Now.AddDays(7));
                insertOrder.Parameters.AddWithValue("@ShipCountry", "Germany");

                int orderId = Convert.ToInt32(insertOrder.ExecuteScalar());

                // 2. Insert into Order Details
                SqlCommand insertDetails = new SqlCommand(@"
                    INSERT INTO [Order Details] (OrderID, ProductID, UnitPrice, Quantity, Discount)
                    VALUES (@OrderID, @ProductID, @UnitPrice, @Quantity, @Discount);", conn, transaction);

                insertDetails.Parameters.AddWithValue("@OrderID", orderId);
                insertDetails.Parameters.AddWithValue("@ProductID", 1);       // Product ID
                insertDetails.Parameters.AddWithValue("@UnitPrice", 18.00);   // Same as in Products
                insertDetails.Parameters.AddWithValue("@Quantity", 5);        // Quantity
                insertDetails.Parameters.AddWithValue("@Discount", 0.0f);     // No discount

                insertDetails.ExecuteNonQuery();

                // 3. Commit if all went well
                transaction.Commit();
                Console.WriteLine("Transaction committed successfully. Order ID: " + orderId);
            }
            catch (Exception ex)
            {
                // Rollback if any error
                try
                {
                    transaction.Rollback();
                }
                catch (Exception rollbackEx)
                {
                    Console.WriteLine("Rollback failed: " + rollbackEx.Message);
                }

                Console.WriteLine("Transaction failed: " + ex.Message);
            }
        }
    }
}
