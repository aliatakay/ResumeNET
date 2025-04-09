using System.Text;

namespace ResumeNET.Entity
{
    public class Publication
        : BaseEntity
    {
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string ReleaseDate { get; set; }
        public string Website { get; set; }

        public Publication(string Name, string Publisher)
        {
            this.Name = Name;
            this.Publisher = Publisher;
            this.ReleaseDate = string.Empty;
            this.Website = string.Empty;
        }
        
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