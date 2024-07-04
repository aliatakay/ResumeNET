using ResumeNET.Entity;
using System.Collections.Generic;

namespace ResumeNET.Repository
{
    public interface IPublicationRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        List<Publication> List();
    }
}