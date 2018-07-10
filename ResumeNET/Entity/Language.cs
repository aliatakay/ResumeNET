using ResumeNET.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeNET.Entity
{
    public class Language
        : BaseEntity
    {
        public string Name { get; set; }

        public LanguageLevel LanguageLevel { get; set; }

        public override void Show()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Language Info");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Name = " + this.Name);
            Console.WriteLine("Level = " + this.LanguageLevel);
        }
    }
}
