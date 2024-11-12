//using Microsoft.AspNetCore.Mvc;
//using MyProject.DTO;
//using MyProject.Entities;

//namespace MyProject.Services
//{
//    public class TicketService
//    {
//        //static DataContext DataContextManager { get; set; }
//        public DataContext DataContextManager = ManagerDataContext.DataContext;


//        public List<Ticket> GetTickets()
//        {
//            return DataContextManager.Tickets;
//        }
//        public Ticket GetTicketById(int id)
//        {
//            return DataContextManager.Tickets.FirstOrDefault(x => x.TicketId == id);
//        }
//        public void AddTicket(Ticket ticket)
//        {
//            DataContextManager.Tickets.Add(ticket);
//        }

//        public bool UpdateTicket(int id,Ticket ticket)
//        {
//            foreach (Ticket tick in DataContextManager.Tickets)
//            {
//                if(tick.TicketId==id)
//                {
//                    tick.TicketValidationStatus = ticket.TicketValidationStatus;
//                    tick.Status = ticket.Status;
//                    tick.PurchaseDate = ticket.PurchaseDate;
//                    tick.ExpiryDate = ticket.ExpiryDate;
//                    tick.PrizeWon = ticket.PrizeWon;
//                    tick.LotteryId = ticket.LotteryId;
//                    tick.UserId = ticket.UserId;
//                    return true;
//                }
//            }
//            return false;
//        }
//        public bool RemoveTicket(int id)
//        {
//            return DataContextManager.Tickets.Remove(DataContextManager.Tickets.FirstOrDefault(x => x.TicketId== id));
//        }

//    }
//}
