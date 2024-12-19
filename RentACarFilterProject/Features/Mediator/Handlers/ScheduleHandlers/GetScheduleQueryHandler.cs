using MediatR;
using Microsoft.EntityFrameworkCore;
using RentACarFilterProject.DAL.Context;
using RentACarFilterProject.Features.Mediator.Queries.ScheduleQueries;
using RentACarFilterProject.Features.Mediator.Results.ScheduleResults;

namespace RentACarFilterProject.Features.Mediator.Handlers.ScheduleHandlers
{
    public class GetScheduleQueryHandler : IRequestHandler<GetScheduleQuery, List<GetScheduleQueryResult>>
    {
        private readonly RentACarFilterContext _context;

        public GetScheduleQueryHandler(RentACarFilterContext context)
        {
            _context = context;
        }
        public async Task<List<GetScheduleQueryResult>> Handle(GetScheduleQuery request, CancellationToken cancellationToken)
        {
            return await _context.Schedules.Select(x => new GetScheduleQueryResult
            {
                ScheduleId = x.ScheduleId,
                CarId = x.CarId,
                CarImage=x.Car.ImageUrl,
                DropOffDate = x.DropOffDate,
                CarName = $"{x.Car.Brand.Name} {x.Car.Model}",
                DropOffLocationName = x.DropOffLocation.Name,
                PickUpLocationName = x.PickUpLocation.Name,
                PickUpDate = x.PickUpDate,
                ReservationStatus = x.ReservationStatus,
            }).ToListAsync();
        }
    }
}
