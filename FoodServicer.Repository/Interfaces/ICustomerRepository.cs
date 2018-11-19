using FoodServicer.Model;
using System.Collections.Generic;

namespace FoodServicer.Repository.Interfaces
{
    interface ICustomerRepository
    {
        List<CustomerModel> Search(string firstName, string middleName, string lastName, string suffix);
        CustomerModel Get(long id);
        long Add(CustomerModel model);
        bool Update(CustomerModel model);
    }

    interface IOrderRepository
    {
        long Add(OrderModel model);
        OrderModel Get(long id);
        List<OrderModel> Search(long? menuId = null, long? customerId = null, long? deliveryAddressId = null, long? contactEmailId = null, long? contactPhoneId = null, long? stausId = null);
        bool Update(OrderModel model);
    }

    interface IMenuRepository
    {
    }

    interface IMealRepository
    {
    }
}
