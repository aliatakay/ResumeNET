using ResumeNET.Data.Contracts.Entities;

namespace ResumeNET.Data.Contracts.Repositories
{
    public interface IAwardRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        ICollection<Award> List();
    }
}