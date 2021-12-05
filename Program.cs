using System;

namespace ConsoleX
{
    class Program
    {

        static void Main(string[] args)
        {
            // Greeting screen passing information about the options.
            Console.WriteLine("Hello User, Welcome to ConsoleX.");
            Console.WriteLine("This is the Main Meny where You may choose ");
            Console.WriteLine("one of the three options 1 to 3.");
            Console.WriteLine(" ");
            Console.WriteLine("Make your choice And press Enter");
            Console.WriteLine(" ");            

            MainMeny();
            Console.WriteLine(" ");

            var input = Console.ReadLine();
            switch (input) 
            {
                case "1":
                    YouthOrPensioner();
                    break;
                case "2":
                    TheRepeater();
                    break;
                case "3":
                    TheThirdWord();
                    break;
            }
        }
        private static void YouthOrPensioner()
        {
            //clear screen
            Console.Clear();
            Console.WriteLine("Youth or pensioner.");
            Console.WriteLine("Enter your age in numbers to recive your ticket");
            //Instructions: User enters string to confirm their age.
            string age = Console.ReadLine();
            //Recive string and convert it to int.
            //agera på svar
        }
        private static void TheRepeater()
        {
            //clear screen
            Console.Clear();
            //Instructions
            Console.WriteLine("Welcome");
        }
        private static void TheThirdWord()
        {
            //clear screen
            Console.Clear();
            //Instructions
            Console.WriteLine("Welcome");
        }

        public static void MainMeny()
        {
            Console.WriteLine("Menu 1");
            Console.WriteLine("Menu 2");
            Console.WriteLine("Menu 3");
        }
        private static void UserInput()
        { 
        }

    }
}
