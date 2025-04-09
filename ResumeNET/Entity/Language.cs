using ResumeNET.Type;
using System.Text;

namespace ResumeNET.Entity
{
    public class Language
        : BaseEntity
    {
        public string Name { get; set; }

        public LanguageLevel LanguageLevel { get; set; }
        
        public Language(string Name, LanguageLevel LanguageLevel)
        {
            this.Name = Name;
            this.LanguageLevel = LanguageLevel;
        }
        
        public override string Write()
        {
            StringBuilder sb = new StringBuilder("\nLanguages ->");
            sb.Append("\n" + Name);
            sb.Append("\n" + LanguageLevel);
            sb.Append("\n");

            return sb.ToString();
        }
    }
}