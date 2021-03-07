using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    public class GoldCard : DiscountCard
    {
        public GoldCard(float turnover, float purchaseValue) : base(turnover, purchaseValue)
        {

        }

        public override float DiscountRate { get; set; } = 2.0f;

        protected override float CalcDiscountRate()
        {
            DiscountRate += (float)Math.Floor(Turnover / 100);

            if (DiscountRate > 10.0f)
                DiscountRate = 10.0f;

            return DiscountRate;
        }

        protected override void PrintCardType()
        {
            Console.WriteLine($"3. Gold:");
            Console.WriteLine();
        }
    }

}
