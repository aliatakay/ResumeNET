using System.Collections.Generic;
using System.Text;

namespace ResumeNET.Entity
{
    /// <summary>
    /// The Resume class includes lists of all information.
    /// </summary>

    public class Resume
        : BaseEntity
    {
        public Basic Basic { get; set; }

        public List<Education> Educations { get; set; }
        public List<Work> Works { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Language> Languages { get; set; }
        public List<Publication> Publications { get; set; }
        public List<Award> Awards { get; set; }
        public List<Exam> Exams { get; set; }
        public List<Interest> Interests { get; set; }
        public List<Reference> References { get; set; }

        /// <summary>
        /// The Resume Constructor assings necessary new lists
        /// </summary>
        
        public Resume()
        {
            Educations = new List<Education>();
            Works = new List<Work>();
            Skills = new List<Skill>();
            Languages = new List<Language>();
            Publications = new List<Publication>();
            Awards = new List<Award>();
            Exams = new List<Exam>();
            Interests = new List<Interest>();
            References = new List<Reference>();
        }


        /// <summary>
        /// The Write Method returns all the other strings as a string.
        /// </summary>
        
        public override string Write()
        {
            StringBuilder sb = new StringBuilder("\nRESUME\n");
            sb.Append(Basic.Write());

            foreach (var education in this.Educations)
            {
                sb.Append(education.Write());
            }

            foreach (var work in this.Works)
            {
                sb.Append(work.Write());
            }

            foreach (var skill in this.Skills)
            {
                sb.Append(skill.Write());
            }

            foreach (var language in this.Languages)
            {
                sb.Append(language.Write());
            }

            foreach (var publication in this.Publications)
            {
                sb.Append(publication.Write());
            }

            foreach (var award in this.Awards)
            {
                sb.Append(award.Write());
            }

            foreach (var exam in this.Exams)
            {
                sb.Append(exam.Write());
            }

            foreach (var interest in this.Interests)
            {
                sb.Append(interest.Write());
            }

            foreach (var reference in this.References)
            {
                sb.Append(reference.Write());
            }

            return sb.ToString();
        }
    }
}