﻿namespace SolidTech.Business.Services
{
    public class MessageService : IMessageService
    {
        private readonly SolidTechContext _context;//DI
        private readonly IMapper _mapper;
        public MessageService(SolidTechContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<MessageDto> Messages()
        {
            List<Message> messages = _context.Messages.ToList();
            List<MessageDto> messageDtos = _mapper.Map<List<MessageDto>>(messages);
            return messageDtos;
        }
    }


}
