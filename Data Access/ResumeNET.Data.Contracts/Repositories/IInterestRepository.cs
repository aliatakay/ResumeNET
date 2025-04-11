using ResumeNET.Data.Contracts.Entities;

namespace ResumeNET.Data.Contracts.Repositories
{
    public interface IInterestRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        ICollection<Interest> List();
    }
}