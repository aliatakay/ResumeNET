using ResumeNET.Entity;
using System.Collections.Generic;

namespace ResumeNET.Repository
{
    public interface IInterestRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        List<Interest> List();
    }
}