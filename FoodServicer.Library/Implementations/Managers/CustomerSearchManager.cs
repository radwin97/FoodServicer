using FoodServicer.Library.Implementations.Validators;
using FoodServicer.Library.Interfaces;
using FoodServicer.ViewModel;

namespace FoodServicer.Library.Implementations.Managers
{
    public class CustomerSearchManager : ICustomerSearchManager
    {
        private readonly ICustomerSearchProcessor _customerSearchProcessor;
        private readonly ICustomerSearchViewModelValidator _customerSearchValidator;
        private readonly ICustomerSearchModelBuilder _customerSearchModelBuilder;
        private readonly ICustomerTableViewModelBuilder _customerTableViewModelBuilder;

        public CustomerSearchManager(
            ICustomerSearchProcessor customerSearchProcessor,
            ICustomerSearchViewModelValidator customerSearchValidator, 
            ICustomerSearchModelBuilder customerSearchModelBuilder, 
            ICustomerTableViewModelBuilder customerTableViewModelBuilder)
        {
            _customerSearchProcessor = customerSearchProcessor;
            _customerSearchValidator = customerSearchValidator;
            _customerSearchModelBuilder = customerSearchModelBuilder;
            _customerTableViewModelBuilder = customerTableViewModelBuilder;
        }

        public void Manage(CustomerSearchViewModel viewModel)
        {
            var validationResult = _customerSearchValidator.Validate(viewModel);

            if (validationResult.IsValid)
            {
                var model = _customerSearchModelBuilder.Build(viewModel);
                var customers = _customerSearchProcessor.Process(model);
                viewModel.Customers = _customerTableViewModelBuilder.Build(customers);
            }
        }
    }
}
