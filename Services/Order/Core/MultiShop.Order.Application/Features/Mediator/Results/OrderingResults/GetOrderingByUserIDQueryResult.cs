namespace MultiShop.Order.Application.Features.Mediator.Results.OrderingResults
{
    public class GetOrderingByUserIDQueryResult
    {
        public int OrderingID { get; set; }
        public string UserID { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
