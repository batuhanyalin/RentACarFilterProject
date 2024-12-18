using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RentACarFilterProject.Controllers
{
	[AllowAnonymous]
	public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
