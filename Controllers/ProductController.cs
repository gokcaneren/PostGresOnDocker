using Microsoft.AspNetCore.Mvc;
using SimpleApi.Dal.Repositories;
using SimpleApi.Models;

namespace SimpleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<Product> GetAll()
        {
            return Ok( _repository.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id){

            var product = await _repository.GetAsync(id);

            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduct(int id){
            var product = await _repository.GetAsync(id);

            _repository.Remove(product);

            return NoContent();
        }

        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            _repository.AddAsync(product);
            return Ok();
        }

        [HttpPut]
        public ActionResult UpdateProduct(Product product)
        {
            _repository.Update(product);
            return Ok();
        }
    }
}