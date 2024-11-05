using MyProject.Enum;
using System.Runtime.InteropServices;

namespace MyProject.Entities
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public Lottery LotteryId { get; set; }
        public TicketStatus Status { get; set; }
        public User UserID { get; set; }
        public DateOnly PurchaseDate { get; set; }
        public DateOnly ExpiryDate { get; set; }
        public bool PrizeWon { get; set; }
        public TicketValidationStatus TicketValidationStatus { get; set; }


    }
}
