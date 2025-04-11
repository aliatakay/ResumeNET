using ResumeNET.Data.Contracts.Entities;

namespace ResumeNET.Data.Contracts.Repositories
{
    public interface ILocationRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        ICollection<Location> List();
    }
}