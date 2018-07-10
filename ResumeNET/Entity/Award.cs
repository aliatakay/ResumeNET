using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeNET.Entity
{
    public class Award
        : BaseEntity
    {
        public string Title { get; set; }
        public string Date { get; set; }
        public string Awarder { get; set; }
        public string Summary { get; set; }

        public override void Show()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Award Info");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Title = " + this.Title);
            Console.WriteLine("Date = " + this.Date);
            Console.WriteLine("Awarder = " + this.Awarder);
            Console.WriteLine("Summary = " + this.Summary);
        }
    }
}
