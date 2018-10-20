using System;
namespace ExxonRedeemtion.Models
{
    public class Coupon
    {
        public int Id { get; set; }
        public DateTime LotDate { get; set; }
        public string Code { get; set; }
        public int Price { get; set; }
        public string AddBy { get; set; }
        public string AddDate { get; set; }
        public int RedemptionId { get; set; }
        public virtual Redepmtion Redemption { get; set; }
    }
}