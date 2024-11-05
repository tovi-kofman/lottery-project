using Microsoft.AspNetCore.Mvc;
using MyProject.Entities;

namespace MyProject.Services
{
    public class ProductInLotteryService
    {
        public List<ProductInLottery> ProductsInLotteries { get; set; }
        public ProductInLotteryService()
        {
            ProductsInLotteries = new List<ProductInLottery>();
        }
        public List<ProductInLottery> GetProductsInLotteries() { return ProductsInLotteries; }
        public ProductInLottery GetProductInLotteryById(int id)
        {
            return ProductsInLotteries.FirstOrDefault(x => x.ProductInLotteryId == id);
        }
        public void AddProductInLottery(ProductInLottery productInLottery)
        {
            ProductsInLotteries.Add(productInLottery);
        }
        public ActionResult<bool> UpdatePrpductInLottery(int id,ProductInLottery productInLottery)
        {
            foreach (ProductInLottery prodInLottery in ProductsInLotteries)
            {
                if (prodInLottery.ProductInLotteryId == id)
                {
                    ProductsInLotteries.Insert(ProductsInLotteries.IndexOf(prodInLottery),productInLottery);
                    //prodInLottery.ProductInLotteryId = productInLottery.ProductInLotteryId;
                    //prodInLottery.ProductID = productInLottery.ProductID;
                    //prodInLottery.LotteryID = productInLottery.LotteryID;
                    //prodInLottery.PrizeDistribution = productInLottery.PrizeDistribution;
                    //prodInLottery.ClaimDeadline = productInLottery.ClaimDeadline;
                    //prodInLottery.ListWinners = productInLottery.ListWinners;
                    // return new OkResult();
                    return true;
                }
            }
            //return new NotFoundResult();//////////////////
            return false;
        }
        public ActionResult<bool> RemoveProductInLottery(int id)
        {
            return ProductsInLotteries.Remove(ProductsInLotteries.FirstOrDefault(x => x.ProductInLotteryId == id));
        }
    }
}
