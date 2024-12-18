using Microsoft.AspNetCore.Mvc;

namespace RentACarFilterProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
