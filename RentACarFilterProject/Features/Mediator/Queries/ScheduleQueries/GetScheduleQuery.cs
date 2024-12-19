using MediatR;
using RentACarFilterProject.Features.Mediator.Results.ScheduleResults;

namespace RentACarFilterProject.Features.Mediator.Queries.ScheduleQueries
{
    public class GetScheduleQuery:IRequest<List<GetScheduleQueryResult>>
    {
    }
}
