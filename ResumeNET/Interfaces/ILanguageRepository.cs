using ResumeNET.Entity;
using System;
using System.Collections.Generic;
using System.Text;

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
