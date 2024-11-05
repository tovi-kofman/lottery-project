using MyProject.Enum;

namespace MyProject.Entities
{
    public class Lottery
    {
        public int? LotteryId { get; set; }
        public LotteryType? LotteryType { get; set; }
        public double? TicketPrice { get; set; }
        public DateOnly? StartDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public double? JackpotAmount { get; set; }
        public double? OddsOfWinning { get; set; }
        public DateOnly? TicketSalesDeadline { get; set; }
        public Frequency? DrawFrequency { get; set; }
        public List<string>? TicketSalesChannels { get; set; }
        public int? WinningsAmount { get; set; }

    }
}
