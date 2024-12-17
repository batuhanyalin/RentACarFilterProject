using Microsoft.AspNetCore.Mvc;

namespace RentACarFilterProject.Areas.Admin.Controllers
{
    public class ReservationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
