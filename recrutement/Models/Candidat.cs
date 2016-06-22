using System;
using System.Collections.Generic;
using recrutement.Models;

namespace recrutement.Models
{
    public class Candidat
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public int HomePhone { get; set; }
        public int MobilePhone { get; set; }
        public string Birthday { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
        public string EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}