using APIServiceM.IServices;
using Entities.Entities;
using Logic.ILogic;

namespace APIServiceM.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderLogic _orderLogic;
        public OrderService(IOrderLogic orderLogic)
        {
            _orderLogic = orderLogic;
        }
        public int InsertOrder(OrderItem orderItem)
        {
            _orderLogic.InsertOrderItem(orderItem);
            return orderItem.Id;
        }
    }
}
