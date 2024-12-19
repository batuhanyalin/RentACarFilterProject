using Microsoft.AspNetCore.Mvc;
using RentACarFilterProject.Features.CQRS.Commands.LocationCommands;
using RentACarFilterProject.Features.CQRS.Handlers.LocationHandlers;
using RentACarFilterProject.Features.CQRS.Queries.LocationQueries;

namespace RentACarFilterProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class LocationController : Controller
    {
        private readonly CreateLocationCommandHandler _createLocationCommandHandler;
        private readonly UpdateLocationCommandHandler _updateLocationCommandHandler;
        private readonly DeleteLocationCommandHandler _deleteLocationCommandHandler;
        private readonly GetLocationByIdQueryHandler _getLocationByIdQueryHandler;
        private readonly GetLocationQueryHandler _getLocationQueryHandler;

        public LocationController(CreateLocationCommandHandler createLocationCommandHandler, UpdateLocationCommandHandler updateLocationCommandHandler, DeleteLocationCommandHandler deleteLocationCommandHandler, GetLocationByIdQueryHandler getLocationByIdQueryHandler, GetLocationQueryHandler getLocationQueryHandler)
        {
            _createLocationCommandHandler = createLocationCommandHandler;
            _updateLocationCommandHandler = updateLocationCommandHandler;
            _deleteLocationCommandHandler = deleteLocationCommandHandler;
            _getLocationByIdQueryHandler = getLocationByIdQueryHandler;
            _getLocationQueryHandler = getLocationQueryHandler;
        }
        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            var values = _getLocationQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        [Route("CreateLocation")]
        public IActionResult CreateLocation()
        {
            return View();
        }
        [HttpPost]
        [Route("CreateLocation")]
        public IActionResult CreateLocation(CreateLocationCommand command)
        {
            _createLocationCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("UpdateLocation/{id:int}")]
        public IActionResult UpdateLocation(int id)
        {
            var value = _getLocationByIdQueryHandler.Handle(new GetLocationByIdQuery(id));
            return View(value);
        }
        [HttpPost]
        [Route("UpdateLocation/{id:int}")]
        public IActionResult UpdateLocation(UpdateLocationCommand command)
        {
            _updateLocationCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        [Route("DeleteLocation/{id:int}")]
        public IActionResult DeleteLocation(int id)
        {
            _deleteLocationCommandHandler.Handle(new DeleteLocationCommand(id));
            return RedirectToAction("Index");
        }
    }
}
