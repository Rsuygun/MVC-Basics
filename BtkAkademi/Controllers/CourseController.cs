using BtkAkademi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BtkAkademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Apply()
        {
            return View();
        }
        // Biz "HttpPost" olarak tanımlamazsak "HttpGet" olarak kabul eder.
        [HttpPost]
        // Formu güvenli hale getirmek için hangi 
        // tarayıcıyla bağlantı kurduğunu doğrulayacak bir mekanizma eklemesi yaptık.
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm]Candidate model)
        {
            return View();
        }
    }
}