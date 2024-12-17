namespace RentACarFilterProject.Features.CQRS.Commands.LocationCommands
{
    public class DeleteLocationCommand
    {
        public int Id { get; set; }

        public DeleteLocationCommand(int id)
        {
            Id = id;
        }
    }
}
