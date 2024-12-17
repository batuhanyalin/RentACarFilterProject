using Microsoft.AspNetCore.Mvc;

namespace RentACarFilterProject.Areas.Admin.Controllers
{
    public class LocationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
