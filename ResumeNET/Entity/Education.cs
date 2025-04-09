using System.Text;

namespace ResumeNET.Entity
{
    public class Education
        : BaseEntity
    {
        public string Institution { get; set; }
        public string Area { get; set; }
        public string StudyType { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public decimal Gno { get; set; }

        public Education(string institution, string area, string studyType)
        {
            this.Institution = institution;
            this.Area = area;
            this.StudyType = studyType;
            this.StartDate = string.Empty;
            this.EndDate = string.Empty;
            this.Gno = decimal.Zero;
        }

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