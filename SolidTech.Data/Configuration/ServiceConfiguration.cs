using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolidTech.Data.Entities;

namespace SolidTech.Data.Configuration
{
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable("Services");
            builder.HasKey(x => x.ServiceId);


            builder.Property(x => x.Header)
                   //.HasColumnName("_header")
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(x => x.Content)
                   .IsRequired()
                   .HasMaxLength(500);

            builder.Property(x => x.ImageIcon)
                   .HasMaxLength(int.MaxValue)
                   .IsRequired();

            builder.Property(x => x.Order)
                   .IsRequired();

            builder.Property(x => x.CreaDate)
                   .IsRequired();

        }
    }
}
