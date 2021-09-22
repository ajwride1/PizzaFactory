using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using PizzaFactory.Pizza;
using Topping = PizzaFactory.DAL.DTO.Topping;

namespace PizzaFactory.Tests
{
    [TestClass]
    public class Factory
    {
        [TestMethod]
        public void AllPizzaTypes()
        {
            IEnumerable<Type> allPizzaTypes = PizzaFactory.Pizza.Factory.AllPizzaTypes();

            Console.WriteLine(JsonConvert.SerializeObject(allPizzaTypes, Formatting.Indented));

            Assert.IsTrue(allPizzaTypes != null);

            foreach (var pizzaType in allPizzaTypes)
            {
                Assert.IsTrue(pizzaType.IsSubclassOf(typeof(Base)));
            }
        }

        [TestMethod]
        public void AllPizzaTypeNames()
        {
            List<string> allPizzaTypeNames = PizzaFactory.Pizza.Factory.AllPizzaTypeNames();

            Console.WriteLine(JsonConvert.SerializeObject(allPizzaTypeNames, Formatting.Indented));

            Assert.IsTrue(allPizzaTypeNames != null);
            Assert.IsTrue(allPizzaTypeNames.Any());
        }

        [TestMethod]
        public void GetPizza()
        {
            Type firstPizzaType = PizzaFactory.Pizza.Factory.AllPizzaTypes().First();

            List<Topping> toppings = new List<Topping>{new Topping{ Name = "Test"}};

            Base pizza = PizzaFactory.Pizza.Factory.GetPizza(firstPizzaType.Name, toppings);

            Console.WriteLine(JsonConvert.SerializeObject(pizza, Formatting.Indented));

            Assert.IsTrue(pizza.GetType() == firstPizzaType);
        }
    }
}
