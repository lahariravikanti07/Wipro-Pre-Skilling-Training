using System;
using System.Data;
using System.Data.SqlClient;

class TotalSalesByCategory
{
    static void Main()
    {
        DisplayTotalSales();
    }

    static void DisplayTotalSales()
    {
        SqlConnection conn = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=SSPI");

        try
        {
            conn.Open();

            string query = @"
                SELECT p.CategoryID, SUM(od.UnitPrice * od.Quantity) AS TotalSales
                FROM [Order Details] od
                INNER JOIN Products p ON od.ProductID = p.ProductID
                GROUP BY p.CategoryID";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();

            adapter.Fill(table);

            Console.WriteLine("{0,-12} {1}", "CategoryID", "Total Sales");
            Console.WriteLine(new string('-', 12) + " " + new string('-', 20));

            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine("{0,-12} {1:C2}", row["CategoryID"], row["TotalSales"]);
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
