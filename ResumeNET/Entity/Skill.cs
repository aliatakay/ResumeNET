using ResumeNET.Type;
using System.Text;

namespace ResumeNET.Entity
{
    /// <summary>
    /// The Skill class includes skills information.
    /// </summary>

    public class Skill
        : BaseEntity
    {
        public string Name { get; set; }

        public SkillLevel SkillLevel { get; set; }

        /// <summary>
        /// The Skill Constructor assings necessary properties
        /// </summary>
        
        public Skill(string Name, SkillLevel SkillLevel)
        {
            this.Name = Name;
            this.SkillLevel = SkillLevel;
        }

        public Skill()
        {
        }

        /// <summary>
        /// The Write Method returns all Skills Information as a string.
        /// </summary>
        
        public override string Write()
        {
            StringBuilder sb = new StringBuilder("\nSkills ->");
            sb.Append("\n" + Name);
            sb.Append("\n" + SkillLevel);
            sb.Append("\n");

            return sb.ToString();
        }
    }
}