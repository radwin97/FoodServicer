﻿namespace FoodServicer.ViewModel
{
    public class MenuItemViewModel
    {
        public long Id { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Price { get; set; }
        public long MenuId { get; set; }
        public long MealId { get; set; }
    }
}
