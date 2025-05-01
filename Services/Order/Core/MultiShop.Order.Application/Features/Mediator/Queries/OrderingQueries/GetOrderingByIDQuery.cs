using MediatR;
using MultiShop.Order.Application.Features.Mediator.Results.OrderingResults;

namespace MultiShop.Order.Application.Features.Mediator.Queries.OrderingQueries
{
    public class GetOrderingByIDQuery : IRequest<GetOrderingByIDQueryResult>
    {
        public int ID { get; set; }

        public GetOrderingByIDQuery(int id)
        {
            ID = id;
        }
    }
}
