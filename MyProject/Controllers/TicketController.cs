using Microsoft.AspNetCore.Mvc;
using MyProject.Entities;
using MyProject.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        //public TicketService TicketS { get; set; }
        readonly TicketService _ticketService;

        public TicketController(TicketService ticketService)
        {
            _ticketService = ticketService;
        }

        // GET: api/<TicketController>

        [HttpGet]
        public ActionResult<List<Ticket>> Get()
        {
            return _ticketService.GetTickets();
        }

        // GET api/<TicketController>/5
        [HttpGet("{id}")]
        public ActionResult<Ticket> Get(int id)
        {
            Ticket ticket = _ticketService.GetTicketById(id);
            if (ticket == null)
            {
                return NotFound(ticket);
            }
            return Ok(ticket);
        }

        // POST api/<TicketController>
        [HttpPost]
        public ActionResult Post([FromBody] Ticket ticket)
        {
            _ticketService.AddTicket(ticket);
            return Ok();
        }

        // PUT api/<TicketController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Ticket ticket)
        {
            return _ticketService.UpdateTicket(id, ticket);
        }

        // DELETE api/<TicketController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _ticketService.RemoveTicket(id);
        }
    }
}
