using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeNET.Entity
{
    public class Reference
        : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public override void Show()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Reference Info");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("First Name = " + this.FirstName);
            Console.WriteLine("Last Name = " + this.LastName);
            Console.WriteLine("Phone Number = " + this.PhoneNumber);
        }
        
    }
}
