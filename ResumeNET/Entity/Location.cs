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
        
        public Location(string Address, int ZipCode, string City, string Country, string Region)
        {
            this.Address = Address;
            this.ZipCode = ZipCode;
            this.City = City;
            this.Country = Country;
            this.Region = Region;
        }
        
        public override string Write()
        {
            StringBuilder sb = new StringBuilder("\nLocation ->");
            sb.Append("\n" + Address);
            sb.Append("\n" + ZipCode);
            sb.Append("\n" + City);
            sb.Append("\n" + Country);
            sb.Append("\n" + Region);
            sb.Append("\n");

            return sb.ToString();
        }
    }
}