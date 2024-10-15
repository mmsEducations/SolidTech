

namespace SolidTech.Data.Configuration
{
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.ToTable("Messages");
            builder.HasKey(x => x.MessageId);

            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.Property(x => x.Email)
                   .HasMaxLength(200)
                   .IsRequired();


            builder.Property(x => x.MessageHeader)
                   .IsRequired()
                 .HasMaxLength(200);

            builder.Property(x => x.MessageContent)
                   .IsRequired()
                 .HasMaxLength(1000);

            builder.Property(x => x.CreaDate)
                   .IsRequired();

        }
    }
}
