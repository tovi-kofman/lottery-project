using Microsoft.AspNetCore.Mvc;
using MyProject.DTO;
using MyProject.Entities;
using MyProject.Interface;

namespace MyProject.Services
{
    public class ProductInLotteryService
    {
        //static DataContext DataContextManager { get; set; }
        readonly IDataContext _dataContext;

        public ProductInLotteryService(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<ProductInLottery> GetProductsInLotteries() { return _dataContext.LoadData<ProductInLottery>(); }
        public ProductInLottery GetProductInLotteryById(int id)
        {
            
            return _dataContext.LoadData<ProductInLottery>().FirstOrDefault(x => x.ProductInLotteryId == id);
        }
        public bool AddProductInLottery(ProductInLottery productInLottery)
        {
            var productsInLottery = _dataContext.LoadData<ProductInLottery>();
            productsInLottery.Add(productInLottery);
            return _dataContext.SaveData(productsInLottery);
        }
        public bool UpdatePrpductInLottery(int id, ProductInLottery productInLottery)
        {
            var productsInLotteries=_dataContext.LoadData<ProductInLottery>();
            foreach (ProductInLottery prodInLottery in productsInLotteries)
            {
                if (prodInLottery.ProductInLotteryId == id)
                {
                    prodInLottery.ProductId = productInLottery.ProductId;
                    prodInLottery.LotteryId = productInLottery.LotteryId;
                    prodInLottery.PrizeDistribution = productInLottery.PrizeDistribution;
                    prodInLottery.ClaimDeadline = productInLottery.ClaimDeadline;
                    prodInLottery.WinnerId = productInLottery.WinnerId;
                    return _dataContext.SaveData(productsInLotteries);
                }
            }
            return false;
        }
        public bool RemoveProductInLottery(int id)
        {
            var productsInLottery=_dataContext.LoadData<ProductInLottery>();
            return productsInLottery.Remove(productsInLottery.FirstOrDefault(x => x.ProductInLotteryId == id));
        }
    }
}
