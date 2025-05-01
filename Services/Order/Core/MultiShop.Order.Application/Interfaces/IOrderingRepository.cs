using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Application.Interfaces
{
    public interface IOrderingRepository
    {
        public List<Ordering> GetOrderingByUserID(string id);
    }
}
