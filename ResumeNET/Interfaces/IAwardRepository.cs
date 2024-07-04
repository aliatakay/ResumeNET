using ResumeNET.Entity;
using System.Collections.Generic;

namespace ResumeNET.Interfaces
{
    public interface IAwardRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        List<Award> List();
    }
}