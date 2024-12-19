using RentACarFilterProject.DAL.Context;
using RentACarFilterProject.Features.CQRS.Results.BrandResults;

namespace RentACarFilterProject.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandQueryHandler
    {
        private readonly RentACarFilterContext _context;

        public GetBrandQueryHandler(RentACarFilterContext context)
        {
            _context = context;
        }
        public List<GetBrandQueryResult> Handle()
        {
            var values = _context.Brands.Select(x => new GetBrandQueryResult
            {
                Name = x.Name,
                BrandId = x.BrandId,
            });
            return values.ToList();
        }
    }
}
