using ResumeNET.Data.Contracts.Entities;

namespace ResumeNET.Data.Contracts.Repositories
{
    public interface ISkillRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        ICollection<Skill> List();
    }
}