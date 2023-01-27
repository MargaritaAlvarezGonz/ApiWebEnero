using Entities.Entities;

namespace APIServiceM.IServices
{
    public interface IOrderService
    {
        int InsertOrder(OrderItem orderItem);
    }
}
