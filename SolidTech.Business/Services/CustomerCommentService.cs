using AutoMapper;
using SolidTech.Business.Dtos;
using SolidTech.Business.Interfaces;
using SolidTech.Data;
using SolidTech.Data.Entities;

namespace SolidTech.Business.Services
{
    public class CustomerCommentService : ICustomerCommentService
    {
        private readonly SolidTechContext _context;
        private readonly IMapper _mapper;

        public CustomerCommentService(SolidTechContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<CustomerCommentDto> CustomerComments()
        {
            List<CustomerComment> CustomerComments = _context.CustomerComments.ToList();
            return _mapper.Map<List<CustomerCommentDto>>(CustomerComments);
        }
    }
}
