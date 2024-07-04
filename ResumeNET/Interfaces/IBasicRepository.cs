using ResumeNET.Entity;
using System.Collections.Generic;

namespace ResumeNET.Repository
{
    public interface IBasicRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        List<Basic> List();
    }
}