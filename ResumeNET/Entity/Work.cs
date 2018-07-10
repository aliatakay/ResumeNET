using ResumeNET.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeNET.Entity
{
    public class Work
        : BaseEntity
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Website { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public WorkState WorkState { get; set; }

        public override void Show()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Work Info");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Name = " + this.Name);
            Console.WriteLine("Position = " + this.Position);
            Console.WriteLine("Website = " + this.Website);
            Console.WriteLine("Start Date = " + this.StartDate);
            Console.WriteLine("End Date = " + this.EndDate);
        }
    }
}
