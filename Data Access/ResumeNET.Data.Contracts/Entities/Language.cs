using ResumeNET.Data.Contracts.Types;
using System.Text;

namespace ResumeNET.Data.Contracts.Entities
{
    public class Language : BaseEntity
    {
        public string Name { get; set; }

        public LanguageLevelType LanguageLevel { get; set; }
        
        public Language(string Name, LanguageLevelType LanguageLevel)
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