namespace FoodServicer.Data.Entities
{
    public class MenuItem
    {
        public long Id { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Price { get; set; }

        public long MenuId { get; set; }
        public Menu Menu { get; set; }

        public long MealId { get; set; }
        public Meal Meal { get; set; }
    }
}
