
namespace SolidTech.Data.Entities
{
    public class Message : BaseEntity
    {
        public int MessageId { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string MessageHeader { get; set; }
        public required string MessageContent { get; set; }

    }
}
