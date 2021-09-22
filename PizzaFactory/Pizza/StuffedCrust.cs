using System.Collections.Generic;

namespace PizzaFactory.Pizza
{
    public class StuffedCrust : Base
    {
        public StuffedCrust(List<Topping> toppings) : base("Stuffed Crust", toppings) { }

        protected override void _SetCookingMultiplyer()
        {
            _CookingMultiplyer = 1.5;
        }
    }
}
