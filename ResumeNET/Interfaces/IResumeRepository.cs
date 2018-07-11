using ResumeNET.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeNET.Repository
{
    public interface IResumeRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        List<Resume> List();
    }
}
