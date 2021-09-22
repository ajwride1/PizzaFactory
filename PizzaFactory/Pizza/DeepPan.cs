using System.Collections.Generic;

namespace PizzaFactory.Pizza
{
    public class DeepPan : Base
    {
        public DeepPan(List<DAL.DTO.Topping> toppings) : base("DeepPan", toppings) { }

        protected override void _SetCookingMultiplyer()
        {
            _CookingMultiplyer = 2;
        }
    }
}
