using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolidTech.Data.Entities;

namespace SolidTech.Data.Configuration
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Projects");
            builder.HasKey(x => x.ProjectId);
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(x => x.Image)
             .IsRequired()
             .HasMaxLength(500);

            builder.Property(x => x.Order)
                   .IsRequired();

            builder.Property(x => x.CreaDate)
                   .IsRequired();

            builder.HasOne(x => x.ProjectCategory)
                   .WithMany()
                   .HasForeignKey(x => x.ProjectCategoryId);

        }
    }
}
