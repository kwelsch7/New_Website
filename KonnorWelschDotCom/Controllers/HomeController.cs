using Microsoft.AspNetCore.Mvc;

namespace KonnorWelschDotCom.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Portfolio()
        {
            return View();
        }
        
        public IActionResult Projects()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}