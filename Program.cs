using System;

namespace ConsoleX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User, Welcome to ConsoleX.");
            Console.WriteLine("This is the main meny where you may choose ");
            Console.WriteLine("one of the options from 0 - 2.");
            MainMeny();



            // Print out all the options for user.
            //Console.ReadLine();

        }
        public static void MainMeny()
        {
            Console.WriteLine("0_Switch");
            Console.WriteLine("1_Indefinit Loop");
            Console.WriteLine("2_Menu");
        }

    }
}
