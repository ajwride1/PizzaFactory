using System.Collections.Generic;

namespace PizzaFactory.DAL
{
    public class Config
    {
        public double BaseCookingTime { get; set; }
        public double CookingInterval { get; set; }
        public int RequiredPizzas { get; set; }
        public double ToppingCookingTime { get; set; }
        public int MaxPotentialToppings { get; set; }
        public List<DTO.Topping> Toppings { get; set; }
    }
}
