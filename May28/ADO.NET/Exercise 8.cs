using System;
using System.Data;
using System.Data.SqlClient;

class CallCustOrderHist
{
    static void Main()
    {
        Console.Write("Enter Customer ID: ");
        string customerId = Console.ReadLine();

        GetCustomerOrderHistory(customerId);
    }

    static void GetCustomerOrderHistory(string customerId)
    {
        SqlConnection conn = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=SSPI");

        SqlDataReader rdr = null;

        try
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("CustOrderHist", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Add the parameter
            cmd.Parameters.AddWithValue("@CustomerID", customerId);

            rdr = cmd.ExecuteReader();

            Console.WriteLine("\nProduct Name\t\tTotal");
            Console.WriteLine(new string('-', 40));

            while (rdr.Read())
            {
                Console.WriteLine("{0,-25} {1}", rdr["ProductName"], rdr["Total"]);
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
