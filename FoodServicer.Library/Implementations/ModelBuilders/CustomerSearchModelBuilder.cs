using FoodServicer.Library.Interfaces;
using FoodServicer.Model;
using FoodServicer.ViewModel;

namespace FoodServicer.Library.Implementations.ModelBuilders
{
    public class CustomerSearchModelBuilder : ICustomerSearchModelBuilder
    {
        public CustomerSearchModel Build(CustomerSearchViewModel viewModel)
        {
            return new CustomerSearchModel
            {
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                EmailAddress = viewModel.EmailAddress,
                PhoneNumber = viewModel.PhoneNumber
            };
        }
    }
}
