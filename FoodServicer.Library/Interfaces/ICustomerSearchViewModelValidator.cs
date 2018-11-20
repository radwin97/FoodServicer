using FoodServicer.Model;
using FoodServicer.ViewModel;

namespace FoodServicer.Library.Interfaces
{
    public interface ICustomerSearchViewModelValidator
    {
        ValidationResult Validate(CustomerSearchViewModel viewModel);
    }
}
