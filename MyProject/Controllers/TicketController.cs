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
        public TicketService TicketS { get; set; }
        // GET: api/<TicketController>
        [HttpGet]
        public IEnumerable<Ticket> Get()
        {
            return TicketS.GetTickets();
        }

        // GET api/<TicketController>/5
        [HttpGet("{id}")]
        public Ticket Get(int id)
        {
            return TicketS.GetTicketById(id);
        }

        // POST api/<TicketController>
        [HttpPost]
        public void Post([FromBody]Ticket ticket)
        {
            TicketS.AddTicket(ticket);
        }

        // PUT api/<TicketController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Ticket ticket)
        {
            TicketS.UpdateTicket(id, ticket);
        }

        // DELETE api/<TicketController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            TicketS.RemoveTicket(id);
        }
    }
}
