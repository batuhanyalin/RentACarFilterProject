namespace RentACarFilterProject.DAL.Entities
{
    public class Location
    {
        public int LocationId { get; set; }
        public string Name { get; set; }
        public List<Schedule> PickUpSchedule { get; set; }
        public List<Schedule> DropOffSchedule { get; set; }
    }
}
