using MediatR;
using RentACarFilterProject.DAL.Context;
using RentACarFilterProject.Features.Mediator.Commands.ScheduleCommands;

namespace RentACarFilterProject.Features.Mediator.Handlers.ScheduleHandlers
{
    public class UpdateScheduleCommandHandler : IRequestHandler<UpdateScheduleCommand>
    {
        private readonly RentACarFilterContext _context;

        public UpdateScheduleCommandHandler(RentACarFilterContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateScheduleCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Schedules.FindAsync(request.ScheduleId);
            value.DropOffLocationId = request.DropOffLocationId;
            value.ScheduleId = request.ScheduleId;
            value.CarId = request.CarId;
            value.PicUpLocationId = request.PicUpLocationId;
            value.DropOffDate = request.DropOffDate;
            value.PickUpDate = request.PickUpDate;
            value.ReservationStatus = request.ReservationStatus;
           await _context.SaveChangesAsync();
        }
    }
}
