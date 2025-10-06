using graphQLCrudApi.Interfaces;
using graphQLCrudApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace graphQLCrudApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository, ILogger<ProductController> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ProductModel> Get()
        {
            return _productRepository.GetProducts();
        }
    }
}
