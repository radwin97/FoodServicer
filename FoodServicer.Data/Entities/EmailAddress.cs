namespace FoodServicer.Data.Entities
{
    public class EmailAddress
    {
        public long Id { get; set; }
        public string Address { get; set; }
        public bool IsPrimary { get; set; }

        public long EmailAddressTypeId { get; set; }
        public EmailAddressType Type { get; set; }

        public long CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
