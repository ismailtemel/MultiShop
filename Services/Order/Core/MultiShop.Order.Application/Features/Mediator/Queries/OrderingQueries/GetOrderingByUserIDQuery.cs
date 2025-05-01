using MediatR;
using MultiShop.Order.Application.Features.Mediator.Results.OrderingResults;

namespace MultiShop.Order.Application.Features.Mediator.Queries.OrderingQueries
{
    public class GetOrderingByUserIDQuery : IRequest<List<GetOrderingByUserIDQueryResult>>
    {
        public string Id { get; set; }

        public GetOrderingByUserIDQuery(string id)
        {
            Id = id;
        }
    }
}
