using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeNET
{
    public interface IEntity
    {
        
    }

    public abstract class BaseEntity
        : IEntity
    {
        public abstract void Show();
    }
}
