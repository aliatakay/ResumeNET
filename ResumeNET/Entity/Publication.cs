using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeNET.Entity
{
    public class Publication
        : BaseEntity
    {
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string ReleaseDate { get; set; }
        public string Website { get; set; }

        public override void Show()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Publication Info");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Name = " + this.Name);
            Console.WriteLine("Publisher = " + this.Publisher);
            Console.WriteLine("Release Date = " + this.ReleaseDate);
            Console.WriteLine("Website = " + this.Website);
        }
        
    }
}
