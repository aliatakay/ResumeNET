using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeNET.Entity
{
    public class Education
        : BaseEntity
    {
        public string Institution { get; set; }
        public string Area { get; set; }
        public string StudyType { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public decimal Gno { get; set; }

        public override void Show()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Education Info");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Institution = " + this.Institution);
            Console.WriteLine("Area = " + this.Area);
            Console.WriteLine("Study Type = " + this.StudyType);
            Console.WriteLine("Start Date = " + this.StartDate);
            Console.WriteLine("End Date = " + this.EndDate);
            Console.WriteLine("Gno = " + this.Gno);
        }

    }
}
