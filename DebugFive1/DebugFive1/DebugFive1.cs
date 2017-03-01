// Program asks user to enter password
// If password is not "home", "lady" or "mouse"
// the user must re-enter the password
using static System.Console;

namespace DebugFive1
{
    class DebugFive1
    {
        static void Main(string[] args)
        {
            const string PASS1 = "home";
            const string PASS2 = "lady";
            const string PASS3 = "mouse";
            string password;

            Write("Please enter your password ");
            //Console.ReadLine() is not needed, just ReadLine()
            password = ReadLine();
            //Need {} for the while loop so that it can ask the user to input again.
            //Also change the Logical OR to have the NOT outside the conditions as the input will not match two of the three correct passwords
            while (!(password == PASS1 || password == PASS2 || password == PASS3))
            {
                WriteLine("Invalid password. Please enter again. ");
                password = ReadLine();
            }
            WriteLine("Valid password");
        }
    }
}
