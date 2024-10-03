using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolidTech.Data.Entities;

namespace SolidTech.Data.Configuration
{
    public class CustomerCommentConfiguration : IEntityTypeConfiguration<CustomerComment>
    {
        public void Configure(EntityTypeBuilder<CustomerComment> builder)
        {
            //builder.ToTable("CustomerComments", "solidtechdb");
            builder.ToTable("CustomerComments");

            builder.HasKey(x => x.CustomerCommentId);

            builder.Property(x => x.CustomerName)
                   .IsRequired()
                   .HasMaxLength(300);

            builder.Property(x => x.Comment)
              .HasMaxLength(500)
              .IsRequired();

            builder.Property(x => x.Title)
             .HasMaxLength(200);

            builder.Property(x => x.Image)
             .HasMaxLength(int.MaxValue)
             .IsRequired();

            builder.Property(x => x.Order)
                   .IsRequired();

            builder.Property(x => x.CreaDate)
                   .IsRequired();

        }
    }
}
