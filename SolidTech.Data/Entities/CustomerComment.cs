
namespace SolidTech.Data.Entities
{
    public class CustomerComment : BaseEntity
    {
        public int CustomerCommentId { get; set; }
        public required string CustomerName { get; set; }
        public required string Comment { get; set; }
        public string? Image { get; set; }
        public string? Title { get; set; }
        public int Order { get; set; }

    }
}
