using Microsoft.AspNetCore.Mvc;

namespace BankApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
