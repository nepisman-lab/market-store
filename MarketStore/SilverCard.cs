using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{

    public class SilverCard : DiscountCard
    {

        public SilverCard(float turnover, float purchaseValue) : base(turnover, purchaseValue)
        {

        }

        public override float DiscountRate { get; set; } = 2.0f;

        protected override float CalcDiscountRate()
        {
            if (Turnover > 300)
                DiscountRate = 3.5f;

            return DiscountRate;
        }

        protected override void PrintCardType()
        {
            Console.WriteLine($"2. Silver:");
            Console.WriteLine();
        }
    }
}
