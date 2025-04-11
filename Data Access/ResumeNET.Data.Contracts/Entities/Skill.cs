using ResumeNET.Data.Contracts.Types;
using System.Text;

namespace ResumeNET.Data.Contracts.Entities
{
    public class Skill : BaseEntity
    {
        public string Name { get; set; }

        public SkillLevelType SkillLevel { get; set; }
        
        public Skill(string Name, SkillLevelType SkillLevel)
        {
            this.Name = Name;
            this.SkillLevel = SkillLevel;
        }
        
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