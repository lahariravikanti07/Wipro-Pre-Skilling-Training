using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        public string Index()
        {
            return "This is Employee Index";
        }

        public string FirstName()
        {
            return "My First Name is Lahari";
        }

        public string LastName()
        {
            return "My Last Name is Ravikanti";
        }
    }
}


// HERE THE CONTROLLER IS EMPLOYEE
// ACTIONS ARE INDEX, FIRSTNAME, LASTNAME

// URL SHOULD BE CHANGED INTO "LOCALHOST:5095/CONTROLLER/ACTION"