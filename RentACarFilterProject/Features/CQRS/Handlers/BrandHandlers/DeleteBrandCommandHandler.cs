using RentACarFilterProject.DAL.Context;
using RentACarFilterProject.Features.CQRS.Commands.BrandCommands;

namespace RentACarFilterProject.Features.CQRS.Handlers.BrandHandlers
{
    public class DeleteBrandCommandHandler
    {
        private readonly RentACarFilterContext _context;

        public DeleteBrandCommandHandler(RentACarFilterContext context)
        {
            _context = context;
        }
        public void Handle(DeleteBrandCommand request)
        {
            var value = _context.Brands.Find(request.Id);
            _context.Brands.Remove(value);
            _context.SaveChanges();
        }
    }
}
