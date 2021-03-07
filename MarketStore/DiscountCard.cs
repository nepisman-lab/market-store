using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    public abstract class DiscountCard
    {
        public string Owner { get; set; }
        public float Turnover { get; set; }
        public abstract float DiscountRate { get; set; }
        public float PurchaseValue { get; set; }


        public DiscountCard(float turnover, float purchaseValue)
        {
            Turnover = (turnover >= 0) ? turnover : throw new ArgumentException("Turnover value cant be  less then zero");
            PurchaseValue = (purchaseValue >= 0) ? purchaseValue : throw new ArgumentException("PurchaseValue cant be less then zero");
        }

        protected abstract float CalcDiscountRate();

        float CalcDiscount()
        {
            return PurchaseValue * (DiscountRate / 100);
        }

        float CalcTotal()
        {
            return PurchaseValue - CalcDiscount();
        }

        protected abstract void PrintCardType();

        // Note: Switch the console font to "Consolas" in console properties, in order to display bullets  
        public void PrintOutput()
        {
            PrintCardType();
            Console.WriteLine($"   a. Mock data: turnover ${Turnover}, purchase value ${PurchaseValue}");
            Console.WriteLine($"   b. Output:");
            Console.WriteLine();
            Console.WriteLine($"   \x25E6 Purchase value: ${PurchaseValue:f2}");
            Console.WriteLine();
            Console.WriteLine($"   \x25E6 Discount rate: {CalcDiscountRate():f1}%");
            Console.WriteLine();
            Console.WriteLine($"   \x25E6 Discount: ${CalcDiscount():f2}");
            Console.WriteLine();
            Console.WriteLine($"   \x25E6 Total: ${CalcTotal():f2}");
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}
