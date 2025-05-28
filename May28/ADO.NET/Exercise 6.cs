using System;
using System.Data;
using System.Data.SqlClient;

class JoinOrdersAndCustomers
{
    static void Main()
    {
        DisplayOrdersWithCustomerNames();
    }

    static void DisplayOrdersWithCustomerNames()
    {
        SqlConnection conn = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=SSPI");

        SqlDataReader rdr = null;

        try
        {
            conn.Open();

            string query = @"
                SELECT o.OrderID, c.CompanyName, o.OrderDate
                FROM Orders o
                INNER JOIN Customers c ON o.CustomerID = c.CustomerID
                ORDER BY o.OrderDate DESC";

            SqlCommand cmd = new SqlCommand(query, conn);

            rdr = cmd.ExecuteReader();

            Console.WriteLine("{0,-10} {1,-40} {2}", "Order ID", "Company Name", "Order Date");
            Console.WriteLine(new string('-', 10) + " " + new string('-', 40) + " " + new string('-', 20));

            while (rdr.Read())
            {
                Console.WriteLine("{0,-10} {1,-40} {2:yyyy-MM-dd}",
                    rdr["OrderID"],
                    rdr["CompanyName"],
                    rdr["OrderDate"]);
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
