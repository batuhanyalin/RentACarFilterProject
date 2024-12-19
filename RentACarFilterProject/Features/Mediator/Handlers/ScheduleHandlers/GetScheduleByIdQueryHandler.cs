using MediatR;
using RentACarFilterProject.DAL.Context;
using RentACarFilterProject.Features.Mediator.Queries.ScheduleQueries;
using RentACarFilterProject.Features.Mediator.Results.ScheduleResults;

namespace RentACarFilterProject.Features.Mediator.Handlers.ScheduleHandlers
{
    public class GetScheduleByIdQueryHandler : IRequestHandler<GetScheduleByIdQuery, GetScheduleByIdQueryResult>
    {
        private readonly RentACarFilterContext _context;

        public GetScheduleByIdQueryHandler(RentACarFilterContext context)
        {
            _context = context;
        }

        public async Task<GetScheduleByIdQueryResult> Handle(GetScheduleByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _context.Schedules.FindAsync(request.Id);
            return new GetScheduleByIdQueryResult
            {
                CarId = value.CarId,
                DropOffDate = value.DropOffDate,
                DropOffLocationId = value.DropOffLocationId,
                PickUpDate = value.PickUpDate,
                PicUpLocationId = value.PicUpLocationId,
                ReservationStatus = value.ReservationStatus,
                ScheduleId = value.ScheduleId,
            };
        }
    }
}
