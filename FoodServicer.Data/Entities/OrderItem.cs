namespace FoodServicer.Data.Entities
{
    public class OrderItem
    {
        public long Id { get; set; }
        public string SpecialInstructions { get; set; }


        public long MenuItemId { get; set; }
        public MenuItem MenuItem { get; set; }


    }
}
