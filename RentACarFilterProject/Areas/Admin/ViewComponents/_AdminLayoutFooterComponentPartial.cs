using Microsoft.AspNetCore.Mvc;

namespace RentACarFilterProject.Areas.Admin.ViewComponents
{
    public class _AdminLayoutFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
