using RentACarFilterProject.DAL.Context;
using RentACarFilterProject.Features.CQRS.Queries.BrandQueries;
using RentACarFilterProject.Features.CQRS.Results.BrandResults;

namespace RentACarFilterProject.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler
    {
        private readonly RentACarFilterContext _context;

        public GetBrandByIdQueryHandler(RentACarFilterContext context)
        {
            _context = context;
        }
        public GetBrandByIdQueryResult Handle(GetBrandByIdQuery request)
        {
            var value= _context.Brands.Find(request.Id);
            return new GetBrandByIdQueryResult
            {
                BrandId = value.BrandId,
                Name = value.Name,
            };
        }
    }
}
