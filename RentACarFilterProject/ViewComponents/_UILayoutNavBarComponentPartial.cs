using Microsoft.AspNetCore.Mvc;

namespace RentACarFilterProject.ViewComponents
{
    public class _UILayoutNavBarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
