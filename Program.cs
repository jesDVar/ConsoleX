using System;

namespace ConsoleX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User, Welcome to ConsoleX.");
            Console.WriteLine("This is the main meny where you may choose ");
            Console.WriteLine("one of the menus from 1 - 2.");
            MainMeny();
            



            // Print out all the options for user.
            //Console.ReadLine();

        }
        public static void MainMeny()
        {
            Console.WriteLine("Menu 1");
            Console.WriteLine("Menu 2");
        }

        private static void UserInput()
        { 
        }

    }
}
