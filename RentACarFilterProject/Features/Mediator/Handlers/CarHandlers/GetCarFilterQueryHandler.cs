using MediatR;
using Microsoft.EntityFrameworkCore;
using RentACarFilterProject.DAL.Context;
using RentACarFilterProject.Features.Mediator.Queries.CarQueries;
using RentACarFilterProject.Features.Mediator.Results.CarResults;


namespace RentACarFilterProject.Features.Mediator.Handlers.CarHandlers
{
    public class GetCarFilterQueryHandler : IRequestHandler<GetCarFilterQuery, List<GetCarQueryResult>>
    {
        private readonly RentACarFilterContext _context;

        public GetCarFilterQueryHandler(RentACarFilterContext context)
        {
            _context = context;
        }

        public async Task<List<GetCarQueryResult>> Handle(GetCarFilterQuery request, CancellationToken cancellationToken)
        {
            var reservedCars = await _context.Schedules.Where(x => (request.PickUpDate >= x.PickUpDate && request.PickUpDate <= x.DropOffDate) || (request.DropOffDate >= x.PickUpDate && request.DropOffDate <= x.DropOffDate)).Select(x => x.CarId).ToListAsync();

            var command = _context.Cars.Where(x => !reservedCars.Contains(x.CarId) && x.LocationId == request.PickUpLocationId);

            return await command.Select(x => new GetCarQueryResult
            {
                CarId = x.CarId,
                LocationName = x.Location.Name,
                BrandName = x.Brand.Name,
                Fuel = x.Fuel,
                Doors = x.Doors,
                ImageUrl = x.ImageUrl,
                Model = x.Model,
                LuggageCapacity = x.LuggageCapacity,
                Price = x.Price,
                Seat = x.Seat,
                Transmission = x.Transmission,
                Year = x.Year,

            }).ToListAsync();

        }
    }
}
