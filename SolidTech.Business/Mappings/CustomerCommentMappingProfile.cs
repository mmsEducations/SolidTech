using AutoMapper;
using SolidTech.Business.Dtos;
using SolidTech.Data.Entities;

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
