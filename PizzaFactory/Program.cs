using System;
using System.Collections.Generic;
using PizzaFactory.Pizza;

namespace PizzaFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the pizza factory... give us a second, just getting a few things set up...");

            List<DAL.DTO.Topping> toppingDtos = DAL.Get.Toppings();
            List<Base> pizzas = new List<Base>();
            int requiredPizzas = DAL.Get.RequiredPizzas();

            Console.WriteLine("Let's start cooking some pizzas!!");

            Console.WriteLine(_LineBreak);

            while (pizzas.Count < requiredPizzas)
            {
                // while loop until the number of pizzas that are required have been cooked
                // get a random pizza and cook it
            }

            Console.WriteLine(_LineBreak);

            Console.WriteLine("That's it, your pizzas are all cooked, time for me to say goodbye!");
        }

        private static string _LineBreak = "==================================================";
    }
}
