
namespace SolidTech.Business.Mappings
{
    public class CustomerCommentMappingProfile : Profile
    {
        public CustomerCommentMappingProfile()
        {
            CreateMap<CustomerComment, CustomerCommentDto>()
                     .ReverseMap();
        }
    }
}
