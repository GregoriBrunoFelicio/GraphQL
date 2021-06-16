using GraphQL.Interfaces;
using GraphQL.Models;
using Microsoft.AspNetCore.Mvc;

namespace GraphQL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly IProduct productService;

        public ProductController(IProduct product)
        {
            this.productService = product;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(productService.GetAllProducts());

        [HttpGet("{id}")]
        public IActionResult GetById(int id) => Ok(productService.GetProductById(id));

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            productService.DelteProduct(id);
            return Ok();
        }


        [HttpPost]
        public IActionResult Post([FromBody] Product product) => Ok(productService.AddProduct(product));

        [HttpPut("{id}")]
        public IActionResult Post([FromBody] Product product, int id) => Ok(productService.UpdateProduct(product, id));

    }
}
