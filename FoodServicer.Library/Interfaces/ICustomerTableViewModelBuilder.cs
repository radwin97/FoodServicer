using FoodServicer.Model;
using FoodServicer.ViewModel;
using System.Collections.Generic;

namespace FoodServicer.Library.Interfaces
{
    public interface ICustomerTableViewModelBuilder
    {
        List<CustomerTableViewModel> Build(List<CustomerModel> customers);
    }
}
