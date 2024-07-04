using ResumeNET.Entity;
using System.Collections.Generic;

namespace ResumeNET.Repository
{
    public interface ILocationRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        List<Location> List();
    }
}