using ResumeNET.Entity;
using System.Collections.Generic;

namespace ResumeNET.Repository
{
    public interface IResumeRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        List<Resume> List();
    }
}