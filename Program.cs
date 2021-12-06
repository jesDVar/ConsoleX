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
            int age;


            //clear screen
            Console.Clear();

            //Info, user enters their age to see what kind of a ticket they qualify for.
            Console.WriteLine("Youth or pensioner.");
            Console.WriteLine("Enter your age in numbers to recive your ticket");
            
            //Instructions: Enter age.
            string userInput = Console.ReadLine();

            //Try if user input is int with TryParse and if so convert it to int.
            if ((Int32.TryParse(userInput, out age)) && (age <= 110) && (age > 0))
            {
                Console.WriteLine("Your age is " + age);
                //Run a check to see what kind of ticket to give.


            }
            else if (!(Int32.TryParse(userInput, out age)))
            {
                Console.WriteLine("You need to enter digits.");

            }
            //Print out the valid ticket.
        }
        private static void TheRepeater()
        {
            //clear screen
            Console.Clear();
            //Instructions
            Console.WriteLine("Welcome, please typ one word and hit enter.");
            string word = Console.ReadLine();
            int count = 0;
            Console.Clear();

            while (count < 10)
            {
                Console.WriteLine(word);
                count++;
            }
        }
        private static void TheThirdWord()
        {
            //clear screen
            Console.Clear();
            //Instructions
            Console.WriteLine("Function not available for the moment");
        }

        public static void MainMeny()
        {
            Console.WriteLine("1: Ungdom eller pensionär");
            Console.WriteLine("2: Uppreparen");
            Console.WriteLine("Menu 3");
        }
        //Not able to create a AgeCheck method.
        //public static int AgeCheck()
        //{
        //   Console.WriteLine(age);
        //}
        private static void UserInput()
        { 
        }

    }
}
