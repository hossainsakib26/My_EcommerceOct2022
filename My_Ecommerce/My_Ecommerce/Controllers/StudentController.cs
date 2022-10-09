using Microsoft.AspNetCore.Mvc;

namespace My_Ecommerce.Controllers
{
    public class StudentController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public string Index ()
        {
            return "Default Action";
        } 

        public string Welcome()
        {
            return "Welcome Actoon";
        }
    }
}
