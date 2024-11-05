using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyProject.Entities;

namespace MyProject.Services
{
    public class LotteryService
    {
        public List<Lottery> Lotteries { get; set; }
        public LotteryService()
        {
            Lotteries = new List<Lottery>();
        }
        public List<Lottery> GetLotteries()
        {
            return Lotteries;
        }
        public Lottery GetLotteryById(int id)
        {
            return Lotteries.FirstOrDefault(x=>x.LotteryId==id);
        }
        public void AddLottery(Lottery lottery)
        {
            Lotteries.Add(lottery);
        }
        public ActionResult UpdateLottery(int id,Lottery lottery)
        {
            foreach (Lottery lott in Lotteries)
            {
                if (lott.LotteryId == id)
                {
                    Lotteries.Insert(Lotteries.IndexOf(lott), lottery);
                    //lott.LotteryId =lottery.LotteryId;
                    //lott.TicketPrice =lottery.TicketPrice;
                    //lott.StartDate =lottery.StartDate;
                    //lott.EndDate =lottery.EndDate;
                    //lott.LotteryType=lottery.LotteryType;
                    //lott.JackpotAmount =lottery.JackpotAmount;
                    //lott.DrawFrequency =lottery.DrawFrequency;
                    //lott.TicketSalesChannels =lottery.TicketSalesChannels;
                    //lott.OddsOfWinning=lottery.OddsOfWinning;
                    //lott.WinningsAmount =lottery.WinningsAmount;
                    //lott.TicketSalesDeadline =lottery.TicketSalesDeadline;
                    return new OkResult();
                }
            }
            return new NotFoundResult();
        }
        public ActionResult<bool> RemoveLottery(int id)
        {
            return Lotteries.Remove(Lotteries.FirstOrDefault(x => x.LotteryId == id);
        }
    }
}
