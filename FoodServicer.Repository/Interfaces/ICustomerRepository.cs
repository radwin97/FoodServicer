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
    }

    interface IMenuRepository
    {
    }

    interface IMealRepository
    {
    }
}
