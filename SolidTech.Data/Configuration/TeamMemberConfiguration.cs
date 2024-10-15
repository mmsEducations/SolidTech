namespace SolidTech.Data.Configuration
{
    public class TeamMemberConfiguration : IEntityTypeConfiguration<TeamMember>
    {
        public void Configure(EntityTypeBuilder<TeamMember> builder)
        {
            builder.ToTable("TeamMembers");
            builder.HasKey(x => x.TeamMemberId);

            builder.Property(x => x.NameLastname)
                   .IsRequired()
                   .HasMaxLength(300);

            builder.Property(x => x.Title)
                   .HasMaxLength(200)
                   .IsRequired();

            builder.Property(x => x.Linkedin)
              .HasMaxLength(200)
              .IsRequired();


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
