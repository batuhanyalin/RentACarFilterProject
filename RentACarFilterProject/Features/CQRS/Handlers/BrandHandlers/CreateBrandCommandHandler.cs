using RentACarFilterProject.DAL.Context;
using RentACarFilterProject.DAL.Entities;
using RentACarFilterProject.Features.CQRS.Commands.BrandCommands;

namespace RentACarFilterProject.Features.CQRS.Handlers.BrandHandlers
{
    public class CreateBrandCommandHandler
    {
        private readonly RentACarFilterContext _context;

        public CreateBrandCommandHandler(RentACarFilterContext context)
        {
            _context = context;
        }
        public void Handle(CreateBrandCommand command)
        {
            _context.Add(new Brand
            {
                Name = command.Name,
            });
            _context.SaveChanges();
        }
    }
}
