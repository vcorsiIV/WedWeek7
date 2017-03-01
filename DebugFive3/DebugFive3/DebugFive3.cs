// Program displays every possible ID number for a company
// ID number is a letter, followed by a two-digit number
// For example -- A00 or Z99
// Go to a new display line after every 20 IDs
using static System.Console;

namespace DebugFive3
{
    class DebugFive3
    {
        static void Main()
        {
            char letter;
            int number;
            const int LOW = 0;
            const int HIGH = 99;
            const int NUMINROW = 20;

            for (letter = 'A'; letter <= 'Z'; ++letter)
            {
                //Change so number is <=HIGH so it runs else it would not run as 0 is not greater the 99
                //<= because 99 is a valid number as well.
                for(number=LOW; number<=HIGH; number++)
                {
                    //NUMINROW0 does not exist so it has to be NUMINROW == 0
                    if (number % NUMINROW == 0)
                        WriteLine();
                    //Got rid of the extra { in {{1}
                    Write("{0}{1} ", letter, number.ToString("D2"));
                }
            }
        }
    }
}
