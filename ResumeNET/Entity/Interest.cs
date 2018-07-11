using System.Text;

namespace ResumeNET.Entity
{
    /// <summary>
    /// The Interest class includes Interests information.
    /// </summary>

    public class Interest
        : BaseEntity
    {
        public string Name { get; set; }

        /// <summary>
        /// The Interest Constructor assings necessary properties
        /// </summary>
        
        public Interest(string Name)
        {
            this.Name = Name;
        }

        public Interest()
        {
        }

        /// <summary>
        /// The Write Method returns all Interests Information as a string.
        /// </summary>
        
        public override string Write()
        {
            StringBuilder sb = new StringBuilder("\nInterests ->");
            sb.Append("\n" + Name);
            sb.Append("\n");

            return sb.ToString();
        }
    }
}