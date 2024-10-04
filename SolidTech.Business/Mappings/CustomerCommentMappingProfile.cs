using AutoMapper;
using SolidTech.Business.Dtos;

namespace SolidTech.Business.Mappings
{
    public class CustomerCommentMappingProfile : Profile
    {
        public CustomerCommentMappingProfile()
        {
            CreateMap<CustomerCommentDto, CustomerCommentDto>()
                     .ReverseMap();
        }
    }
}
