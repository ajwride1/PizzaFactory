using System.Collections.Generic;

namespace PizzaFactory.Pizza
{
    public class ThinAndCrispy : Base
    {
        public ThinAndCrispy(List<Topping> toppings):base("Thin and Crispy", toppings) { }

        protected override void _SetCookingMultiplyer()
        {
            _CookingMultiplyer = 1;
        }
    }
}
