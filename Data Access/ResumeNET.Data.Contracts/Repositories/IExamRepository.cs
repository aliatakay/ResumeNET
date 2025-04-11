using ResumeNET.Data.Contracts.Entities;

namespace ResumeNET.Data.Contracts.Repositories
{
    public interface IExamRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        ICollection<Exam> List();
    }
}