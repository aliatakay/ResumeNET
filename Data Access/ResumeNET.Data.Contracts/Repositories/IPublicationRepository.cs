using ResumeNET.Data.Contracts.Entities;

namespace ResumeNET.Data.Contracts.Repositories
{
    public interface IPublicationRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        ICollection<Publication> List();
    }
}