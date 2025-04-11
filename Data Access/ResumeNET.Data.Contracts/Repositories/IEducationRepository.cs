using ResumeNET.Data.Contracts.Entities;

namespace ResumeNET.Data.Contracts.Repositories
{
    public interface IEducationRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        ICollection<Education> List();
    }
}