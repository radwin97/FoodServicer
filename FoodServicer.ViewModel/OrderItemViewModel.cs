namespace FoodServicer.ViewModel
{
    public class OrderItemViewModel
    {
        public long Id { get; set; }
        public string SpecialInstructions { get; set; }
        public MenuItemViewModel MenuItem { get; set; }
    }
}
