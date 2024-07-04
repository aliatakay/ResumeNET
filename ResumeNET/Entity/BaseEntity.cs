using ResumeNET.Type;

namespace ResumeNET.Entity
{
    public interface IEntity
    {

    }

    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }

        public ActivePassive ActivePassive { get; set; }

        public abstract string Write();
    }
}