using System;
using ResumeNET;
using ResumeNET.Entity;
using ResumeNET.Type;
using System.Collections.Generic;

namespace TestConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Resume resume = new Resume();

            Basic basic = new Basic();

            basic.FirstName = "PersonName";
            basic.LastName = "PersonLastName";
            basic.EmailAddress = "example@gmail.com";
            basic.PhoneNumber = "05318529641";
            basic.Website = "example.com";
            basic.Summary = "I'm PersonName. I'm studying Computer Engineering";
            basic.Location.Address = "Istanbul, Turkey";
            basic.Location.ZipCode = 76550;
            basic.Location.City = "Istanbul";
            basic.Location.Country = "Turkey";
            basic.Location.Region = "Marmara";

            resume.Basic = basic;

            Education education = new Education();

            education.Institution = "Example University";
            education.Area = "Computer Engineering";
            education.StartDate = "18-09-2013";
            education.StudyType = "Bachelor";
            education.EndDate = "15-06-2018";
            education.Gno = (decimal)3.20;

            resume.Educations.Add(education);


            Work work = new Work();

            work.Name = "Apple Inc";
            work.Position = "Intern";
            work.Website = "apple.com";
            work.StartDate = "02-07-2018";
            work.EndDate = "03-09-2018";
            work.WorkState = WorkState.Company;

            resume.Works.Add(work);

            Skill skill = new Skill();

            skill.Name = "Object Oriented Programming";
            skill.SkillLevel = SkillLevel.Average;

            resume.Skills.Add(skill);

            Language language = new Language();

            language.Name = "English";
            language.LanguageLevel = LanguageLevel.UpperIntermediate;

            resume.Languages.Add(language);

            Publication publication = new Publication();

            publication.Name = "MVC Topic";
            publication.Publisher = "Computer Life";
            publication.ReleaseDate = "12-10-2018";
            publication.Website = "computerlife.com";

            resume.Publications.Add(publication);

            Award award = new Award();

            award.Title = "Chess Tournament";
            award.Date = "01-05-2017";
            award.Awarder = "Marshall Chess Club";
            award.Summary = "Chess Winner";

            resume.Awards.Add(award);

            Exam exam = new Exam();

            exam.Name = "Toefl";
            exam.Date = "08-07-2016";
            exam.Score = (decimal)80.0;

            resume.Exams.Add(exam);

            Reference reference = new Reference();

            reference.FirstName = "AnotherPersonName";
            reference.LastName = "AnotherPersonLastName";
            reference.PhoneNumber = "05346256598";

            resume.References.Add(reference);


            resume.Show();
            education.Show();
            work.Show();
            skill.Show();
            language.Show();
            publication.Show();
            award.Show();
            exam.Show();
            reference.Show();

        Console.ReadLine();
        }
    }
}
