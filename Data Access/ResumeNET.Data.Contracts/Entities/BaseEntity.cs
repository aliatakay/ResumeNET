using ResumeNET.Data.Contracts.Types;

namespace ResumeNET.Data.Contracts.Entities
{
    public interface IEntity
    {

    }

    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }

        public StatusType StatusType { get; set; }

        public abstract string Write();
    }
}