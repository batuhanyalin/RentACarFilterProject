using RentACarFilterProject.DAL.Context;
using RentACarFilterProject.Features.CQRS.Commands.BrandCommands;
using RentACarFilterProject.Features.CQRS.Commands.LocationCommands;

namespace RentACarFilterProject.Features.CQRS.Handlers.LocationHandlers
{
    public class DeleteLocationCommandHandler
    {
        private readonly RentACarFilterContext _context;

        public DeleteLocationCommandHandler(RentACarFilterContext context)
        {
            _context = context;
        }
        public void Handle(DeleteLocationCommand request)
        {
            var value = _context.Locations.Find(request.Id);
            _context.Locations.Remove(value);
            _context.SaveChanges();
        }
    }
}
