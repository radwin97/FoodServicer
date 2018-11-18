using System;
using System.Collections.Generic;

namespace FoodServicer.Data.Entities
{
    public class Menu
    {
        public long Id { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        ICollection<MenuItem> MenuItems { get; set; }
    }
}
