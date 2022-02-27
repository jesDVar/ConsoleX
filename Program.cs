using System;

namespace ConsoleX
{
    class Program
    {
        static void Main(string[] args)
        {

            bool running = true;
            while (running)
            {
                Console.Clear();
                ShowScreen();
                MainMeny();
                UserOptions();

            }
            running = false;
        }

        private static void UserOptions()
        {
            var input = Console.ReadLine();
            switch (input)
            {
                case "0":
                    Environment.Exit(0);
                    break;
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

        private static void ShowScreen()
        {
            Console.WriteLine("Choose one of the five options 0 to 4.");
            Console.WriteLine(" ");
            Console.WriteLine("Make your choice And press Enter");
            Console.WriteLine(" ");
        }
        public static void YouthOrPensioner()
        {
            int age;

            Console.Clear();

            //Info, user enters their age to see what kind of a ticket they qualify for.
            Console.WriteLine("Youth or pensioner.");
            Console.WriteLine("Enter your age in numbers to recive your ticket");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Youth: Age under 20");
            Console.WriteLine("Standard: Age between 20 and 64");
            Console.WriteLine("Pensioner: Age 64+");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Price List");
            Console.WriteLine("");
            Console.WriteLine("Price for Youth: 80:- ");
            Console.WriteLine("Price for Standard: 120:- ");
            Console.WriteLine("Price for Pensioner: 90:- ");
            //Console.WriteLine("Price for youth: 80:- ");


            //Instructions: Enter age.
            Console.WriteLine("\nEnter your age");
            string userInput = Console.ReadLine();

            /*
             *             
             * 3. Programmet ser om personen är ungdom ( under 20 år)
4. Om det ovanstående är sant skall programmet skriva ut: Ungdomspris: 80kr
5. Annars kollar programmet om personen är en pensionär ( över 64 år)
6. Om ovanstående är sant skall programmet skruva ut: Pensionärspris: 90kr
7. Annars skall programmet skriva ut: Standardpris: 120kr
Vi vill även få möjlighet att kunna räkna ut priset för ett helt sällskap. Lägg till det
alternativet i huvudmenyn.
Vi anger då först hur många vi är som ska gå på bio. Frågar sedan efter ålder på var och en
och skriver sedan ut en sammanfattning i konsolen som ska innehålla följande:
● Antal personer
● Samt totalkostnad för hela sällskapet
             * 
             * 
             */






            //Try if user input is int with TryParse and if so convert it to int.
            if ((Int32.TryParse(userInput, out age)) && (age <= 110) && (age > 0))
            {
                Console.Clear();
                Console.WriteLine("Your age is " + age);
                //Run a check to see what kind of ticket to give.
                int price = GetPrice(age);
                Console.WriteLine($"Price: {price}");
                Console.WriteLine("\nPress Enter to continue");
                Console.ReadLine();

            }
            else if (!(Int32.TryParse(userInput, out age)) || age < 0)
            {
                Console.Clear();
                Console.WriteLine("You need to enter positive digits.");
                Console.WriteLine("\nPress Enter to continue");
                Console.ReadLine();
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
            else if (age <= 64)
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
                Console.WriteLine("\n");
                Console.Write(count + ": " + word);

            }
            Console.WriteLine("\n Press enter to return to home screen.");
            Console.ReadLine();

        }
        private static void TheThirdWord()
        {
            Console.Clear();
            Console.WriteLine("Enter a sentence with at LEAST three words.");
            string sentence = Console.ReadLine();
            var splitSentence = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"The third word is: {splitSentence[2]}");
            //var splitSentenceLength = splitSentence.Length;

            Console.WriteLine("Press enter to return to home screen.");
            Console.ReadLine();

        }
        public static void MainMeny()
        {
            Console.WriteLine("0: Avsluta");
            Console.WriteLine("1: Ungdom eller pensionär");
            Console.WriteLine("2: Uppreparen");
            Console.WriteLine("3: Det tredje ordet");
            Console.WriteLine("4: Bio Besök");
        }

        //Not able to create a AgeCheck method.
        //public static int AgeCheck(age)
        //{
        //   return ;
        //}

    }
}
