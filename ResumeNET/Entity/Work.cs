using ResumeNET.Type;
using System.Text;

namespace ResumeNET.Entity
{
    public class Work
        : BaseEntity
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Website { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public WorkState WorkState { get; set; }
        
        public Work(WorkState WorkState, string Name, string Position)
        {
            this.WorkState = WorkState;
            this.Name = Name;
            this.Position = Position;
            this.Website = string.Empty;
            this.StartDate = string.Empty;
            this.EndDate = string.Empty;
        }
        
        public override string Write()
        {
            StringBuilder sb = new StringBuilder("\nWorks ->");
            sb.Append("\n" + WorkState);
            sb.Append("\n" + Name);
            sb.Append("\n" + Position);
            sb.Append("\n" + Website);
            sb.Append("\n" + StartDate);
            sb.Append("\n" + EndDate);
            sb.Append("\n");

            return sb.ToString();
        }
    }
}