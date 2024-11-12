using MyProject.Enum;

namespace MyProject.Entities
{
    public class Lottery
    {
        static int id = 0;
        public int? LotteryId { get; }
        public LotteryType? LotteryType { get; set; }
        public double? TicketPrice { get; set; }
        public DateOnly? StartDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public double? JackpotAmount { get; set; }
        public double? OddsOfWinning { get; set; }
        public DateOnly? TicketSalesDeadline { get; set; }
        public Frequency? DrawFrequency { get; set; }
        //public List<TicketSalesChannel>? TicketSalesChannels { get; set; }
        public TicketSalesChannel? TicketSalesChannel { get; set; }
        public int? WinningsAmount { get; set; }

        public Lottery(LotteryType? lotteryType, double? ticketPrice, DateOnly? startDate, DateOnly? endDate, double? jackpotAmount, double? oddsOfWinning, DateOnly? ticketSalesDeadline, Frequency? drawFrequency, TicketSalesChannel? ticketSalesChannel, int? winningsAmount)
        {
            LotteryId = id++;
            LotteryType = lotteryType;
            TicketPrice = ticketPrice;
            StartDate = startDate;
            EndDate = endDate;
            JackpotAmount = jackpotAmount;
            OddsOfWinning = oddsOfWinning;
            TicketSalesDeadline = ticketSalesDeadline;
            DrawFrequency = drawFrequency;
            TicketSalesChannel = ticketSalesChannel;
            WinningsAmount = winningsAmount;
        }

        public Lottery()
        {
        }
    }

}
