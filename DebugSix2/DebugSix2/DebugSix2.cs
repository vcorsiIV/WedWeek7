// Program averages four numbers
using static System.Console;

namespace DebugSix2
{
    class DebugSix2
    {
        static void Main()
        {
            int[] numbers = { 12, 15, 22, 88 };
            int x;
            double average;
            double total = 0;
            Write("\nThe numbers are...");
            //No nmbers instead its numbers
            for (x = 0; x < numbers.Length; ++x)
                //only needs to be {0,3} not {0,6}
                Write("{0, 3}", numbers[x]);
            WriteLine();
            for (x = 0; x < numbers.Length; ++x)
            {
                //total += numbers[x]
                total += numbers[x];
            }
            //.Length is capitialized
            average = total / numbers.Length;
            //add the average to ge set into {0}
            Write("The average is {0}\n", average);
        }
    }
}
