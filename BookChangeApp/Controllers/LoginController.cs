using Microsoft.AspNetCore.Mvc;

namespace Namespace
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }
        
        
    }
}