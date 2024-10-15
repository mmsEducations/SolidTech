namespace SolidTech.Business.Mappings
{
    public class MessageMappingProfile : Profile
    {
        public MessageMappingProfile()
        {
            CreateMap <Message,MessageDto> ()
                     .ReverseMap();
        }
    }
}
