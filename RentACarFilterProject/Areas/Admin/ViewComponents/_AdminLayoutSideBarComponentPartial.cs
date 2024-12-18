using Microsoft.AspNetCore.Mvc;

namespace RentACarFilterProject.Areas.Admin.ViewComponents
{
    public class _AdminLayoutSideBarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
