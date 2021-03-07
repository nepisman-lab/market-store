using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;

            try
            {
                BronzeCard bronzeCard = new BronzeCard(0, 150);
                SilverCard silverCard = new SilverCard(600, 850);
                GoldCard goldCard = new GoldCard(1500, 1300);

                bronzeCard.PrintOutput();
                silverCard.PrintOutput();
                goldCard.PrintOutput();
            }
            catch (ArgumentException argumentExc)
            {
                Console.WriteLine($"{argumentExc.GetType().Name}: {argumentExc.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
