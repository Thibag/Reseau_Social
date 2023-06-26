using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class UserController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Create()
        {
        

            return View(new CreateViewModel());
        }
    }
}
