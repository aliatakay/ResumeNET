using ResumeNET.Data.Contracts.Entities;

namespace ResumeNET.Data.Contracts.Repositories
{
    public interface IBasicRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        ICollection<Basic> List();
    }
}