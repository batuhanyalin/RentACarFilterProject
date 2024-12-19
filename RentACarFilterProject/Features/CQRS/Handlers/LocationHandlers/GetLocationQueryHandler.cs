using RentACarFilterProject.DAL.Context;
using RentACarFilterProject.Features.CQRS.Results.LocationResults;

namespace RentACarFilterProject.Features.CQRS.Handlers.LocationHandlers
{
    public class GetLocationQueryHandler
    {
        private readonly RentACarFilterContext _context;

        public GetLocationQueryHandler(RentACarFilterContext context)
        {
            _context = context;
        }
        public List<GetLocationQueryResult> Handle()
        {
            var values = _context.Locations.Select(x => new GetLocationQueryResult
            {
                Name = x.Name,
                LocationId=x.LocationId,

            });
            return values.ToList();
        }
    }
}
