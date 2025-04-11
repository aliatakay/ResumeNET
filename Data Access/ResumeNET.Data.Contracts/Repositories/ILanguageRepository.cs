using ResumeNET.Data.Contracts.Entities;

namespace ResumeNET.Data.Contracts.Repositories
{
    public interface ILanguageRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        ICollection<Language> List();
    }
}