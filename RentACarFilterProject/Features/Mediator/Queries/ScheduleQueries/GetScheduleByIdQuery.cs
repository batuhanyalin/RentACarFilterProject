using MediatR;
using RentACarFilterProject.Features.Mediator.Results.ScheduleResults;

namespace RentACarFilterProject.Features.Mediator.Queries.ScheduleQueries
{
    public class GetScheduleByIdQuery:IRequest<GetScheduleByIdQueryResult>
    {
        public int Id { get; set; }

        public GetScheduleByIdQuery(int id)
        {
            Id = id;
        }
    }
}
