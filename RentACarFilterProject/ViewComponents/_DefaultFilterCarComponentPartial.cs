using Microsoft.AspNetCore.Mvc;

namespace RentACarFilterProject.ViewComponents
{
    public class _DefaultFilterCarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
