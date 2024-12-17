namespace RentACarFilterProject.Features.CQRS.Commands.LocationCommands
{
    public class UpdateLocationCommand
    {
        public int LocationId { get; set; }
        public string Name { get; set; }
    }
}
