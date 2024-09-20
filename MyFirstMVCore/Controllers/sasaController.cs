using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVCore.Controllers
{
    public class sasaController : Controller
    {
        public IActionResult myName()
        {
            return View();
        }
    }
}
