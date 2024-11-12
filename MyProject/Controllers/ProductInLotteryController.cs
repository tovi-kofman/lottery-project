//using Microsoft.AspNetCore.Mvc;
//using MyProject.Entities;
//using MyProject.Services;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace MyProject.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProductInLotteryController : ControllerBase
//    {
//        public ProductInLotteryService ProductInLotteryS { get; set; }
//        // GET: api/<ProductInLotteryController>
//        [HttpGet]
//        public ActionResult< List<ProductInLottery>> Get()
//        {
//            return Ok( ProductInLotteryS.GetProductsInLotteries());
//        }

//        // GET api/<ProductInLotteryController>/5
//        [HttpGet("{id}")]
//        public ActionResult< ProductInLottery> Get(int id)
//        {
//            ProductInLottery p = ProductInLotteryS.GetProductInLotteryById(id);
//            if (p== null)
//            {
//                return NotFound(p);
//            }
//            return Ok( p );
//        }

//        // POST api/<ProductInLotteryController>
//        [HttpPost]
//        public ActionResult<bool> Post([FromBody] ProductInLottery productInLottery)
//        {
//             ProductInLotteryS.AddProductInLottery(productInLottery);
//            return Ok( true );
//        }

//        // PUT api/<ProductInLotteryController>/5
//        [HttpPut("{id}")]
//        public ActionResult<bool> Put(int id, [FromBody] ProductInLottery productInLottery)
//        {
//            return ProductInLotteryS.UpdatePrpductInLottery(id, productInLottery);
//        }

//        // DELETE api/<ProductInLotteryController>/5
//        [HttpDelete("{id}")]
//        public ActionResult<bool> Delete(int id)
//        {
//            return ProductInLotteryS.RemoveProductInLottery(id);
//        }
//    }
//}
