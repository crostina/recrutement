using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using recrutement.Models;

namespace recrutement.DAL
{
    public class recrutementInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<recruteContext>
    {
        protected override void Seed(recruteContext context)
        {
            var students = new List<Candidat>
            {
            new Candidat{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Candidat{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Candidat{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Candidat{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Candidat{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Candidat{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Candidat{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Candidat{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Candidats.Add(s));
            context.SaveChanges();
            var courses = new List<Skill>
            {
            new Skill{SkillID=1050,Title="Chemistry",Credits=3,},
            new Skill{SkillID=4022,Title="Microeconomics",Credits=3,},
            new Skill{SkillID=4041,Title="Macroeconomics",Credits=3,},
            new Skill{SkillID=1045,Title="Calculus",Credits=4,},
            new Skill{SkillID=3141,Title="Trigonometry",Credits=4,},
            new Skill{SkillID=2021,Title="Composition",Credits=3,},
            new Skill{SkillID=2042,Title="Literature",Credits=4,}
            };
            courses.ForEach(s => context.Skills.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{CandidatID=1,SkillID=1050,Grade=Grade.A},
            new Enrollment{CandidatID=1,SkillID=4022,Grade=Grade.C},
            new Enrollment{CandidatID=1,SkillID=4041,Grade=Grade.B},
            new Enrollment{CandidatID=2,SkillID=1045,Grade=Grade.B},
            new Enrollment{CandidatID=2,SkillID=3141,Grade=Grade.F},
            new Enrollment{CandidatID=2,SkillID=2021,Grade=Grade.F},
            new Enrollment{CandidatID=3,SkillID=1050},
            new Enrollment{CandidatID=4,SkillID=1050,},
            new Enrollment{CandidatID=4,SkillID=4022,Grade=Grade.F},
            new Enrollment{CandidatID=5,SkillID=4041,Grade=Grade.C},
            new Enrollment{CandidatID=6,SkillID=1045},
            new Enrollment{CandidatID=7,SkillID=3141,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}