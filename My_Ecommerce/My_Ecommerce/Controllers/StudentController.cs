using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

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

        public string Welcome(string name, int numTimes = 1)
        {
            var data = HtmlEncoder.Default.Encode($"hello {name}, numtimes is: {numTimes}");
            return data;
        }
    }
}
