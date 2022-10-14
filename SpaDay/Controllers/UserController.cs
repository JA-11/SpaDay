using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/user/add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if (newUser.Password == verify)
            {
                ViewBag.user = newUser;
                return View("Index");
            }
            else
            {
                ViewBag.error = "Passwords do not match. Please try again!";
                ViewBag.username = newUser.Username;
                ViewBag.email = newUser.Email;
                return View("Add");
            }
        }
    }
}
