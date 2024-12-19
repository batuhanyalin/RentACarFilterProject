using RentACarFilterProject.DAL.Entities;

namespace RentACarFilterProject.Models.ScheduleModels
{
    public class ScheduleCreateModel
    {
        public int ScheduleId { get; set; }
        public int CarId { get; set; }
        public int PicUpLocationId { get; set; }
        public int DropOffLocationId { get; set; }
        public string ReservationStatus { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime DropOffDate { get; set; }
    }
}
