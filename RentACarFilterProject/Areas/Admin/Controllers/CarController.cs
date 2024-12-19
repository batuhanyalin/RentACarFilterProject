using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RentACarFilterProject.Features.CQRS.Handlers.BrandHandlers;
using RentACarFilterProject.Features.CQRS.Handlers.LocationHandlers;
using RentACarFilterProject.Features.Mediator.Commands.CarCommands;
using RentACarFilterProject.Features.Mediator.Queries.CarQueries;

namespace RentACarFilterProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class CarController : Controller
    {
        private readonly IMediator _mediator;
        private readonly GetBrandQueryHandler _getBrandQueryHandler;
        private readonly GetLocationQueryHandler _getLocationQueryHandler;
        public CarController(IMediator mediator, GetBrandQueryHandler getBrandQueryHandler, GetLocationQueryHandler getLocationQueryHandler)
        {
            _mediator = mediator;
            _getBrandQueryHandler = getBrandQueryHandler;
            _getLocationQueryHandler = getLocationQueryHandler;
        }
        [HttpGet]
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetCarQuery());
            return View(values);
        }
        [HttpGet]
        [Route("CreateCar")]
        public async Task<IActionResult> CreateCar()
        {
            var brandHandler = _getBrandQueryHandler.Handle();
            var locationHandler = _getLocationQueryHandler.Handle();
            List<SelectListItem> brand = (from x in brandHandler
                                          select new SelectListItem
                                          {
                                              Text = x.Name,
                                              Value = x.BrandId.ToString()
                                          }).ToList();
            List<SelectListItem> location = (from x in locationHandler
                                             select new SelectListItem
                                             {
                                                 Text = x.Name,
                                                 Value = x.LocationId.ToString()
                                             }).ToList();

            ViewBag.brandList = brand;
            ViewBag.locationList = location;
            return View();
        }
        [HttpPost]
        [Route("CreateCar")]
        public async Task<IActionResult> CreateCar(CreateCarCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("UpdateCar/{id:int}")]
        public async Task<IActionResult> UpdateCar(int id)
        {
            var brandHandler = _getBrandQueryHandler.Handle();
            var locationHandler = _getLocationQueryHandler.Handle();
            var value = await _mediator.Send(new GetCarByIdQuery(id));
            List<SelectListItem> brand= (from x in brandHandler
                                         select new SelectListItem
                                         {
                                             Text = x.Name,
                                             Value=x.BrandId.ToString()
                                         }).ToList();
            List<SelectListItem> location = (from x in locationHandler
                                          select new SelectListItem
                                          {
                                              Text = x.Name,
                                              Value = x.LocationId.ToString()
                                          }).ToList();

            ViewBag.brandList=brand;
            ViewBag.locationList= location;
            return View(value);
        }
        [HttpPost]
        [Route("UpdateCar/{id:int}")]
        public async Task<IActionResult> UpdateCar(UpdateCarCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
        [Route("DeleteCar/{id:int}")]
        public async Task<IActionResult> DeleteCar(int id)
        {
            await _mediator.Send(new DeleteCarCommand(id));
            return RedirectToAction("Index");
        }
    }
}
