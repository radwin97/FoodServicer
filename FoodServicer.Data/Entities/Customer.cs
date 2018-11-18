using System.Collections.Generic;

namespace FoodServicer.Data.Entities
{
    public class Customer
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }

        public ICollection<EmailAddress> EmailAddresses { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<PhoneNumber> PhoneNumbers { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
