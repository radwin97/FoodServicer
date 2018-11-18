namespace FoodServicer.Data.Entities
{
    public class Conversion
    {
        public long Id { get; set; }

        public long FromId { get; set; }
        public Measurement From { get; set; }

        public long ToId { get; set; }
        public Measurement To { get; set; }

        public decimal Value { get; set; }
    }
}
