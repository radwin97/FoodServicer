namespace FoodServicer.ViewModel
{
    public class PhoneNumberViewModel
    {
        public long Id { get; set; }
        public bool IsPrimary { get; set; }
        public string Number { get; set; }
        public PhoneNumberTypeViewModel Type { get; set; }
    }
}
