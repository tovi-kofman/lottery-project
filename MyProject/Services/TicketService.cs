using Microsoft.AspNetCore.Mvc;
using MyProject.Entities;

namespace MyProject.Services
{
    public class TicketService
    {
        public List<Ticket> Tickets { get; set; }
        public List<Ticket> GetTickets()
        {
            return Tickets;
        }
        public Ticket GetTicketById(int id)
        {
            return Tickets.FirstOrDefault(x => x.TicketID == id);
        }
        public void AddTicket(Ticket ticket)
        {
            Tickets.Add(ticket);
        }

        public ActionResult UpdateTicket(int id,Ticket ticket)
        {
            foreach (Ticket tick in Tickets)
            {
                if(tick.TicketID==id)
                {
                    Tickets.Insert(Tickets.IndexOf(tick),ticket);
                    //tick.TicketID = ticket.TicketID;
                    //tick.TicketValidationStatus = ticket.TicketValidationStatus;
                    //tick.Status = ticket.Status;
                    //tick.PurchaseDate = ticket.PurchaseDate;
                    //tick.ExpiryDate = ticket.ExpiryDate;
                    //tick.PrizeWon = ticket.PrizeWon;
                    //tick.LotteryId = ticket.LotteryId;
                    //tick.UserID = ticket.UserID;
                    return new OkResult();
                }
            }
            return new NotFoundResult();/////////////
        }
        public ActionResult<bool> RemoveTicket(int id)
        {
            return Tickets.Remove(Tickets.FirstOrDefault(x => x.TicketID== id));
        }

    }
}
