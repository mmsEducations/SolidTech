using AutoMapper;
using SolidTech.Business.Dtos;
using SolidTech.Data.Entities;

namespace SolidTech.Business.Mappings
{
    public class SolutionMappingProfile : Profile
    {
        public SolutionMappingProfile()
        {
            CreateMap<Solution, SolutionDto>()
                     .ReverseMap();

            //CreateMap  : Solution girdiğinde SolutionDto
            //ReverseMap : SolutionDto girdiğinde Solution elde eder 
            // CreateMap<DönüşecekAnaKayank, EldeEdilecekYeniKaynak>()
        }
    }
}
