using System;
using System.Data;
using System.Data.SqlClient;

class SearchOrdersByCustomer
{
    static void Main()
    {
        Console.Write("Enter Customer ID: ");
        string customerId = Console.ReadLine();

        GetOrdersByCustomer(customerId);
    }

    static void GetOrdersByCustomer(string customerId)
    {
        SqlConnection conn = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=SSPI");

        SqlDataReader rdr = null;

        try
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand(
                "SELECT OrderID, OrderDate, ShipCountry FROM Orders WHERE CustomerID = @customerId", conn);

            // Use parameterized query to avoid SQL injection
            cmd.Parameters.AddWithValue("@customerId", customerId);

            rdr = cmd.ExecuteReader();

            Console.WriteLine("\n{0,-10} {1,-20} {2}", "Order ID", "Order Date", "Ship Country");
            Console.WriteLine(new string('-', 10) + " " + new string('-', 20) + " " + new string('-', 20));

            bool hasRows = false;
            while (rdr.Read())
            {
                hasRows = true;
                Console.WriteLine("{0,-10} {1,-20:yyyy-MM-dd} {2}",
                    rdr["OrderID"],
                    rdr["OrderDate"],
                    rdr["ShipCountry"]);
            }

            if (!hasRows)
            {
                Console.WriteLine("No orders found for Customer ID: " + customerId);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            if (rdr != null)
                rdr.Close();

            if (conn != null)
                conn.Close();
        }
    }
}
