using System.Collections.Generic;

namespace FoodServicer.ViewModel
{
    public class OrderViewModel
    {
        public long Id { get; set; }
        public decimal Total { get; set; }
        public long CustomerId { get; set; }
        public long MenuId { get; set; }
        public long DeliveryAddressId { get; set; }
        public long? ContactPhoneId { get; set; }
        public long? ContactEmailId { get; set; }

        public OrderStatusViewModel Status { get; set; }
        public List<OrderItemViewModel> OrderItems { get; set; }
    }
}
