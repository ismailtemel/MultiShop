namespace MultiShop.Order.Application.Features.CQRS.Queries.OrderDetailQueries
{
    public class GetOrderDetailByIDQuery
    {
        public int ID { get; set; }

        public GetOrderDetailByIDQuery(int id)
        {
            ID = id;
        }
    }
}
