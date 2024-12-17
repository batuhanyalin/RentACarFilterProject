using RentACarFilterProject.DAL.Context;
using RentACarFilterProject.Features.CQRS.Commands.LocationCommands;

namespace RentACarFilterProject.Features.CQRS.Handlers.LocationHandlers
{
    public class UpdateLocationCommandHandler
    {
        private readonly RentACarFilterContext _context;

        public UpdateLocationCommandHandler(RentACarFilterContext context)
        {
            _context = context;
        }
        public void Handle(UpdateLocationCommand command)
        {
            var value = _context.Locations.Find(command.LocationId);
            value.Name = command.Name;
            _context.SaveChanges();
        }
    }
}
