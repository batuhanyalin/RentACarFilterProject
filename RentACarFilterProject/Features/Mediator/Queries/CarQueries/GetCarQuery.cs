using MediatR;
using RentACarFilterProject.Features.Mediator.Results.CarResults;

namespace RentACarFilterProject.Features.Mediator.Queries.CarQueries
{
    public class GetCarQuery:IRequest<List<GetCarQueryResult>>
    {
    }
}
