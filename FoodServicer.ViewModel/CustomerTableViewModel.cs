using System.Text;

namespace FoodServicer.ViewModel
{
    public class CustomerTableViewModel
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string PrimaryEmailAddress { get; set; }
        public string PrimaryAddress { get; set; }
        public string PrimaryPhoneNumber { get; set; }

        public string FullName
        {
            get
            {
                var sb = new StringBuilder();

                if (!string.IsNullOrEmpty(FirstName))
                {
                    sb.AppendFormat("{0} ", FirstName);
                }

                if (!string.IsNullOrEmpty(MiddleName))
                {
                    sb.AppendFormat("{0} ", MiddleName);
                }

                if (!string.IsNullOrEmpty(LastName))
                {
                    sb.AppendFormat("{0} ", LastName);
                }

                if (!string.IsNullOrEmpty(Suffix))
                {
                    sb.AppendFormat("{0} ", Suffix);
                }

                return sb.ToString().TrimEnd();
            }
        }
    }
}
