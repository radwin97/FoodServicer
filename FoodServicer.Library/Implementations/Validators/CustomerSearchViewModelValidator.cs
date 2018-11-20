using FoodServicer.Library.Interfaces;
using FoodServicer.Model;
using FoodServicer.ViewModel;

namespace FoodServicer.Library.Implementations.Validators
{
    public class CustomerSearchViewModelValidator : ICustomerSearchViewModelValidator
    {
        public ValidationResult Validate(CustomerSearchViewModel viewModel)
        {
            return new ValidationResult();
        }
    }
}
