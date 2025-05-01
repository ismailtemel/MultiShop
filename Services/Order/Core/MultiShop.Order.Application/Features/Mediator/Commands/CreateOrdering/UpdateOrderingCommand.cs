using MediatR;

namespace MultiShop.Order.Application.Features.Mediator.Commands.CreateOrdering
{
    public class UpdateOrderingCommand : IRequest
    {
        public int OrderingID { get; set; }
        public string UserID { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
