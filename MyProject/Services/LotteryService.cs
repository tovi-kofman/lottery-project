//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using MyProject.DTO;
//using MyProject.Entities;
//using MyProject.Interface;

//namespace MyProject.Services
//{
//    public class LotteryService
//    {
//        //static DataContext DataContextManager { get; set; }
//        readonly IDataContext _dataContext;

//        public LotteryService(IDataContext dataContext)
//        {
//            _dataContext = dataContext;
//        }
//        public List<Lottery> GetLotteries()
//        {
//            var lotteries = _dataContext.LoadData();
//            return lotteries;
//        }
//        public Lottery GetLotteryById(int id)
//        {
//            return DataContextManager.Lotteries.FirstOrDefault(x=>x.LotteryId==id);
//        }
//        public bool AddLottery(Lottery lottery)
//        {
//            DataContextManager.Lotteries.Add(lottery);
//            return true;
//        }
//        public bool UpdateLottery(int id,Lottery lottery)
//        {
//            foreach (Lottery lott in DataContextManager.Lotteries)
//            {
//                if (lott.LotteryId == id)
//                {

//                    lott.TicketPrice = lottery.TicketPrice;
//                    lott.StartDate = lottery.StartDate;
//                    lott.EndDate = lottery.EndDate;
//                    lott.LotteryType = lottery.LotteryType;
//                    lott.JackpotAmount = lottery.JackpotAmount;
//                    lott.DrawFrequency = lottery.DrawFrequency;
//                    lott.TicketSalesChannel = lottery.TicketSalesChannel;
//                    lott.OddsOfWinning = lottery.OddsOfWinning;
//                    lott.WinningsAmount = lottery.WinningsAmount;
//                    lott.TicketSalesDeadline = lottery.TicketSalesDeadline;
//                    return true;
//                }
//            }
//            return false;
//        }
//        public bool RemoveLottery(int id)
//        {
//            return DataContextManager.Lotteries.Remove(DataContextManager.Lotteries.FirstOrDefault(x => x.LotteryId == id));
//        }
//    }
//}
