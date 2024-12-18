using Microsoft.AspNetCore.Mvc;

namespace RentACarFilterProject.ViewComponents
{
    public class _DefaultCarListComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
