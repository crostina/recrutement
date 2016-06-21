using recrutement.Models;

namespace recrutement.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int SkillID { get; set; }
        public int CandidatID { get; set; }
        public Grade? Grade { get; set; }

        public virtual Skill Skill { get; set; }
        public virtual Candidat Candidat { get; set; }
    }
}