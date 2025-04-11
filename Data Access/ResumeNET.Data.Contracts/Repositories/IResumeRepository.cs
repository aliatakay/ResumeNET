using ResumeNET.Data.Contracts.Entities;

namespace ResumeNET.Data.Contracts.Repositories
{
    public interface IResumeRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        ICollection<Resume> List();
    }
}