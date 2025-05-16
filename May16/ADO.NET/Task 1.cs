using System;
using System.Data;
using System.Data.SqlClient;

class SqlConnectionDemo
{
    static void Main()
    {
        // 1. Instantiate the connection
        SqlConnection conn = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=SSPI");

        SqlDataReader rdr = null;

        try
        {
            // 2. Open the connection
            conn.Open();

            // 3. Pass the connection to a command object
            SqlCommand cmd = new SqlCommand(
                "SELECT ContactName, City, CompanyName FROM Customers", conn);

            // 4. Execute and read the data
            rdr = cmd.ExecuteReader();

            // Print header
            Console.WriteLine("{0,-25} {1,-20} {2}", "Contact Name", "City", "Company Name");
            Console.WriteLine(new string('-', 25) + " " + new string('-', 20) + " " + new string('-', 40));

            // Print each row
            while (rdr.Read())
            {
                Console.WriteLine("{0,-25} {1,-20} {2}",
                    rdr["ContactName"],
                    rdr["City"],
                    rdr["CompanyName"]);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            // Close the reader
            if (rdr != null)
                rdr.Close();

            // 5. Close the connection
            if (conn != null)
                conn.Close();
        }
    }
}
