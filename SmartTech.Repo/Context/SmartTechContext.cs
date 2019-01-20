using SmartTech.Data.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SmartTech.Repo.Context
{
    public class SmartTechContext : DbContext
    {
        public SmartTechContext() : base("SmartTechContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Faculty>().HasMany(e => e.Students)
                .WithRequired()
                .HasForeignKey(e => e.FacultyId);

            modelBuilder.Entity<Student>().Property(p => p.Name).IsRequired();
            modelBuilder.Entity<Student>().Property(p => p.Address).IsRequired();
            modelBuilder.Entity<Student>().Property(p => p.Phone).IsRequired();
        }

        public DbSet<Faculty> Faculties { get; set; }

    }
}
