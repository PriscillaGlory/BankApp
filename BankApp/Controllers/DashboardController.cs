using Microsoft.AspNetCore.Mvc;

namespace BankApp.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
