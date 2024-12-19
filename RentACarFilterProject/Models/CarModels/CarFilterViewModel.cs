namespace RentACarFilterProject.Models.CarModels
{
    public class CarFilterViewModel
    {
        public int PickUpLocationId { get; set; }
        public int DropOffLocationId { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime DropOffDate { get; set; }
    }
}
