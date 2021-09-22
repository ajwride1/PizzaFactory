using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaFactory.Pizza;

namespace PizzaFactory.Tests
{
    [TestClass]
    public class Pizza
    {
        private double _BaseCookingTime;
        private double _ToppingCookingTime;

        [TestInitialize]
        public void Initialize()
        {
            _BaseCookingTime = 1000;
            _ToppingCookingTime = 100;
        }

        [TestMethod]
        public void Cook()
        {
            List<PizzaFactory.DAL.DTO.Topping> toppings = new List<PizzaFactory.DAL.DTO.Topping>{new Topping("Test")};

            Base pizza = new DeepPan(toppings);

            pizza.Cook();

            try
            {
                pizza.Cook();
            }
            catch (InvalidOperationException e)
            {
                Assert.IsTrue(e.Message == "This pizza has already been cooked, you can't double cook it!");
            }
        }
    }
}
