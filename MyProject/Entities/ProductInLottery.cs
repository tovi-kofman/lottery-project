using MyProject.Enum;

namespace MyProject.Entities
{
    public class ProductInLottery
    {
        public int ProductInLotteryId { get; set; }
        public Product ProductID { get; set; }
        public Lottery LotteryID { get; set; }
        public List<User> ListWinners { get; set; }//?????//to add a field in user if he win or not?
        public DateOnly ClaimDeadline { get; set; }
        public PrizeDistribution PrizeDistribution { get; set; }

    }
}
