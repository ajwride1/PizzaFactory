using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using Newtonsoft.Json;

namespace PizzaFactory.Pizza
{
    public abstract class Base : ICookable, IDisposable
    {
        public string Name { get; set; }
        public List<Topping> Toppings { get; set; }

        protected double _CookingMultiplyer;

        private bool _Disposed;

        public Base(string name, List<Topping> toppings)
        {
            _Disposed = false;
            Name = name;
            Toppings = toppings;
        }

        protected abstract void _SetCookingMultiplyer();

        public void Cook()
        {
            if(_Disposed)
                throw new InvalidOperationException("This pizza has already been cooked, you can't double cook it!");

            if(Toppings == null || !Toppings.Any())
                throw new InvalidOperationException("You can't cook a pizza without any toppings... that's just odd...");

            _SetCookingMultiplyer();

            int cookingTime = (int) CookingTime();

            Console.WriteLine($"Please wait {cookingTime / 1000} seconds for your {Name} pizza...");

            Console.WriteLine(DateTime.Now.ToString("yyyy MMM dddd HH:mm:ss fff"));
            Thread.Sleep(cookingTime);
            Console.WriteLine(DateTime.Now.ToString("yyyy MMM dddd HH:mm:ss fff"));

            Console.WriteLine($"Your {Name} pizza is cooked with toppings : {JsonConvert.SerializeObject(Toppings, Formatting.Indented)}");
            Dispose();
        }

        public double CookingTime()
        {
            double baseCookingTime = DAL.Get.BaseCookingTime();
            double toppingCookingTime = Toppings.Sum(t => t.CookingTime());

            double calculatedCookingTime = (baseCookingTime * _CookingMultiplyer) + toppingCookingTime;

            return calculatedCookingTime;
        }

        public void Dispose()
        {
            Toppings = null;
            _Disposed = true;
        }
    }
}
