
using recrutement.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace recrutement.DAL
{
    public class recruteContext : DbContext
    {
        public recruteContext() : base("recruteContext")
        {
            base.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Candidat> Candidats { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Skill> Skills { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}