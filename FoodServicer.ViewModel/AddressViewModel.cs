namespace FoodServicer.ViewModel
{
    public class AddressViewModel
    {
        public long Id { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public bool IsPrimary { get; set; }
        public AddressTypeViewModel Type { get; set; }
    }
}
