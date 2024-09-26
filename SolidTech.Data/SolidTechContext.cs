using Microsoft.EntityFrameworkCore;
using SolidTech.Data.Configuration;
using SolidTech.Data.Entities;

namespace SolidTech.Data
{
    public class SolidTechContext : DbContext
    {
        public SolidTechContext()
        {

        }
        public SolidTechContext(DbContextOptions<SolidTechContext> options) : base(options)
        {

        }

        public DbSet<ProjectCategory> ProjectCategories { get; set; }
        public DbSet<Project> Projects { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProjectCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        //Configurasyon yapıldığında çalıştırılamsını istediğin kodlar buraya yazılır
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=SolidTechDb;Trusted_Connection=True;Encrypt=False");
        }
    }
}
