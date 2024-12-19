using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace RentACarFilterProject.Controllers
{
    public class CarFilterController : Controller
    {
        private readonly IMediator _mediator;

        public CarFilterController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
