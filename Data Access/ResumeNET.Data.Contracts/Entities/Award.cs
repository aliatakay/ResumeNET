using System.Text;

namespace ResumeNET.Data.Contracts.Entities
{
    public class Award : BaseEntity
    {
        public string Title { get; set; }
        public string Date { get; set; }
        public string Awarder { get; set; }
        public string Summary { get; set; }
        
        public Award(string title, string date, string awarder, string summary)
        {
            Title = title;
            Date = date;
            Awarder = awarder;
            Summary = summary;
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