using MediatR;
using RentACarFilterProject.Features.Mediator.Results.CarResults;

namespace RentACarFilterProject.Features.Mediator.Queries.CarQueries
{
    public class GetCarByIdQuery:IRequest<GetCarByIdQueryResult>
    {
        public int Id { get; set; }

        public GetCarByIdQuery(int id)
        {
            Id = id;
        }
    }
}
