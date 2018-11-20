namespace FoodServicer.ViewModel
{
    public class EmailAddressViewModel
    {
        public long Id { get; set; }
        public string Address { get; set; }
        public bool IsPrimary { get; set; }
        public EmailAddressTypeViewModel Type { get; set; }
    }
}
