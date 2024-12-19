using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RentACarFilterProject.Features.CQRS.Handlers.LocationHandlers;
using RentACarFilterProject.Features.Mediator.Commands.ScheduleCommands;
using RentACarFilterProject.Features.Mediator.Queries.CarQueries;
using RentACarFilterProject.Features.Mediator.Queries.ScheduleQueries;


namespace RentAScheduleFilterProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class ScheduleController : Controller
    {
        private readonly IMediator _mediator;
        private readonly GetLocationQueryHandler _getLocationQueryHandler;
        public ScheduleController(IMediator mediator, GetLocationQueryHandler getLocationQueryHandler)
        {
            _mediator = mediator;
            _getLocationQueryHandler = getLocationQueryHandler;
        }
        [HttpGet]
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetScheduleQuery());
            return View(values);
        }
        [HttpGet]
        [Route("CreateSchedule")]
        public async Task<IActionResult> CreateSchedule()
        {
            var locationHandler = _getLocationQueryHandler.Handle();
            var carMediator = await _mediator.Send(new GetCarQuery());

            List<SelectListItem> car = (from x in carMediator
                                             select new SelectListItem
                                             {
                                                 Text = $"{x.BrandName} {x.Model}",
                                                 Value = x.CarId.ToString()
                                             }).ToList();
            ViewBag.carList = car;


            List<SelectListItem> location = (from x in locationHandler
                                             select new SelectListItem
                                             {
                                                 Text = x.Name,
                                                 Value = x.LocationId.ToString()
                                             }).ToList();
            ViewBag.locationList = location;
            return View();
        }
        [HttpPost]
        [Route("CreateSchedule")]
        public async Task<IActionResult> CreateSchedule(CreateScheduleCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("UpdateSchedule/{id:int}")]
        public async Task<IActionResult> UpdateSchedule(int id)
        {
            var value = await _mediator.Send(new GetScheduleByIdQuery(id));
            var locationHandler = _getLocationQueryHandler.Handle();
            var carMediator = await _mediator.Send(new GetCarQuery());

            List<SelectListItem> car = (from x in carMediator
                                        select new SelectListItem
                                        {
                                            Text = $"{x.BrandName} {x.Model}",
                                            Value = x.CarId.ToString()
                                        }).ToList();
            ViewBag.carList = car;


            List<SelectListItem> location = (from x in locationHandler
                                             select new SelectListItem
                                             {
                                                 Text = x.Name,
                                                 Value = x.LocationId.ToString()
                                             }).ToList();
            ViewBag.locationList = location;
            return View(value);
        }
        [HttpPost]
        [Route("UpdateSchedule/{id:int}")]
        public async Task<IActionResult> UpdateSchedule(UpdateScheduleCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
        [Route("DeleteSchedule/{id:int}")]
        public async Task<IActionResult> DeleteSchedule(int id)
        {
            await _mediator.Send(new DeleteScheduleCommand(id));
            return RedirectToAction("Index");
        }
    }
}
