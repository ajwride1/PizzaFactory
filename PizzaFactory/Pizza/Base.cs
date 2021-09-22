using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace PizzaFactory.Pizza
{
    public abstract class Base : ICookable, IDisposable
    {
        public string Name { get; set; }
        public List<Topping> Toppings { get; set; }

        protected double _CookingMultiplyer;

        private bool _Disposed;

        public Base(string name)
        {
            _Disposed = false;
            Name = name;
        }

        protected abstract void _SetCookingMultiplyer();

        public void Cook()
        {
            if(_Disposed)
                throw new InvalidOperationException("This pizza has already been cooked, you can't double cook it!");

            if(!Toppings.Any())
                throw new InvalidOperationException("You can't cook a pizza without any toppings... that's just odd...");

            _SetCookingMultiplyer();

            Thread.Sleep((int)CookingTime());

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
