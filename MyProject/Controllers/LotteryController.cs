using Microsoft.AspNetCore.Mvc;
using MyProject.Entities;
using MyProject.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LotteryController : ControllerBase
    {
        public LotteryService LotteryS { get; set; }
        // GET: api/<LotteryController>
        [HttpGet]
        public List<Lottery> Get()/////////////
        {
            return LotteryS.GetLotteries();
        }

        // GET api/<LotteryController>/5
        [HttpGet("{id}")]
        public Lottery Get(int id)
        {
            return LotteryS.GetLotteryById(id);
        }

        // POST api/<LotteryController>
        [HttpPost]
        public void Post([FromBody] Lottery lottery)
        {
           LotteryS.AddLottery(lottery);
        }

        // PUT api/<LotteryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Lottery lottery)
        {
            LotteryS.UpdateLottery(id,lottery);
        }

        // DELETE api/<LotteryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            LotteryS.RemoveLottery(id);
        }
    }
}
