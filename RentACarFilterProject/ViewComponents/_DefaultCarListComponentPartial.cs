using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentACarFilterProject.Features.Mediator.Queries.CarQueries;

namespace RentACarFilterProject.ViewComponents
{
    public class _DefaultCarListComponentPartial : ViewComponent
    {
        private readonly IMediator _mediator;

        public _DefaultCarListComponentPartial(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _mediator.Send(new GetCarQuery());
            if (values.Count > 6)
            {
                values = values.Take(6).ToList();
            }
            return View(values);
        }
    }
}
