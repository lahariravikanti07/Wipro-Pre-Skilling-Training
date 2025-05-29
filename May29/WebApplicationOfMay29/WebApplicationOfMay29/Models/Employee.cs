namespace WebApplicationOfMay29.Models
{
    public class Employee
    {
         public int EmployeeId { get; set; }    // Unique identifier
        public string FirstName { get; set; }  // First Name
        public string LastName { get; set; }   // Last Name 
        public string EmployeeCode { get; set; }   // Custom internal employee code
        public decimal Salary { get; set; }     // Employee's salary
        public string Position { get; set; }    // Job title/role
        public DateTime DateOfBirth { get; set; }   // Date of birth
        public string Department { get; set; }   // Department name

    }
}
