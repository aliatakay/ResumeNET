using ResumeNET.Entity;
using System.Collections.Generic;

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