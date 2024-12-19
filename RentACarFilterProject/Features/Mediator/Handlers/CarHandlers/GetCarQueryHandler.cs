using MediatR;
using Microsoft.EntityFrameworkCore;
using RentACarFilterProject.DAL.Context;
using RentACarFilterProject.Features.Mediator.Queries.CarQueries;
using RentACarFilterProject.Features.Mediator.Results.CarResults;

namespace RentACarFilterProject.Features.Mediator.Handlers.CarHandlers
{
    public class GetCarQueryHandler : IRequestHandler<GetCarQuery, List<GetCarQueryResult>>
    {
        private readonly RentACarFilterContext _context;

        public GetCarQueryHandler(RentACarFilterContext context)
        {
            _context = context;
        }

        public async Task<List<GetCarQueryResult>> Handle(GetCarQuery request, CancellationToken cancellationToken)
        {

            return await _context.Cars.Select(x => new GetCarQueryResult
            {
                BrandId = x.BrandId,
                BrandName = x.Brand.Name,
                CarId = x.CarId,
                Doors = x.Doors,
                Fuel = x.Fuel,
                ImageUrl = x.ImageUrl,
                LocationId = x.LocationId,
                LocationName = x.Location.Name,
                LuggageCapacity = x.LuggageCapacity,
                Model = x.Model,
                Price = x.Price,
                Seat = x.Seat,
                Transmission = x.Transmission,
                Year = x.Year
            }).ToListAsync();
         

        }
    }
}
