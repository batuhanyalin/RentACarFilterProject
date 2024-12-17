namespace RentACarFilterProject.DAL.Entities
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int PicUpLocationId { get; set; }
        public Location PickUpLocation { get; set; }
        public int DropOffLocationId { get; set; }
        public Location DropOffLocation { get; set; }
        public string ReservationStatus { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime DropOffDate { get; set; }

    }
}
