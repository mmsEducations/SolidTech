namespace SolidTech.Data.Configuration
{
    public class SolutionConfiguration : IEntityTypeConfiguration<Solution>
    {
        public void Configure(EntityTypeBuilder<Solution> builder)
        {
            builder.ToTable("Solutions");
            builder.HasKey(x => x.SolutionId);


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
