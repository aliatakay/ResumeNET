using ResumeNET.Entity;
using System;
using System.Collections.Generic;
using System.Text;

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
