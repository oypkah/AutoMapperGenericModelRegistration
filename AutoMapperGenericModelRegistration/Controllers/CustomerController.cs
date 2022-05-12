using AutoMapper;
using AutoMapperGenericModelRegistration.Dto;
using AutoMapperGenericModelRegistration.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperGenericModelRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_mapper.Map<List<CustomerResponse>>(_customerRepository.GetAll()));
        }
    }
}
