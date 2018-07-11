using ResumeNET.Entity;
using ResumeNET.Type;
using System;

namespace TestConsole
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Resume resume = new Resume();

            var Loc = new Location("Istanbul, Turkey", 74650, "Istanbul", "Turkey", "Marmara");

            Basic basic = new Basic(Loc, "Ali", "Atakay", "aliatakay.com");
            basic.PhoneNumber = "05318529641";
            basic.Website = "example.com";
            basic.Summary = "I'm Ali Atakay. I'm studying Computer Engineering";
            resume.Basic = basic;

            Education education = new Education("Example University", "Computer Engineering", "Bachelor");
            education.StartDate = "18-09-2013";
            education.EndDate = "15-06-2018";
            education.Gno = (decimal)3.20;
            resume.Educations.Add(education);

            Work work = new Work(WorkState.Company, "Apple Inc.", "Intern");
            work.Website = "apple.com";
            work.StartDate = "02-07-2018";
            work.EndDate = "03-09-2018";
            resume.Works.Add(work);

            Skill skill = new Skill("Object Oriented Programming", SkillLevel.Average);
            resume.Skills.Add(skill);

            Language language = new Language("English", LanguageLevel.UpperIntermediate);
            resume.Languages.Add(language);

            Publication publication = new Publication("MVC Topic", "Computer Life");
            publication.ReleaseDate = "12-10-2018";
            publication.Website = "computerlife.com";
            resume.Publications.Add(publication);

            Award award = new Award("Chess Tournament", "01-05-2017", "Marshall Chess Club", "Chess Winner");
            resume.Awards.Add(award);

            Exam exam = new Exam("Toefl", (decimal)80.0, "08-07-2016");
            resume.Exams.Add(exam);

            Interest interest = new Interest("Chess");

            Reference reference = new Reference("PersonName", "PersonLastName", "05346256598");
            resume.References.Add(reference);

            Console.WriteLine(resume.Write());

            Console.ReadLine();
        }
    }
}