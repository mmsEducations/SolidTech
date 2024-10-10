namespace SolidTech.Data.Entities
{
    public class Solution : BaseEntity
    {

        public int SolutionId { get; set; }
        public required string Header { get; set; }
        public required string Content { get; set; }
        public required string ImageIcon { get; set; }

        //[NotMapped]
        //public required string Contentss { get; set; }
    }


}
