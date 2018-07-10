using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeNET.Entity
{
    public class Basic
        : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; }
        public string Summary { get; set; }

        public Location Location { get; set; }

        public Basic()
        {
            Location = new Location();
        }

        
        public override void Show()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Personal Info");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("First Name = " + this.FirstName);
            Console.WriteLine("Last Name = " + this.LastName);
            Console.WriteLine("Email Address = " + this.EmailAddress);
            Console.WriteLine("Phone Number = " + this.PhoneNumber);
            Console.WriteLine("Website = " + this.Website);
            Console.WriteLine("Summary = " + this.Summary);
            Location.Show();
        }

        //public bool Validate()
        //{
        //    var result = true;

        //    if (string.IsNullOrEmpty(this.FirstName)) result = false;
        //    if (string.IsNullOrEmpty(this.LastName)) result = false;
        //    if (string.IsNullOrEmpty(this.EmailAddress)) result = false;
        //    if (string.IsNullOrEmpty(this.PhoneNumber)) result = false;
        //    if (string.IsNullOrEmpty(this.Website)) result = false;
        //    if (string.IsNullOrEmpty(this.Summary)) result = false;

        //    return result;
        //}
    }
}
