using System;
using System.Data;
using System.Data.SqlClient;

namespace Lesson04
{
    class ReaderDemo
    {
        static void Main()
        {
            ReaderDemo rd = new ReaderDemo();
            rd.SimpleRead();
        }

        public void SimpleRead()
        {
            // declare the SqlDataReader, which is used in
            // both the try block and the finally block
            SqlDataReader rdr = null;

            // create a connection object
            SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True");

            // create a command object
            SqlCommand cmd = new SqlCommand("select * from Customers", conn);

            try
            {
                // open the connection
                conn.Open();

                // 1. get an instance of the SqlDataReader
                rdr = cmd.ExecuteReader();

                // print a set of column headers
                Console.WriteLine("Contact Name           City                 Company Name");
                Console.WriteLine("-------------          -------------         -------------");

                // 2. print necessary columns of each record
                while (rdr.Read())
                {
                    // get the results of each column
                    string contact = (string)rdr["ContactName"];
                    string company = (string)rdr["CompanyName"];
                    string city = (string)rdr["City"];

                    // print out the results
                    Console.Write("{0,-25}", contact);
                    Console.Write("{0,-20}", city);
                    Console.Write("{0,-25}", company);
                    Console.WriteLine();
                }
            }
            finally
            {
                // close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                // close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
