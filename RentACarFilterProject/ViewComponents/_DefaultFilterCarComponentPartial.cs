using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RentACarFilterProject.DAL.Entities;
using RentACarFilterProject.Features.CQRS.Handlers.LocationHandlers;

namespace RentACarFilterProject.ViewComponents
{
    public class _DefaultFilterCarComponentPartial : ViewComponent
    {
        private readonly GetLocationQueryHandler _getLocationQueryHandler;

        public _DefaultFilterCarComponentPartial(GetLocationQueryHandler getLocationQueryHandler)
        {
            _getLocationQueryHandler = getLocationQueryHandler;
        }

        public IViewComponentResult Invoke()
        {
            var locationHandler = _getLocationQueryHandler.Handle();
            List<SelectListItem> location = (from x in locationHandler
                                             select new SelectListItem
                                             {
                                                 Text = x.Name,
                                                 Value = x.LocationId.ToString()
                                             }).ToList();

            ViewBag.locationList = location;
            return View();
        }
    }
}
