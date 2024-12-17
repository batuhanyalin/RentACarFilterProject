using Microsoft.AspNetCore.Mvc;

namespace RentACarFilterProject.Areas.Admin.Controllers
{
    public class BrandController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
