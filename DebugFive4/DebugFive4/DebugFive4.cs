// How much money will you have
// after 30 days if you get a penny on the
// first day and it doubles every day?
using System;
using static System.Console;

namespace DebugFive4
{
    class DebugFive4
    {
        static void Main()
        {
            const double LIMIT = 1000000.00;
            const double START = 0.01;
            string inputString;
            double total;
            int howMany;
            int count;
            Write("How many days do you think ");
            WriteLine("it will take you to reach");
            //ToString(C) -> ToString("C")
            //Got rid of the {{1} and replaced with {1}_ (the underscore is a space,
            //as it looks bad in the console) and added a } to {0
            Write("{0} starting with {1} ",
               LIMIT.ToString("C"), START.ToString("C"));
            WriteLine("and doubling it every day?");
            inputString = ReadLine();
            howMany = Convert.ToInt32(inputString);
            //count should start at 1 as on the first day it is doubled
            //and it the while loop exits before regestering the correct day
            //varified by checking https://www.bloomberg.com/news/videos/b/92966fc7-c54d-4405-8fa6-cbefd05bbd6f
            count = 1;
            total = START;
            //needs to be <= to LIMIT not == as it would skip
            while (total < LIMIT)
            {
                total = total * 2;
                count = count + 1;
            }
            // > not >=
            if (howMany > count)
                WriteLine("Your guess was too high.");

            //else if one line, and it is < not =<
            else if (howMany < count)
                WriteLine("Your guess was too low.");
            else
                WriteLine("Your guess was correct.");
            //add {} around 0 as it would not take 0 days
            WriteLine("It takes {0} days to reach {1}",
               count, LIMIT.ToString("C"));
            WriteLine("when you double {0} every day",
               START.ToString("C"));
        }
    }
}
