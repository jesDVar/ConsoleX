using System;

namespace ConsoleX
{
    class Program
    {
        static void Main(string[] args)
        {
            //SplashScreen splashScreen = new();

            SplashScreen.ShowScreen();

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
                case "4":
                    GroupTickets();
                    break;
            }
        }



        public static void YouthOrPensioner()
        {

            int age;

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
                int price = GetPrice(age);
                Console.WriteLine($"Price: {price}");

            }
            else if (!(Int32.TryParse(userInput, out age)) || age < 0)
            {
                Console.WriteLine("You need to enter positive digits.");
            }


            //Run a ticket validation.
            //Print out the valid ticket.

        }

        private static void GroupTickets()
        {
            int totalPrice = 0;
            //clear screen
            Console.Clear();

            //Info, user enters their age to see what kind of a ticket they qualify for.
            Console.WriteLine("Group Tickets!");
            Console.WriteLine("Enter number of visitors");

            string numberOfVisitors = Console.ReadLine();

            for (int i = 0; i < int.Parse(numberOfVisitors); i++)
            {
                Console.WriteLine($"Enter age of visitor nr {i + 1}");
                string age = Console.ReadLine();
                totalPrice = totalPrice + GetPrice(int.Parse(age));
            }

            Console.WriteLine($"Total cost for the group: {totalPrice} kr");
        }

        private static int GetPrice(int age)
        {


            if (age < 20)
            {
                return 80;
            }
            else if (age < 64)
            {
                return 120;
            }
            else
            {
                return 90;
            }



        }

        private static void TheRepeater()
        {
            int index = 1;


            Console.Clear();
            Console.WriteLine("Welcome, please typ one word and hit enter, the word will repeat it self 10 times.");
            string word = Console.ReadLine();
            Console.Clear();

            for (int count = 1; count < 11; count++)
            {
                Console.Write(count + ": " + word + ", ");

            }
        }
        private static void TheThirdWord()
        {
            Console.Clear();
            Console.WriteLine("Enter a sentence with at LEAST three words.");
            string sentence = Console.ReadLine();
            var splitSentence = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //  "           hej             jag           heter   David        " => ["hej","jag","heter","david"]
            Console.WriteLine($"The third word is: {splitSentence[2]}");
            var splitSentenceLength = splitSentence.Length;

        }
        //david-nokto
        public static void MainMeny()
        {
            Console.WriteLine("1: Ungdom eller pensionär");
            Console.WriteLine("2: Uppreparen");
            Console.WriteLine("3: Det tredje ordet");
            Console.WriteLine("4: Grupp Bio Besök");
        }

        //Not able to create a AgeCheck method.
        //public static int AgeCheck(age)
        //{
        //   return ;
        //}

    }
}
