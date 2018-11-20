using System.Collections.Generic;
using FoodServicer.Model;

namespace FoodServicer.Library.Interfaces
{
    public interface ICustomerSearchProcessor
    {
        List<CustomerModel> Process(CustomerSearchModel model);
    }
}
