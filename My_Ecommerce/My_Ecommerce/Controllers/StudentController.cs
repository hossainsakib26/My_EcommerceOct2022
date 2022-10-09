using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace My_Ecommerce.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
