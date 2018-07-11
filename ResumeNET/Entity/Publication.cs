using System;
using System.Text;

namespace ResumeNET.Entity
{
    /// <summary>
    /// The Publicaton class includes publications information.
    /// </summary>

    public class Publication
        : BaseEntity
    {
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string ReleaseDate { get; set; }
        public string Website { get; set; }

        /// <summary>
        /// The Publication Constructor assings necessary properties
        /// </summary>
        
        public Publication(string Name, string Publisher)
        {
            this.Name = Name;
            this.Publisher = Publisher;
            this.ReleaseDate = String.Empty;
            this.Website = String.Empty;
        }

        public Publication()
        {
        }

        /// <summary>
        /// The Write Method returns all Publication Information as a string.
        /// </summary>
        
        public override string Write()
        {
            StringBuilder sb = new StringBuilder("\nPublications ->");
            sb.Append("\n" + Name);
            sb.Append("\n" + Publisher);
            sb.Append("\n" + ReleaseDate);
            sb.Append("\n" + Website);
            sb.Append("\n");

            return sb.ToString();
        }
    }
}