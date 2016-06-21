using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace recrutement.Models
{
    public class Skill
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SkillID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}