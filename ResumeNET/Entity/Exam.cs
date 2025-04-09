using System.Text;

namespace ResumeNET.Entity
{
    public class Exam
        : BaseEntity
    {
        public string Name { get; set; }
        public decimal Score { get; set; }
        public string Date { get; set; }
        
        public Exam(string name, decimal score, string date)
        {
            this.Name = name;
            this.Score = score;
            this.Date = date;
        }
        
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