using System.Collections.Generic;

namespace FoodServicer.Data.Entities
{
    public class Meal
    {
        public long Id { get; set; }
        public string ReheatInstructions { get; set; }
        
        ICollection<MealComponent> Components { get; set; }
    }
}
