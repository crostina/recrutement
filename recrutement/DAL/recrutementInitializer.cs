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
            var candidats = new List<Candidat>
            {
            new Candidat{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01").ToString(),Email="ssq@sss.com",HomePhone=25333555,MobilePhone=52333123,Birthday=DateTime.Parse("2005-09-01").ToString(),Website="www.ssss.com",Adress="23rue52"},
            new Candidat{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01").ToString(),Email="ssq@sss.com",HomePhone=25333555,MobilePhone=52333123,Birthday=DateTime.Parse("2005-09-01").ToString(),Website="www.ssss.com",Adress="23rue52"},
            new Candidat{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01").ToString(),Email="ssq@sss.com",HomePhone=25333555,MobilePhone=52333123,Birthday=DateTime.Parse("2005-09-01").ToString(),Website="www.ssss.com",Adress="23rue52"},
            new Candidat{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01").ToString(),Email="ssq@sss.com",HomePhone=25333555,MobilePhone=52333123,Birthday=DateTime.Parse("2005-09-01").ToString(),Website="www.ssss.com",Adress="23rue52"},
            new Candidat{FirstName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01").ToString(),Email="ssq@sss.com",HomePhone=25333555,MobilePhone=52333123,Birthday=DateTime.Parse("2005-09-01").ToString(),Website="www.ssss.com",Adress="23rue52"},
            new Candidat{FirstName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01").ToString(),Email="ssq@sss.com",HomePhone=25333555,MobilePhone=52333123,Birthday=DateTime.Parse("2005-09-01").ToString(),Website="www.ssss.com",Adress="23rue52"},
            new Candidat{FirstName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01").ToString(),Email="ssq@sss.com",HomePhone=25333555,MobilePhone=52333123,Birthday=DateTime.Parse("2005-09-01").ToString(),Website="www.ssss.com",Adress="23rue52"}
            };

            candidats.ForEach(s => context.Candidats.Add(s));
            context.SaveChanges();
            var skills = new List<Skill>
            {
            new Skill{SkillID=1050,Title="Chemistry",Credits=3,},
            new Skill{SkillID=4022,Title="Microeconomics",Credits=3,},
            new Skill{SkillID=4041,Title="Macroeconomics",Credits=3,},
            new Skill{SkillID=1045,Title="Calculus",Credits=4,},
            new Skill{SkillID=3141,Title="Trigonometry",Credits=4,},
            new Skill{SkillID=2021,Title="Composition",Credits=3,},
            new Skill{SkillID=2042,Title="Literature",Credits=4,}
            };
            skills.ForEach(s => context.Skills.Add(s));
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