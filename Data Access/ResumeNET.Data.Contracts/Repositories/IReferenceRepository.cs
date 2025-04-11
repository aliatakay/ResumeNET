﻿using ResumeNET.Data.Contracts.Entities;

namespace ResumeNET.Data.Contracts.Repositories
{
    public interface IReferenceRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        ICollection<Reference> List();
    }
}