using FoodServicer.Library.Interfaces;
using FoodServicer.Model;
using FoodServicer.Repository.Interfaces;
using System.Collections.Generic;

namespace FoodServicer.Library.Implementations.Processors
{
    public class CustomerSearchProcessor : ICustomerSearchProcessor
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerSearchProcessor(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public List<CustomerModel> Process(CustomerSearchModel model)
        {
            return _customerRepository.Search(model.FirstName, null, model.LastName, null);
        }
    }
}
