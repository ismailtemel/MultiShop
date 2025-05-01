namespace MultiShop.Order.Application.Features.CQRS.Queries.AddressQueries
{
    public class GetAddressByIDQuery
    {
        public int ID { get; set; }

        public GetAddressByIDQuery(int id)
        {
            ID = id;
        }
    }
}
