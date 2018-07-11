using ResumeNET.Entity;
using System;
using System.Collections.Generic;
using System.Text;

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
