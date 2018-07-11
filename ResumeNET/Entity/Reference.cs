using System.Text;

namespace ResumeNET.Entity
{
    /// <summary>
    /// The Reference class includes references information.
    /// </summary>

    public class Reference
        : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The Reference Constructor assings necessary properties
        /// </summary>
        
        public Reference(string FirstName, string LastName, string PhoneNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
        }

        public Reference()
        {
        }

        /// <summary>
        /// The Write Method returns all References Information as a string.
        /// </summary>
        
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