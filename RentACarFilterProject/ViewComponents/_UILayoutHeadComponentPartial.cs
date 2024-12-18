using Microsoft.AspNetCore.Mvc;

namespace RentACarFilterProject.ViewComponents
{
    public class _UILayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
