using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVCore.Controllers
{
    public class EmployeeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ContentResult showContent()
        {
            #region oldCode
            //ContentResult result = new ContentResult();
            //result.Content = "Hello from content result";
            //return result;
            #endregion
            return Content("Hello from show contetntaaaa"); 
        }

        public ViewResult showView()
        {
            return View("MyView");
        }

        public ActionResult showMix()
        {
            var currentTime = TimeProvider.System.GetLocalNow();

            if(currentTime.DayOfWeek == DayOfWeek.Thursday)
            {
                return View("MyView");
            }
            else
            {
                return Content("Today is not sunday bitch!!");
            }
        }
        public IActionResult showMsg(string name, int age)
        {
            return Content($"Aloha There ! my name is {name} and my age is {age}");
        }
    }
}
