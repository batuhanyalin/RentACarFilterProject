using MediatR;
using RentACarFilterProject.DAL.Context;
using RentACarFilterProject.DAL.Entities;
using RentACarFilterProject.Features.Mediator.Commands.ScheduleCommands;

namespace RentACarFilterProject.Features.Mediator.Handlers.ScheduleHandlers
{
    public class CreateScheduleCommandHandler : IRequestHandler<CreateScheduleCommand>
    {
        private readonly RentACarFilterContext _context;

        public CreateScheduleCommandHandler(RentACarFilterContext context)
        {
            _context = context;
        }
        public async Task Handle(CreateScheduleCommand request, CancellationToken cancellationToken)
        {
            _context.Schedules.Add(new Schedule
            {
                CarId = request.CarId,
                DropOffDate = request.DropOffDate,
                PicUpLocationId = request.PicUpLocationId,
                DropOffLocationId = request.DropOffLocationId,
                PickUpDate = request.PickUpDate,
                ReservationStatus = request.ReservationStatus,
                ScheduleId = request.ScheduleId,
            });
            _context.SaveChanges();
        }
    }
}
