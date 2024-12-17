namespace RentACarFilterProject.Features.CQRS.Commands.BrandCommands
{
    public class DeleteBrandCommand
    {
        public int Id { get; set; }

        public DeleteBrandCommand(int id)
        {
            Id = id;
        }
    }
}
