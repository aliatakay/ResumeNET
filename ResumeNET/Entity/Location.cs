using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeNET.Entity
{
    public class Location
        : BaseEntity
    {
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }

        public override void Show()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Location Info");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Address = " + this.Address);
            Console.WriteLine("Postal Code = " + this.ZipCode);
            Console.WriteLine("City = " + this.City);
            Console.WriteLine("Country = " + this.Country);
            Console.WriteLine("Region = " + this.Region);
        }
        

    }

}
