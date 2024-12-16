namespace RentACarFilterProject.DAL.Entities
{
    public class Car
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Fuel { get; set; }
        public string Transmission { get; set; }
        public string ImageUrl { get; set; }
        public int Seat { get; set; }
        public int LuggageCapacity { get; set; }
        public decimal Price { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public List<Schedule> Schedules { get; set; }

    }
}
