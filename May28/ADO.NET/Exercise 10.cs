using System;
using System.Data;
using System.Data.SqlClient;

class DisconnectedModelExample
{
    static void Main()
    {
        SqlConnection conn = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=SSPI");

        try
        {
            conn.Open();

            string query = "SELECT ProductID, ProductName, UnitsInStock FROM Products";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();

            // Fill DataSet
            adapter.Fill(ds, "Products");

            // Get the table
            DataTable products = ds.Tables["Products"];

            Console.WriteLine("Products with UnitsInStock > 20");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("{0,-10} {1,-30} {2}", "ProductID", "ProductName", "UnitsInStock");

            foreach (DataRow row in products.Rows)
            {
                int unitsInStock = Convert.ToInt32(row["UnitsInStock"]);
                if (unitsInStock > 20)
                {
                    Console.WriteLine("{0,-10} {1,-30} {2}",
                        row["ProductID"], row["ProductName"], unitsInStock);
                }
            }
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
