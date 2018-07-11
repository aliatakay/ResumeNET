using System;
using System.Text;

namespace ResumeNET.Entity
{
    /// <summary>
    /// The Basic class includes personal information.
    /// </summary>

    public class Basic
        : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; }
        public string Summary { get; set; }

        public Location Location { get; set; }

        /// <summary>
        /// The Basic Constructor assings necessary properties
        /// </summary>

        public Basic(Location location, string FirstName, string LastName, string EmailAddress)
            : this(location)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.EmailAddress = EmailAddress;
            this.PhoneNumber = String.Empty;
            this.Website = String.Empty;
            this.Summary = String.Empty;
        }

        public Basic(Location location)
        {
            this.Location = location;
        }

        /// <summary>
        /// The Write Method returns all Personal Information as a string.
        /// </summary>

        public override string Write()
        {
            StringBuilder sb = new StringBuilder("\nPersonal Information ->");

            sb.Append("\n" + FirstName);
            sb.Append("\n" + LastName);
            sb.Append("\n" + EmailAddress);
            sb.Append("\n" + PhoneNumber);
            sb.Append("\n" + Website);
            sb.Append("\n" + Summary);
            sb.Append("\n");

            string locationString = Location.Write();
            sb.Append(locationString);

            return sb.ToString();
        }
    }
}