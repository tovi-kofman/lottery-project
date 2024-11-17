using Microsoft.AspNetCore.Mvc;
using MyProject.Entities;
using MyProject.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductInLotteryController : ControllerBase
    {
        readonly ProductInLotteryService _productInLotteryService;

        public ProductInLotteryController(ProductInLotteryService productInLotteryService)
        {
            _productInLotteryService = productInLotteryService;
        }


        // GET: api/<ProductInLotteryController>
        [HttpGet]
        public ActionResult<List<ProductInLottery>> Get()
        {
            return Ok(_productInLotteryService.GetProductsInLotteries());
        }

        // GET api/<ProductInLotteryController>/5
        [HttpGet("{id}")]
        public ActionResult<ProductInLottery> Get(int id)
        {
            ProductInLottery p = _productInLotteryService.GetProductInLotteryById(id);
            if (p == null)
            {
                return NotFound(p);
            }
            return Ok(p);
        }

        // POST api/<ProductInLotteryController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] ProductInLottery productInLottery)
        {
            _productInLotteryService.AddProductInLottery(productInLottery);
            return Ok(true);
        }

        // PUT api/<ProductInLotteryController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] ProductInLottery productInLottery)
        {
            return _productInLotteryService.UpdatePrpductInLottery(id, productInLottery);
        }

        // DELETE api/<ProductInLotteryController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _productInLotteryService.RemoveProductInLottery(id);
        }
    }
}
