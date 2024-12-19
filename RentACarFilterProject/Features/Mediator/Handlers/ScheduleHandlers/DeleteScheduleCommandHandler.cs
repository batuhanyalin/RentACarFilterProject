using MediatR;
using RentACarFilterProject.DAL.Context;
using RentACarFilterProject.Features.Mediator.Commands.ScheduleCommands;

namespace RentACarFilterProject.Features.Mediator.Handlers.ScheduleHandlers
{
    public class DeleteScheduleCommandHandler : IRequestHandler<DeleteScheduleCommand>
    {
        private readonly RentACarFilterContext _context;

        public DeleteScheduleCommandHandler(RentACarFilterContext context)
        {
            _context = context;
        }
        public async Task Handle(DeleteScheduleCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Schedules.FindAsync(request.Id);
            _context.Schedules.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
