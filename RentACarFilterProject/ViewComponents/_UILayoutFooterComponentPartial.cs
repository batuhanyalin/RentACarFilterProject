using Microsoft.AspNetCore.Mvc;

namespace RentACarFilterProject.ViewComponents
{
    public class _UILayoutFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
