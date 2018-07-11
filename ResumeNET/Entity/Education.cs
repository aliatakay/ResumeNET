using System;
using System.Text;

namespace ResumeNET.Entity
{
    /// <summary>
    /// The Education class includes Education Information.
    /// </summary>

    public class Education
        : BaseEntity
    {
        public string Institution { get; set; }
        public string Area { get; set; }
        public string StudyType { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public decimal Gno { get; set; }

        /// <summary>
        /// The Education Constructor assings necessary properties
        /// </summary>
        
        public Education(string Institution, string Area, string StudyType)
        {
            this.Institution = Institution;
            this.Area = Area;
            this.StudyType = StudyType;
            this.StartDate = String.Empty;
            this.EndDate = String.Empty;
            this.Gno = Decimal.Zero;
        }

        public Education()
        {
        }

        /// <summary>
        /// The Write Method returns all Education Information as a string.
        /// </summary>
        
        public override string Write()
        {
            StringBuilder sb = new StringBuilder("\nEducation ->");
            sb.Append("\n" + Institution);
            sb.Append("\n" + Area);
            sb.Append("\n" + StudyType);
            sb.Append("\n" + StartDate);
            sb.Append("\n" + EndDate);
            sb.Append("\n" + Gno);
            sb.Append("\n");

            return sb.ToString();
        }
    }
}