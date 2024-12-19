using Microsoft.AspNetCore.Mvc;
using RentACarFilterProject.Features.CQRS.Commands.BrandCommands;
using RentACarFilterProject.Features.CQRS.Handlers.BrandHandlers;
using RentACarFilterProject.Features.CQRS.Queries.BrandQueries;

namespace RentACarFilterProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class BrandController : Controller
    {
        private readonly CreateBrandCommandHandler _createBrandCommandHandler;
        private readonly UpdateBrandCommandHandler _updateBrandCommandHandler;
        private readonly DeleteBrandCommandHandler _deleteBrandCommandHandler;
        private readonly GetBrandByIdQueryHandler _getBrandByIdQueryHandler;
        private readonly GetBrandQueryHandler _getBrandQueryHandler;

        public BrandController(CreateBrandCommandHandler createBrandCommandHandler, UpdateBrandCommandHandler updateBrandCommandHandler, DeleteBrandCommandHandler deleteBrandCommandHandler, GetBrandByIdQueryHandler getBrandByIdQueryHandler, GetBrandQueryHandler getBrandQueryHandler)
        {
            _createBrandCommandHandler = createBrandCommandHandler;
            _updateBrandCommandHandler = updateBrandCommandHandler;
            _deleteBrandCommandHandler = deleteBrandCommandHandler;
            _getBrandByIdQueryHandler = getBrandByIdQueryHandler;
            _getBrandQueryHandler = getBrandQueryHandler;
        }
        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            var values = _getBrandQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        [Route("CreateBrand")]
        public IActionResult CreateBrand()
        {
            return View();
        }
        [HttpPost]
        [Route("CreateBrand")]
        public IActionResult CreateBrand(CreateBrandCommand command)
        {
            _createBrandCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("UpdateBrand/{id:int}")]
        public IActionResult UpdateBrand(int id)
        {
            var value = _getBrandByIdQueryHandler.Handle(new GetBrandByIdQuery(id));
            return View(value);
        }
        [HttpPost]
        [Route("UpdateBrand/{id:int}")]
        public IActionResult UpdateBrand(UpdateBrandCommand command)
        {
            _updateBrandCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        [Route("DeleteBrand/{id:int}")]
        public IActionResult DeleteBrand(int id)
        {
            _deleteBrandCommandHandler.Handle(new DeleteBrandCommand(id));
            return RedirectToAction("Index");
        }
    }
}
