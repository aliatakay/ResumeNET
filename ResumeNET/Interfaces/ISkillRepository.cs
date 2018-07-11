using ResumeNET.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeNET.Repository
{
    public interface ISkillRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        List<Skill> List();
    }
}
