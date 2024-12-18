using Microsoft.AspNetCore.Mvc;

namespace RentACarFilterProject.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
