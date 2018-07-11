using System.Text;

namespace ResumeNET.Entity
{
    /// <summary>
    /// The Exam class includes Exams Information.
    /// </summary>

    public class Exam
        : BaseEntity
    {
        public string Name { get; set; }
        public decimal Score { get; set; }
        public string Date { get; set; }

        /// <summary>
        /// The Exam Constructor assings necessary properties
        /// </summary>
        
        public Exam(string Name, decimal Score, string Date)
        {
            this.Name = Name;
            this.Score = Score;
            this.Date = Date;
        }

        public Exam()
        {
        }

        /// <summary>
        /// The Write Method returns all Exams Information as a string.
        /// </summary>
        
        public override string Write()
        {
            StringBuilder sb = new StringBuilder("\nExams ->");
            sb.Append("\n" + Name);
            sb.Append("\n" + Score);
            sb.Append("\n" + Date);
            sb.Append("\n");

            return sb.ToString();
        }
    }
}