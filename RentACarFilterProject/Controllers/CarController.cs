using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RentACarFilterProject.Features.Mediator.Queries.CarQueries;

namespace RentACarFilterProject.Controllers
{
	[AllowAnonymous]
	public class CarController : Controller
    {
        private readonly IMediator _mediator;

        public CarController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetCarQuery());
            return View(values);
        }
    }
}
