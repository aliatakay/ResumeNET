using ResumeNET.Data.Contracts.Entities;

namespace ResumeNET.Data.Contracts.Repositories
{
    public interface IWorkRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        ICollection<Work> List();
    }
}