using FoodServicer.Model;
using FoodServicer.ViewModel;

namespace FoodServicer.Library.Interfaces
{
    public interface ICustomerSearchModelBuilder
    {
        CustomerSearchModel Build(CustomerSearchViewModel viewModel);
    }
}
