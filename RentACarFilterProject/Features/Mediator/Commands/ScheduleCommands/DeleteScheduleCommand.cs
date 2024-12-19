using MediatR;

namespace RentACarFilterProject.Features.Mediator.Commands.ScheduleCommands
{
    public class DeleteScheduleCommand : IRequest
    {
        public int Id { get; set; }

        public DeleteScheduleCommand(int id)
        {
            Id = id;
        }
    }
}
