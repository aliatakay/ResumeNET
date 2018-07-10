using ResumeNET.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeNET.Entity
{
    public class Skill
        : BaseEntity
    {
        public string Name { get; set; }

        public SkillLevel SkillLevel { get; set; }

        public override void Show()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Skill Info");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Name = " + this.Name);
            Console.WriteLine("Level = " + this.SkillLevel);
        }

    }
}
