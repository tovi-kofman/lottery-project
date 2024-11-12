//using Microsoft.AspNetCore.Mvc;
//using MyProject.Entities;
//using MyProject.Services;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace MyProject.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class LotteryController : ControllerBase
//    {
//        public LotteryService LotteryS { get; set; }
//        // GET: api/<LotteryController>
//        [HttpGet]
//        public ActionResult<List<Lottery>> Get()/////////////
//        {
//            return Ok(LotteryS.GetLotteries());
//        }

//        // GET api/<LotteryController>/5
//        [HttpGet("{id}")]
//        public ActionResult<Lottery> Get(int id)
//        {
//            Lottery l = LotteryS.GetLotteryById(id);
//            if (l == null)
//                return NotFound(l); 
//            return Ok(l);
//        }

//        // POST api/<LotteryController>
//        [HttpPost]
//        public ActionResult<bool> Post([FromBody] Lottery lottery)
//        {
//           return LotteryS.AddLottery(lottery);
            
//        }

//        // PUT api/<LotteryController>/5
//        [HttpPut("{id}")]
//        public ActionResult<bool> Put(int id, [FromBody] Lottery lottery)
//        {
//            //if( LotteryS.UpdateLottery(id,lottery))
//            //     return Ok(true);
//            //return NotFound(false);
//            return LotteryS.UpdateLottery(id, lottery);
//        }

//        // DELETE api/<LotteryController>/5
//        [HttpDelete("{id}")]
//        public ActionResult<bool> Delete(int id)
//        {
//            //if(LotteryS.RemoveLottery(id))
//            //    return Ok(true);
//            //return NotFound(false);
//            return LotteryS.RemoveLottery(id);
//        }
//    }
//}
