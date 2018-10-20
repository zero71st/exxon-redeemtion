using System;
using System.Collections.Generic;

namespace ExxonRedeemtion.Models{
    public class Redepmtion{
        public int Id { get; set; }
        public string CustomerName {get;set;}
        public int CouponPrice {get;set;}
        public int Quantity {get;set;}
        public DateTime RetrieveDate {get;set;}
        public virtual List<Coupon> Coupons {get;set;}
    }
}