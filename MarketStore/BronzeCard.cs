using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    public class BronzeCard : DiscountCard
    {

        public BronzeCard(float turnover, float purchaseValue) : base(turnover, purchaseValue)
        {

        }

        public override float DiscountRate { get; set; } = 0.0f;


        protected override float CalcDiscountRate()
        {
            if (Turnover >= 100 && Turnover <= 300)
                DiscountRate = 1.0f;

            else if (Turnover > 300)
                DiscountRate = 2.5f;

            return DiscountRate;
        }

        protected override void PrintCardType()
        {
            Console.WriteLine($"1. Bronze:");
            Console.WriteLine();
        }
    }
}
