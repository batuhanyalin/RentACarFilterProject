using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RentACarFilterProject.Areas.Admin.Controllers
{
 
    [Area("Admin")]
    [Route("Admin/[controller]")]
	[Authorize(Roles = "Admin")]
	public class DefaultController : Controller
    {
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
