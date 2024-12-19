using MediatR;
using RentACarFilterProject.Features.Mediator.Results.CarResults;

namespace RentACarFilterProject.Features.Mediator.Queries.CarQueries
{
    public class GetCarFilterQuery:IRequest<List<GetCarQueryResult>>
    {
        public GetCarFilterQuery(int pickUpLocationId, int dropOffLocationId, DateTime pickUpDate, DateTime dropOffDate)
        {
            PickUpLocationId = pickUpLocationId;
            DropOffLocationId = dropOffLocationId;
            PickUpDate = pickUpDate;
            DropOffDate = dropOffDate;
        }

        public int PickUpLocationId { get; set; }
        public int DropOffLocationId { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime DropOffDate { get; set; }
    }
}
