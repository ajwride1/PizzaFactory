using System;

namespace PizzaFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the pizza factory... give us a second, just getting a few things set up...");

            // get a list of toppings from the config file

            Console.WriteLine("Let's start cooking some pizzas!!");

            Console.WriteLine(_LineBreak);
            // while loop until the number of pizzas that are required have been cooked
            // get a random pizza and cook it

            Console.WriteLine(_LineBreak);

            Console.WriteLine("That's it, your pizzas are all cooked, time for me to say goodbye!");
        }

        private static string _LineBreak = "==================================================";
    }
}
