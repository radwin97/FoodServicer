using System.Collections.Generic;

namespace FoodServicer.Data.Entities
{
    public class Order
    {
        public long Id { get; set; }
        public decimal Total { get; set; }

        public long StatusId { get; set; }
        public OrderStatus Status {get;set;}

        public long CustomerId { get; set; }
        public Customer Customer { get; set; }

        public long MenuId { get; set; }
        public Menu Menu { get; set; }

        public long DeliveryAddressId { get; set; }
        public Address DeliveryAddress { get; set; }

        public long? ContactPhoneId { get; set; }
        public PhoneNumber ContactPhone { get; set; }

        public long? ContactEmailId { get; set; }
        public EmailAddress ContactEmail { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
