using MediatR;
using RentACarFilterProject.DAL.Context;
using RentACarFilterProject.DAL.Entities;
using RentACarFilterProject.Features.Mediator.Commands.CarCommands;

namespace RentACarFilterProject.Features.Mediator.Handlers.CarHandlers
{
    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand>
    {
        private readonly RentACarFilterContext _context;

        public CreateCarCommandHandler(RentACarFilterContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            _context.Cars.Add(new Car
            {
                BrandId = request.BrandId,
                Doors = request.Doors,
                Fuel = request.Fuel,
                ImageUrl = request.ImageUrl,
                LocationId = request.LocationId,
                LuggageCapacity = request.LuggageCapacity,
                Model = request.Model,
                Price = request.Price,
                Seat = request.Seat,
                Transmission = request.Transmission,
                Year = request.Year,
            });
            _context.SaveChanges();
        }
    }
}
