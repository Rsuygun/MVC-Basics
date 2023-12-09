using BtkAkademi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BtkAkademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);
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
            if(Repository.Applications.Any(c => c.Email.Equals(model.Email)))
            {
                ModelState.AddModelError("", "There is already application for you.");
            }

            if(ModelState.IsValid)
            {
            Repository.Add(model);
            return View("Feedback", model);
            }
            return View();
        }
    }
}