using System;

namespace ExxonRedeemtion.Models{
    public class Redeemtion{
        public int Id { get; set; }
        public string CustomerName {get;set;}
        public string RedeemDate{get;set;}
        public int CouponPrice {get;set;}
        public int Quantity {get;set;}
    }
}