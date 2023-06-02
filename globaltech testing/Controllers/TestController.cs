using globaltech_testing.Models;
using globaltech_testing.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace globaltech_testing.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult about()
        {
            return View();
        }
        public IActionResult contact()
        {
          /*  int a = 1;
            int b = 2;
            Console.WriteLine(a+b);
            Console.ReadLine();*/
            return View();
        }
        [HttpPost]
        public IActionResult contact(User users)
        {
            dbConnection db= new dbConnection();
            if (db.create(users))
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult team()
        {
            return View();
        }
    }
}
