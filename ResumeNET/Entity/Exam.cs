using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeNET.Entity
{
    public class Exam
        : BaseEntity
    {
        public string Name { get; set; }
        public decimal Score { get; set; }
        public string Date { get; set; }

        public override void Show()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Exam Info");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Name = " + this.Name);
            Console.WriteLine("Score = " + this.Score);
            Console.WriteLine("Date = " + this.Date);
        }

    }
}
