using MediatR;
using RentACarFilterProject.DAL.Context;
using RentACarFilterProject.Features.Mediator.Queries.CarQueries;
using RentACarFilterProject.Features.Mediator.Results.CarResults;

namespace RentACarFilterProject.Features.Mediator.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler : IRequestHandler<GetCarByIdQuery, GetCarByIdQueryResult>
    {
        private readonly RentACarFilterContext _context;

        public GetCarByIdQueryHandler(RentACarFilterContext context)
        {
            _context = context;
        }

        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _context.Cars.FindAsync(request.Id);
            return new GetCarByIdQueryResult
            {
                BrandId = value.BrandId,
                CarId = value.CarId,
                Doors = value.Doors,
                Fuel = value.Fuel,
                ImageUrl = value.ImageUrl,
                LocationId = value.LocationId,
                LuggageCapacity = value.LuggageCapacity,
                Model = value.Model,
                Price = value.Price,
                Seat = value.Seat,
                Transmission = value.Transmission,
                Year = value.Year
            };
        }
    }
}
