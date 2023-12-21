using Microsoft.AspNetCore.Mvc;

namespace StoreApp.Areas.Admin.Contollers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}