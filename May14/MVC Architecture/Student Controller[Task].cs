using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "This is Student Index";
        }

        public string GetStudentName()
        {
            return "The Student Name is Lahari Ravikanti";
        }

        public string GetStudentPhone()
        {
            return "The Phone Number of Student is 2468013579";
        }
    }
}


// HERE THE CONTROLLER IS STUDENT
// THE ACTIONS ARE INDEX, GETSTUDENTNAME, GETSTUDENTPHONE

// ON EXECUTION CHANGE THE URL AS "LOCALHOST:5095/CONTROLLER/ACTION"