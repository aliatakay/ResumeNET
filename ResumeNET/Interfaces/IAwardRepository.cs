using ResumeNET.Entity;
using System;
using System.Collections.Generic;
using System.Text;

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
