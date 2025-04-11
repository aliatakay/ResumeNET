using System.Text;

namespace ResumeNET.Data.Contracts.Entities
{
    public class Interest : BaseEntity
    {
        public string Name { get; set; }
        
        public Interest(string Name)
        {
            this.Name = Name;
        }
        
        public override string Write()
        {
            StringBuilder sb = new StringBuilder("\nInterests ->");
            sb.Append("\n" + Name);
            sb.Append("\n");

            return sb.ToString();
        }
    }
}