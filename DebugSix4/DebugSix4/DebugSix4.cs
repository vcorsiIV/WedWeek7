// Program prompts user for any number of values 
// (up to 20)
// and averages them
using System;
using static System.Console;

namespace DebugSix4
{
    class DebugSix4
    {
        public static void Main()
        {
            const int QUIT = 999;
            //new int array needs a set value for now make it new int[QUIT]
            int[] numbers = new int[QUIT];
            //x needs to hava a set value so that it can be read in the while loop
            int x = 0;
            int num;
            double average;
            double total = 0;
            string inString;
            Console.Write("Please enter a number or " +
               QUIT + " to quit...");
            inString = ReadLine();
            //Convert.ToInt32
            num = Convert.ToInt32(inString);
            // num != QUIT or it would will be an endless loop in the while
            while ((x < numbers.Length) && num != QUIT)
            {
                numbers[x] = num;
                total += numbers[x];
                ++x;
                Write("Please enter a number or " +
                   QUIT + " to quit...");
                //ReadLine()
                inString = ReadLine();
                num = Convert.ToInt32(inString);
            }
            WriteLine("The numbers are:");
            //++y not ++x or it will endlessly write the frist int in the array
            for (int y = 0; y < x; ++y)
                Console.Write("{0,6}", numbers[y]);
            //there is no z so x
            average = total / x;
            WriteLine();
            //average not avge also close the WriteLine with )
            WriteLine("The average is {0}", average);
        }
    }
}
