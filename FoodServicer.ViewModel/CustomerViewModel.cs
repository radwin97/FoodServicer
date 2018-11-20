using System.Collections.Generic;

namespace FoodServicer.ViewModel
{
    public class CustomerViewModel
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }

        public List<EmailAddressViewModel> EmailAddresses { get; set; }
        public List<AddressViewModel> Addresses { get; set; }
        public List<PhoneNumberViewModel> PhoneNumbers { get; set; }
        public List<OrderViewModel> Orders { get; set; }
    }
}
