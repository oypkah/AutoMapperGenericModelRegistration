using AutoMapper;
using AutoMapperGenericModelRegistration.Dto;
using AutoMapperGenericModelRegistration.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperGenericModelRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductController(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_mapper.Map<List<ProductResponse>>(_productRepository.GetAll()));
        }
    }
}
