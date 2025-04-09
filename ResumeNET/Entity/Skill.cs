using ResumeNET.Type;
using System.Text;

namespace ResumeNET.Entity
{
    public class Skill
        : BaseEntity
    {
        public string Name { get; set; }

        public SkillLevel SkillLevel { get; set; }
        
        public Skill(string Name, SkillLevel SkillLevel)
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