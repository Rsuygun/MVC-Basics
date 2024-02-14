using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StoreApp.Areas.Admin.Contollers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]

    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            TempData["info"] = $"Welcome Back, {DateTime.Now.ToShortTimeString()}";
            return View();
        }
    }
}