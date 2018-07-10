using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeNET.Entity
{
    public class Interest
        : BaseEntity
    {
        public string Name { get; set; }

        public override void Show()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Interest Info");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Name = " + this.Name);
        }

    }
}
