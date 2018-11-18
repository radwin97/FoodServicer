using System.Collections.Generic;

namespace FoodServicer.Model
{
    public class CustomerModel
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }

        public List<EmailAddressModel> EmailAddresses { get; set; }
        public List<AddressModel> Addresses { get; set; }
        public List<PhoneNumberModel> PhoneNumbers { get; set; }
        public List<OrderModel> Orders { get; set; }
    }

    public class EmailAddressModel
    {
        public long Id { get; set; }
        public string Address { get; set; }
        public bool IsPrimary { get; set; }
        public EmailAddressTypeModel Type { get; set; }
    }

    public class EmailAddressTypeModel
    {
        public long Id { get; set; }
        public string Type { get; set; }
    }

    public class AddressModel
    {
        public long Id { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public bool IsPrimary { get; set; }
        public AddressTypeModel Type { get; set; }
    }

    public class AddressTypeModel
    {
        public long Id { get; set; }
        public string Type { get; set; }
    }

    public class PhoneNumberModel
    {
        public long Id { get; set; }
        public bool IsPrimary { get; set; }
        public string Number { get; set; }
        public PhoneNumberTypeModel Type { get; set; }
    }

    public class PhoneNumberTypeModel
    {
        public long Id { get; set; }
        public string Type { get; set; }
    }

    public class OrderModel
    {
        public long Id { get; set; }
        public decimal Total { get; set; }
        public long CustomerId { get; set; }
        public long MenuId { get; set; }
        public long DeliveryAddressId { get; set; }
        public long? ContactPhoneId { get; set; }
        public long? ContactEmailId { get; set; }

        public OrderStatusModel OrderStatus { get; set; }
        public ICollection<OrderItemModel> OrderItems { get; set; }
    }

    public class OrderStatusModel
    {
        public long Id { get; set; }
        public string Status { get; set; }
    }

    public class OrderItemModel
    {
        public long Id { get; set; }
        public string SpecialInstructions { get; set; }
        public MenuItemModel MenuItem { get; set; }
    }

    public class MenuItemModel
    {
        public long Id { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Price { get; set; }
        public long MenuId { get; set; }
        public long MealId { get; set; }
    }
}
