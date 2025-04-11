using System.Text;

namespace ResumeNET.Data.Contracts.Entities
{
    public class Basic : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; }
        public string Summary { get; set; }

        public Location Location { get; set; }

        public Basic(Location location, string firstName, string lastName, string emailAddress) : this(location)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmailAddress = emailAddress;
            this.PhoneNumber = string.Empty;
            this.Website = string.Empty;
            this.Summary = string.Empty;
        }

        public Basic(Location location)
        {
            this.Location = location;
        }

        public override string Write()
        {
            var sb = new StringBuilder("\nPersonal Information ->");

            sb.Append("\n" + FirstName);
            sb.Append("\n" + LastName);
            sb.Append("\n" + EmailAddress);
            sb.Append("\n" + PhoneNumber);
            sb.Append("\n" + Website);
            sb.Append("\n" + Summary);
            sb.Append("\n");

            var locationString = Location.Write();

            sb.Append(locationString);

            return sb.ToString();
        }
    }
}