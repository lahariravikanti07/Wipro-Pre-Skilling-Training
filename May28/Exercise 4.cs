using System;
using System.Data;
using System.Data.SqlClient;

class UpdateEmployeeTitle
{
    static void Main()
    {
        Console.Write("Enter Employee ID: ");
        int employeeId = int.Parse(Console.ReadLine());

        Console.Write("Enter New Title: ");
        string newTitle = Console.ReadLine();

        UpdateTitle(employeeId, newTitle);
    }

    static void UpdateTitle(int employeeId, string newTitle)
    {
        SqlConnection conn = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=SSPI");

        try
        {
            conn.Open();

            string updateQuery = "UPDATE Employees SET Title = @title WHERE EmployeeID = @employeeId";

            SqlCommand cmd = new SqlCommand(updateQuery, conn);

            // Add parameters
            cmd.Parameters.AddWithValue("@title", newTitle);
            cmd.Parameters.AddWithValue("@employeeId", employeeId);

            int rowsAffected = cmd.ExecuteNonQuery();

            Console.WriteLine(rowsAffected > 0
                ? "Employee title updated successfully."
                : "No employee found with the specified ID.");
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
