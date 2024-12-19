using MediatR;
using RentACarFilterProject.DAL.Context;
using RentACarFilterProject.Features.Mediator.Commands.CarCommands;

namespace RentACarFilterProject.Features.Mediator.Handlers.CarHandlers
{
    public class UpdateCarCommandHandler : IRequestHandler<UpdateCarCommand>
    {
        private readonly RentACarFilterContext _context;

        public UpdateCarCommandHandler(RentACarFilterContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateCarCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Cars.FindAsync(request.CarId);
            value.Transmission = request.Transmission;
            value.CarId = request.CarId;
            value.BrandId = request.BrandId;
            value.LocationId = request.LocationId;
            value.Price = request.Price;
            value.Doors = request.Doors;
            value.Seat = request.Seat;
            value.Fuel = request.Fuel;
            value.LuggageCapacity = request.LuggageCapacity;
            value.Year = request.Year;
            await _context.SaveChangesAsync();
        }
    }
}
