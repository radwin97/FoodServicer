using System.Collections.Generic;

namespace FoodServicer.Model
{
    public class ValidationResult
    {
        public ValidationResult()
        {
            Errors = new List<string>();
        }

        public bool IsValid { get { return Errors != null && Errors.Count == 0; } }
        public List<string> Errors { get; set; }
    }
}
