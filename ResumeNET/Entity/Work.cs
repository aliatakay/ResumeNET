using ResumeNET.Type;
using System;
using System.Text;

namespace ResumeNET.Entity
{
    /// <summary>
    /// The Work class includes works information.
    /// </summary>

    public class Work
        : BaseEntity
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Website { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public WorkState WorkState { get; set; }

        /// <summary>
        /// The Work Constructor assings necessary properties
        /// </summary>
        
        public Work(WorkState WorkState, string Name, string Position)
        {
            this.WorkState = WorkState;
            this.Name = Name;
            this.Position = Position;
            this.Website = String.Empty;
            this.StartDate = String.Empty;
            this.EndDate = String.Empty;
        }

        public Work()
        {
        }

        /// <summary>
        /// The Write Method returns all Works Information as a string.
        /// </summary>
        
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