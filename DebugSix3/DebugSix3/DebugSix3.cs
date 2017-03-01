// Finds whether a book dealer carries a requested book
using System;
using static System.Console;

namespace DebugSix3
{
    class DebugSix3
    {
        static void Main()
        {
            String[] books = {"Catch-22", "Harry Potter",
         "Programming Using C#", "Rich Dad, Poor Dad",
         "The Deep", "Wizard of Oz"};
            int x;
            string entryString;
            Write("What book are you looking for? ");
            // .ReadLine
            entryString = Console.ReadLine();
            //BinarySearch need an object to compare to the array.
            x = Array.BinarySearch(books, entryString);
            if (x < 0)
                //entryString
                WriteLine("{0} not found", entryString);
            else
                //entryString
                WriteLine("Yes, we carry {0}", entryString);
        }
    }
}
