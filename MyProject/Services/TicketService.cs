using Microsoft.AspNetCore.Mvc;
using MyProject.DTO;
using MyProject.Entities;
using MyProject.Interface;

namespace MyProject.Services
{
    public class TicketService
    {
        //static DataContext DataContextManager { get; set; }
        readonly IDataContext _dataContext;
        public TicketService(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Ticket> GetTickets()
        {
            return _dataContext.LoadData<Ticket>();
        }
        public Ticket GetTicketById(int id)
        {
            return _dataContext.LoadData<Ticket>().FirstOrDefault(x => x.TicketId == id);
        }
        public bool AddTicket(Ticket ticket)
        {
            var tickets=_dataContext.LoadData<Ticket>();
            tickets.Add(ticket);
           return  _dataContext.SaveData<Ticket>(tickets);
        }

        public bool UpdateTicket(int id, Ticket ticket)
        {
            var tickets= _dataContext.LoadData<Ticket>();
            foreach (Ticket tick in tickets)
            {
                if (tick.TicketId == id)
                {
                    tick.TicketValidationStatus = ticket.TicketValidationStatus;
                    tick.Status = ticket.Status;
                    tick.PurchaseDate = ticket.PurchaseDate;
                    tick.ExpiryDate = ticket.ExpiryDate;
                    tick.PrizeWon = ticket.PrizeWon;
                    tick.LotteryId = ticket.LotteryId;
                    tick.UserId = ticket.UserId;
                    return _dataContext.SaveData(tickets);
                }
            }
            return false;
        }
        public bool RemoveTicket(int id)
        {
            var tickets= _dataContext.LoadData<Ticket>();
            return tickets.Remove(tickets.FirstOrDefault(x => x.TicketId == id));
        }

      
    }

}
