using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeNET.Entity
{
    public class Resume
        :BaseEntity
    {
        public Basic Basic { get; set; }

        public List<Education> Educations { get; set; }
        public List<Work> Works { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Language> Languages { get; set; }
        public List<Publication> Publications { get; set; }
        public List<Award> Awards { get; set; }
        public List<Exam> Exams { get; set; }
        public List<Reference> References { get; set; }

        public Resume()
        {
            Educations = new List<Education>();
            Works = new List<Work>();
            Skills = new List<Skill>();
            Languages = new List<Language>();
            Publications = new List<Publication>();
            Awards = new List<Award>();
            Exams = new List<Exam>();
            References = new List<Reference>();
        }

        public override void Show()
        {
            Basic.Show();
        }
    }
}
