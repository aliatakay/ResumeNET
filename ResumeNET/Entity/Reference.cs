using System.Text;

namespace ResumeNET.Entity
{
    public class Reference
        : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        
        public Reference(string FirstName, string LastName, string PhoneNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
        }
        
        public override string Write()
        {
            StringBuilder sb = new StringBuilder("\nReferences ->");
            sb.Append("\n" + FirstName);
            sb.Append("\n" + LastName);
            sb.Append("\n" + PhoneNumber);
            sb.Append("\n");

            return sb.ToString();
        }
    }
}