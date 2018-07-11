using System.Text;

namespace ResumeNET.Entity
{
    /// <summary>
    /// The Award class includes Awards Information.
    /// </summary>

    public class Award
        : BaseEntity
    {
        public string Title { get; set; }
        public string Date { get; set; }
        public string Awarder { get; set; }
        public string Summary { get; set; }

        /// <summary>
        /// The Award Constructor assings necessary properties
        /// </summary>
        
        public Award(string Title, string Date, string Awarder, string Summary)
        {
            this.Title = Title;
            this.Date = Date;
            this.Awarder = Awarder;
            this.Summary = Summary;
        }

        public Award()
        {
        }

        /// <summary>
        /// The Write Method returns all Awards Information as a string.
        /// </summary>
        
        public override string Write()
        {
            StringBuilder sb = new StringBuilder("\nAwards ->");
            sb.Append("\n" + Title);
            sb.Append("\n" + Date);
            sb.Append("\n" + Awarder);
            sb.Append("\n" + Summary);
            sb.Append("\n");

            return sb.ToString();
        }
    }
}