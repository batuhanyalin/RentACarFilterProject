using RentACarFilterProject.DAL.Context;
using RentACarFilterProject.Features.CQRS.Queries.LocationQueries;
using RentACarFilterProject.Features.CQRS.Results.LocationResults;

namespace RentACarFilterProject.Features.CQRS.Handlers.LocationHandlers
{
    public class GetLocationByIdQueryHandler
    {
        private readonly RentACarFilterContext _context;

        public GetLocationByIdQueryHandler(RentACarFilterContext context)
        {
            _context = context;
        }
        public GetLocationByIdQueryResult Handle(GetLocationByIdQuery request)
        {
            var value = _context.Locations.Find(request.Id);
            return new GetLocationByIdQueryResult
            {
                LocationId = value.LocationId,
                Name = value.Name,
            };
        }
    }
}
