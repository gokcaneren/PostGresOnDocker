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
    }
}