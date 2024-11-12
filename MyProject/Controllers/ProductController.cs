//using Microsoft.AspNetCore.Mvc;
//using MyProject.Entities;
//using MyProject.Services;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace MyProject.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProductController : ControllerBase
//    {
//        public ProductService ProductS { get; set; }
//        // GET: api/<ProductController>
//        [HttpGet]
//        public ActionResult<List<Product>> Get()
//        {
//            return Ok( ProductS.GetProducts());
//        }

//        // GET api/<ProductController>/5
//        [HttpGet("{id}")]
//        public ActionResult<Product> Get(int id)
//        {
//            Product p= ProductS.GetProductById(id);
//          if (p == null)
//            {
//                return NotFound(p);
//            }
//          return Ok( p );
//        }

//        // POST api/<ProductController>
//        [HttpPost]
//        public ActionResult Post([FromBody] Product product)
//        {
//            ProductS.AddProduct(product);
//            return Ok();
//        }

//        // PUT api/<ProductController>/5
//        [HttpPut("{id}")]
//        public ActionResult<bool> Put(int id, [FromBody] Product product)
//        {
//            if( ProductS.UpdateProduct(id, product))
//                return Ok();
//            return NotFound();
//        }

//        // DELETE api/<ProductController>/5
//        [HttpDelete("{id}")]
//        public ActionResult<bool> Delete(int id)
//        {
//            return ProductS.RemoveProduct(id);
//        }
//    }
//}
