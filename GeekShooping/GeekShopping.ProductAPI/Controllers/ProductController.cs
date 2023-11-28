using GeekShopping.ProductAPI.Data.Dto.Request;
using GeekShopping.ProductAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                var list = await _productRepository.FindAll();

                if (list == null) { return NotFound(); }

                return Ok(list);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(long id)
        {
            try
            {
                var product = await _productRepository.FindById(id);

                if (product == null) { return NotFound(); }

                return Ok(product);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] ProductRequest request)
        {
            try
            {
                if (request == null) { return BadRequest("Nenhum produto adicionado!"); }

                var createProduct = await _productRepository.Create(request);

                return Ok($"Produto {createProduct.Name} adicionado com sucesso!");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        [HttpPut]
        public async Task<ActionResult> Update([FromBody] ProductRequest request)
        {

            if (request == null) { return BadRequest(); }

            var createProduct = await _productRepository.Update(request);

            return Ok($"Produto {createProduct.Name} atualizado com sucesso!");

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var status = await _productRepository.Delete(id);

            if (status == false) { return BadRequest(); }

            return Ok("Removido o produto do BD.");

        }
    }
}
