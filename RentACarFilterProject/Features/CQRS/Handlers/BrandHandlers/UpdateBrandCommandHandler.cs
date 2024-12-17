using RentACarFilterProject.DAL.Context;
using RentACarFilterProject.Features.CQRS.Commands.BrandCommands;

namespace RentACarFilterProject.Features.CQRS.Handlers.BrandHandlers
{
    public class UpdateBrandCommandHandler
    {
        private readonly RentACarFilterContext _context;

        public UpdateBrandCommandHandler(RentACarFilterContext context)
        {
            _context = context;
        }
        public void Handle(UpdateBrandCommand command)
        {
            var value = _context.Brands.Find(command.BrandId);
            value.Name = command.Name;
            _context.SaveChanges();
        }
    }
}
