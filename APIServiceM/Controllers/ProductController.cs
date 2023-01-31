using APIServiceM.IServices;
using Entities.Entities;
using Entities.SearchFilters;
using Microsoft.AspNetCore.Mvc;

namespace APIServiceM.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;
        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpPost(Name = "InsertProduct")]
        public int Post([FromBody] ProductItem productItem)
        {
            return _productService.InsertProduct(productItem);
        }

        [HttpGet(Name = "GetProducts")] 
        public List<ProductItem> GetProduct() 
        {
            return _productService.GetProduct();
        }

        //[HttpGet(Name = "GetProductsByCriteria")]
        //public List<ProductItem> GetByCriteria(bool isActive)
        //{
        //    var productFilter = new ProductFilter();
        //    productFilter.IsActive = isActive;
        //    return _productService.GetProductsByCriteria(productFilter);
        //}

        [HttpDelete(Name = "DeleteProduct")]

            public void DeleteProductItem([FromQuery] int id)
            {
            _productService.DeleteProductItem(id);
         }
    }
}

