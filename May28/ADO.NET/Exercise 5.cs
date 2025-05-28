using System;
using System.Data;
using System.Data.SqlClient;

class DeleteProduct
{
    static void Main()
    {
        Console.Write("Enter Product ID to delete: ");
        int productId = int.Parse(Console.ReadLine());

        DeleteProductById(productId);
    }

    static void DeleteProductById(int productId)
    {
        SqlConnection conn = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=SSPI");

        try
        {
            conn.Open();

            string deleteQuery = "DELETE FROM Products WHERE ProductID = @productId";

            SqlCommand cmd = new SqlCommand(deleteQuery, conn);

            // Parameterized input to prevent SQL injection
            cmd.Parameters.AddWithValue("@productId", productId);

            int rowsAffected = cmd.ExecuteNonQuery();

            Console.WriteLine(rowsAffected > 0
                ? "Product deleted successfully."
                : "No product found with the specified Product ID.");
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
