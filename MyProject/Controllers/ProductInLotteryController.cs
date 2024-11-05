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
        public ProductInLotteryService ProductInLotteryS { get; set; }
        // GET: api/<ProductInLotteryController>
        [HttpGet]
        public IEnumerable<ProductInLottery> Get()
        {
            return ProductInLotteryS.GetProductsInLotteries();
        }

        // GET api/<ProductInLotteryController>/5
        [HttpGet("{id}")]
        public ProductInLottery Get(int id)
        {
            return ProductInLotteryS.GetProductInLotteryById(id);
        }

        // POST api/<ProductInLotteryController>
        [HttpPost]
        public void Post([FromBody] ProductInLottery productInLottery)
        {
            ProductInLotteryS.AddProductInLottery(productInLottery);
        }

        // PUT api/<ProductInLotteryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ProductInLottery productInLottery)
        {
            ProductInLotteryS.UpdatePrpductInLottery(id, productInLottery);
        }

        // DELETE api/<ProductInLotteryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ProductInLotteryS.RemoveProductInLottery(id);
        }
    }
}
