﻿using System;

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


            }
            else if (!(Int32.TryParse(userInput, out age)))
            {
                Console.WriteLine("You need to enter digits.");
            }

            //Run a ticket validation.
            //Print out the valid ticket.

        }
        private static void TheRepeater()
        {
            int index = 1;


            Console.Clear();
            Console.WriteLine("Welcome, please typ one word and hit enter, the word will repeat it self 10 times.");
            string word = Console.ReadLine();
            Console.Clear();

            for (int count = 0; count < 10; count++)
            {
                Console.Write(index + ": " + word + ", ");
                index++;
            }
        }
        private static void TheThirdWord()
        {
            Console.Clear();
            Console.WriteLine("Enter a sentence with at LEAST three words.");
            string sentence = Console.ReadLine();
        }

        public static void MainMeny()
        {
            Console.WriteLine("1: Ungdom eller pensionär");
            Console.WriteLine("2: Uppreparen");
            Console.WriteLine("3: Det tredje ordet");
        }

        //Not able to create a AgeCheck method.
        //public static int AgeCheck(age)
        //{
        //   return ;
        //}

    }
}
