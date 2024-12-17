using Microsoft.AspNetCore.Mvc;

namespace RentACarFilterProject.Areas.Admin.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
