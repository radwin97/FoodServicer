namespace FoodServicer.Data.Entities
{
    public class MealComponent
    {
        public long Id { get; set; }
        public int Quantity { get; set; }

        public long IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }

        public long MeasurementId { get; set; }
        public Measurement Measurement { get; set; }
    }
}
