using FoodServicer.Library.Interfaces;
using FoodServicer.Model;
using FoodServicer.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace FoodServicer.Library.Implementations.ViewModelBuilders
{
    public class CustomerTableViewModelBuilder : ICustomerTableViewModelBuilder
    {
        public List<CustomerTableViewModel> Build(List<CustomerModel> customers)
        {
            var viewModel = new List<CustomerTableViewModel>();

            if(customers != null && customers.Any())
            {
                //TODO: Refactor
                foreach(var customer in customers)
                {
                    string primaryAddress = null, 
                           primaryPhone = null, 
                           primaryEmail = null;

                    if (customer.Addresses != null && 
                        customer.Addresses.Count > 0 && 
                        customer.Addresses.Any(x => x.IsPrimary))
                    {
                        var address = customer.Addresses.First(x => x.IsPrimary);
                        primaryAddress = $"{address.Street1}, {address.Street2}, {address.City}, {address.State} {address.PostalCode}";
                    }

                    if (customer.EmailAddresses != null &&
                        customer.EmailAddresses.Count > 0 &&
                        customer.EmailAddresses.Any(x => x.IsPrimary))
                    {
                        var emailAddress = customer.EmailAddresses.First(x => x.IsPrimary);
                        primaryEmail = emailAddress.Address;
                    }

                    if (customer.PhoneNumbers != null &&
                        customer.PhoneNumbers.Count > 0 &&
                        customer.PhoneNumbers.Any(x => x.IsPrimary))
                    {
                        var phoneNumber = customer.PhoneNumbers.First(x => x.IsPrimary);
                        primaryPhone = phoneNumber.Number;
                    }

                    viewModel.Add(new CustomerTableViewModel
                    {
                        Id = customer.Id,
                        FirstName = customer.FirstName,
                        MiddleName = customer.MiddleName,
                        LastName = customer.LastName,
                        Suffix = customer.Suffix,
                        PrimaryAddress = primaryAddress,
                        PrimaryEmailAddress = primaryEmail,
                        PrimaryPhoneNumber = primaryPhone
                    });
                }
            }

            return viewModel;
        }
    }
}
