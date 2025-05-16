// Pull the data from any of the tables with a Join 
// Orders and Customers with Join "Customer ID"

using System;
using System.Data;
using System.Data.SqlClient;

namespace MyNorthwindApp
{
    class OrderReader
    {
        static void Main()
        {
            OrderReader rd = new OrderReader();
            rd.SimpleRead();
        }

        public void SimpleRead()
        {
            SqlDataReader rdr = null;

            SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True");

            SqlCommand cmd = new SqlCommand(
                "SELECT o.OrderID, c.CompanyName, c.ContactName, o.OrderDate, o.ShipCountry " +
                "FROM Orders o " +
                "INNER JOIN Customers c ON o.CustomerID = c.CustomerID", conn);

            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();

                Console.WriteLine("Order ID   Company Name               Contact Name             Order Date       Ship Country");
                Console.WriteLine("--------   ------------------------   -----------------------  ----------------  -------------");

                while (rdr.Read())
                {
                    int orderId = (int)rdr["OrderID"];
                    string company = (string)rdr["CompanyName"];
                    string contact = (string)rdr["ContactName"];
                    DateTime orderDate = (DateTime)rdr["OrderDate"];
                    string shipCountry = (string)rdr["ShipCountry"];

                    Console.Write("{0,-10}", orderId);
                    Console.Write("{0,-27}", company);
                    Console.Write("{0,-25}", contact);
                    Console.Write("{0,-18:yyyy-MM-dd}", orderDate);
                    Console.WriteLine("{0}", shipCountry);
                }
            }
            finally
            {
                if (rdr != null) rdr.Close();
                if (conn != null) conn.Close();
            }
        }
    }
}


