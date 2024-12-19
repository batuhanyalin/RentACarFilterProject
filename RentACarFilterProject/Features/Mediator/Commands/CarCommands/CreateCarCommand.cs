using MediatR;

namespace RentACarFilterProject.Features.Mediator.Commands.CarCommands
{
    public class CreateCarCommand : IRequest
    {
        public int BrandId { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Fuel { get; set; }
        public string Transmission { get; set; }
        public string ImageUrl { get; set; }
        public int Seat { get; set; }
        public int Doors { get; set; }
        public int LuggageCapacity { get; set; }
        public decimal Price { get; set; }
        public int LocationId { get; set; }
    }
}
