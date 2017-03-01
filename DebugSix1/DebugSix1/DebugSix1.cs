// Lists items for sale and their prices
using static System.Console;

namespace DebugSix1
{
    class DebugSix1
    {
        static void Main()
        {
            string[] items = { "Belt", "Tie", "Scarf", "Cufflinks" };
            double[] prices = { 29.00, 35.95, 18.50, 112.99 };
            WriteLine("Items for sale:");
            //Needs to be x < item.Length; x++
            for (int x = 0; x < items.Length; x++)
                //First get rid of the extra } in {1,10}}
                //Then make it {0,3} for {1,3} or {0} for {1} also works
                WriteLine("{0,3} for {1,3}",
                   items[x], prices[x].ToString("C"));
        }
    }
}
