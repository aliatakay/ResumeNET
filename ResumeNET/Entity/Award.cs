using System.Text;

namespace ResumeNET.Entity
{
    public class Award : BaseEntity
    {
        public string Title { get; set; }
        public string Date { get; set; }
        public string Awarder { get; set; }
        public string Summary { get; set; }
        
        public Award(string title, string date, string awarder, string summary)
        {
            this.Title = title;
            this.Date = date;
            this.Awarder = awarder;
            this.Summary = summary;
        }
        
        public override string Write()
        {
            var sb = new StringBuilder("\nAwards ->");
            
            sb.Append("\n" + Title);
            sb.Append("\n" + Date);
            sb.Append("\n" + Awarder);
            sb.Append("\n" + Summary);
            sb.Append("\n");

            return sb.ToString();
        }
    }
}