using ResumeNET.Entity;
using System.Collections.Generic;

namespace ResumeNET.Repository
{
    public interface IExamRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        List<Exam> List();
    }
}