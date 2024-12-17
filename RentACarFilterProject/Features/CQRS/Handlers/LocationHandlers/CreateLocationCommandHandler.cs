using RentACarFilterProject.DAL.Context;
using RentACarFilterProject.DAL.Entities;
using RentACarFilterProject.Features.CQRS.Commands.LocationCommands;

namespace RentACarFilterProject.Features.CQRS.Handlers.LocationHandlers
{
    public class CreateLocationCommandHandler
    {
        private readonly RentACarFilterContext _context;

        public CreateLocationCommandHandler(RentACarFilterContext context)
        {
            _context = context;
        }
        public void Handle(CreateLocationCommand command)
        {
            _context.Add(new Location
            {
                Name = command.Name,
            });
            _context.SaveChanges();
        }
    }
}
