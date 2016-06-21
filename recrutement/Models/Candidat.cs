using System;
using System.Collections.Generic;
using recrutement.Models;

namespace recrutement.Models
{
    public class Candidat
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}