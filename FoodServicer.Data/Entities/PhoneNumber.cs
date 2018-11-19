namespace FoodServicer.Data.Entities
{
    public class PhoneNumber
    {
        public long Id { get; set; }
        public bool IsPrimary { get; set; }
        public string Number { get; set; }

        public long PhoneNumberTypeId { get; set; }
        public PhoneNumberType Type { get; set; }

        public long CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
