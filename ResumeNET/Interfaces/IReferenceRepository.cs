using ResumeNET.Entity;
using System.Collections.Generic;

namespace ResumeNET.Repository
{
    public interface IReferenceRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        List<Reference> List();
    }
}