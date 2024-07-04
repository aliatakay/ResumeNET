using ResumeNET.Entity;
using System.Collections.Generic;

namespace ResumeNET.Repository
{
    public interface IEducationRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        List<Education> List();
    }
}