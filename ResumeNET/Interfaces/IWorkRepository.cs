using ResumeNET.Entity;
using System.Collections.Generic;

namespace ResumeNET.Repository
{
    public interface IWorkRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        List<Work> List();
    }
}