using Microsoft.AspNetCore.Mvc;

namespace RentACarFilterProject.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
