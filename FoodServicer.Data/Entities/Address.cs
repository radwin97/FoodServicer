namespace FoodServicer.Data.Entities
{
    public class Address
    {
        public long Id { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public bool IsPrimary { get; set; }

        public long AddressTypeId { get; set; }
        public AddressType Type { get; set; }

        public long CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
