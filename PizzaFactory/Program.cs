using System;
using System.Collections.Generic;
using System.Linq;
using PizzaFactory.Pizza;
using ToppingDTO = PizzaFactory.DAL.DTO.Topping;

namespace PizzaFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the pizza factory... give us a second, just getting a few things set up...");

            List<ToppingDTO> allPotentialToppings = DAL.Get.Toppings();
            List<Base> pizzas = new List<Base>();
            int requiredPizzas = DAL.Get.RequiredPizzas();
            int maxPotentialToppings = DAL.Get.MaxPotentialToppings();

            Console.WriteLine("Let's start cooking some pizzas!!");

            Console.WriteLine(_LineBreak);

            while (pizzas.Count < requiredPizzas)
            {
                Base randomPizza = _RandomPizza(allPotentialToppings, maxPotentialToppings);

                randomPizza.Cook();

                pizzas.Add(randomPizza);
            }

            Console.WriteLine(_LineBreak);

            Console.WriteLine("That's it, your pizzas are all cooked, time for me to say goodbye!");
        }

        private static string _LineBreak = "==================================================";

        private static Base _RandomPizza(List<ToppingDTO> potentialToppings, int maxToppingCount)
        {
            Random rnd = new Random();

            int toppingCount = rnd.Next(maxToppingCount);

            List<ToppingDTO> randomToppings = new List<ToppingDTO>();

            while(randomToppings.Count <= toppingCount)
            {
                int randomToppingSelection = rnd.Next(potentialToppings.Count);

                randomToppings.Add(potentialToppings[randomToppingSelection]);
            }

            List<string> allPizzaTypeNames = Factory.AllPizzaTypeNames();

            int randomPizzaIndex = rnd.Next(allPizzaTypeNames.Count());

            return Factory.GetPizza(allPizzaTypeNames[randomPizzaIndex], randomToppings);
        }
    }
}
