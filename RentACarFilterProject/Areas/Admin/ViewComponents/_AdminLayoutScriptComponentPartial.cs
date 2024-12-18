using Microsoft.AspNetCore.Mvc;

namespace RentACarFilterProject.Areas.Admin.ViewComponents
{
    public class _AdminLayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
