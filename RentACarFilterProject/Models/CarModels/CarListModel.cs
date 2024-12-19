namespace RentACarFilterProject.Models.CarModels
{
    public class CarListModel
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
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
        public string LocationName { get; set; }
    }
}
