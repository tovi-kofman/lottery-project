//using Microsoft.AspNetCore.Mvc;
//using MyProject.DTO;
//using MyProject.Entities;

//namespace MyProject.Services
//{
//    public class ProductInLotteryService
//    {
//        //static DataContext DataContextManager { get; set; }
//        public DataContext DataContextManager = ManagerDataContext.DataContext;

//        public ProductInLotteryService()
//        {
//        }
//        public List<ProductInLottery> GetProductsInLotteries() { return DataContextManager.ProductsInLotteries; }
//        public ProductInLottery GetProductInLotteryById(int id)
//        {
//            return DataContextManager.ProductsInLotteries.FirstOrDefault(x => x.ProductInLotteryId == id);
//        }
//        public void AddProductInLottery(ProductInLottery productInLottery)
//        {
//            DataContextManager.ProductsInLotteries.Add(productInLottery);
//        }
//        public bool UpdatePrpductInLottery(int id,ProductInLottery productInLottery)
//        {
//            foreach (ProductInLottery prodInLottery in DataContextManager.ProductsInLotteries)
//            {
//                if (prodInLottery.ProductInLotteryId == id)
//                {
//                    prodInLottery.ProductId = productInLottery.ProductId;
//                    prodInLottery.LotteryId = productInLottery.LotteryId;
//                    prodInLottery.PrizeDistribution = productInLottery.PrizeDistribution;
//                    prodInLottery.ClaimDeadline = productInLottery.ClaimDeadline;
//                    prodInLottery.WinnerId = productInLottery.WinnerId;
//                    return true;
//                }
//            }
//            return false;
//        }
//        public bool RemoveProductInLottery(int id)
//        {
//            return DataContextManager.ProductsInLotteries.Remove(DataContextManager.ProductsInLotteries.FirstOrDefault(x => x.ProductInLotteryId == id));
//        }
//    }
//}
