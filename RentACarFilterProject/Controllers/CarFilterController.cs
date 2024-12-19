using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RentACarFilterProject.Features.Mediator.Queries.CarQueries;
using RentACarFilterProject.Models.CarModels;

namespace RentACarFilterProject.Controllers
{
    [AllowAnonymous]
    public class CarFilterController : Controller
    {
        private readonly IMediator _mediator;

        public CarFilterController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IActionResult> Index(CarFilterViewModel model)
        {

            var values = await _mediator.Send(new GetCarFilterQuery(model.PickUpLocationId, model.DropOffLocationId, model.PickUpDate, model.DropOffDate));
            return View(values);
        }
    }
}
