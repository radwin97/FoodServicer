using FoodServicer.Model;
using System.Collections.Generic;

namespace FoodServicer.Repository.Interfaces
{
    public interface IOrderRepository
    {
        long Add(OrderModel model);
        OrderModel Get(long id);
        List<OrderModel> Search(long? menuId = null, long? customerId = null, long? deliveryAddressId = null, long? contactEmailId = null, long? contactPhoneId = null, long? stausId = null);
        bool Update(OrderModel model);
    }
}
