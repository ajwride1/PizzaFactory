using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace PizzaFactory.Tests.DAL
{
    [TestClass]
    public class Get
    {
        [TestMethod]
        public void BaseCookingTime()
        {
            double? baseCookingTime = PizzaFactory.DAL.Get.BaseCookingTime();

            Console.WriteLine(baseCookingTime);

            Assert.IsTrue(baseCookingTime != null);
        }

        [TestMethod]
        public void CookingInterval()
        {
            double? cookingInterval = PizzaFactory.DAL.Get.CookingInterval();

            Console.WriteLine(cookingInterval);

            Assert.IsTrue(cookingInterval != null);
        }

        [TestMethod]
        public void ToppingCookingTime()
        {
            double? toppingCookingTime = PizzaFactory.DAL.Get.ToppingCookingTime();

            Console.WriteLine(toppingCookingTime);

            Assert.IsTrue(toppingCookingTime != null);
        }

        [TestMethod]
        public void Toppings()
        {
            List<PizzaFactory.DAL.DTO.Topping> toppings = PizzaFactory.DAL.Get.Toppings();

            Console.WriteLine(JsonConvert.SerializeObject(toppings, Formatting.Indented));

            Assert.IsTrue(toppings != null);
        }

        [TestMethod]
        public void RequiredPizzas()
        {
            int? requiredPizzas = PizzaFactory.DAL.Get.RequiredPizzas();

            Console.WriteLine(requiredPizzas);

            Assert.IsTrue(requiredPizzas != null);
        }

        [TestMethod]
        public void MaxPotentialToppings()
        {
            int? maxPotentialToppings = PizzaFactory.DAL.Get.MaxPotentialToppings();

            Console.WriteLine(maxPotentialToppings);

            Assert.IsTrue(maxPotentialToppings != null);
        }
    }
}
