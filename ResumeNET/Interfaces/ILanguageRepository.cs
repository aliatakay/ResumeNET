using ResumeNET.Entity;
using System.Collections.Generic;

namespace ResumeNET.Repository
{
    public interface ILanguageRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        List<Language> List();
    }
}