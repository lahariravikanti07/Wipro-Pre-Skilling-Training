using System;
using System.Data;
using System.Data.SqlClient;

class InsertNewProduct
{
    static void Main()
    {
        InsertProduct("Test Product", 1, 1, 25m);
    }

    static void InsertProduct(string productName, int supplierId, int categoryId, decimal unitPrice)
    {
        SqlConnection conn = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=SSPI");

        try
        {
            conn.Open();

            string insertQuery = @"INSERT INTO Products (ProductName, SupplierID, CategoryID, UnitPrice)
                                   VALUES (@productName, @supplierId, @categoryId, @unitPrice)";

            SqlCommand cmd = new SqlCommand(insertQuery, conn);

            // Set parameters
            cmd.Parameters.AddWithValue("@productName", productName);
            cmd.Parameters.AddWithValue("@supplierId", supplierId);
            cmd.Parameters.AddWithValue("@categoryId", categoryId);
            cmd.Parameters.AddWithValue("@unitPrice", unitPrice);

            int rowsAffected = cmd.ExecuteNonQuery();

            Console.WriteLine(rowsAffected > 0
                ? "Product inserted successfully."
                : "Insert failed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            if (conn != null)
                conn.Close();
        }
    }
}
