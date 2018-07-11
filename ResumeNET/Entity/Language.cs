using ResumeNET.Type;
using System.Text;

namespace ResumeNET.Entity
{
    /// <summary>
    /// The Language class includes languages information.
    /// </summary>
    public class Language
        : BaseEntity
    {
        public string Name { get; set; }

        public LanguageLevel LanguageLevel { get; set; }

        /// <summary>
        /// The Language Constructor assings necessary properties
        /// </summary>
        
        public Language(string Name, LanguageLevel LanguageLevel)
        {
            this.Name = Name;
            this.LanguageLevel = LanguageLevel;
        }

        public Language()
        {
        }

        /// <summary>
        /// The Write Method returns all Languages Information as a string.
        /// </summary>
        
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