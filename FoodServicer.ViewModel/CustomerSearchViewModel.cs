using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace FoodServicer.ViewModel
{
    public class CustomerSearchViewModel
    {
        [DisplayName("First Name")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [DisplayName("Email Address")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [DisplayName("Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public List<CustomerTableViewModel> Customers { get; set; }
        public bool HasCustomers { get { return Customers != null && Customers.Any(); } }
    }
}
