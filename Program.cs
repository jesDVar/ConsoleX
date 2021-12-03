using System;

namespace ConsoleX
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello User, Welcome to ConsoleX.");
            Console.WriteLine("This is the main meny where you may choose ");
            Console.WriteLine("one of the menus from 1 - 3.");

            MainMeny();

            var input = Console.ReadLine();
            switch (input) 
            {
                case "1":
                    MenuOne();
                    break;
                case "2":
                    MenuTwo();
                    break;
                case "3":
                    MenuThree();
                    break;
            }
        }
        private static void MenuOne()
        {
            throw new NotImplementedException();
        }
        private static void MenuTwo()
        {
            throw new NotImplementedException();
        }
        private static void MenuThree()
        {
            throw new NotImplementedException();
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
