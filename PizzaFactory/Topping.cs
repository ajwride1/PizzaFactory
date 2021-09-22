﻿using Extensions;

namespace PizzaFactory
{
    public class Topping : DAL.DTO.Topping
    {
        public Topping(string name)
        {
            Name = name;
        }

        public double CookingTime()
        {
            return Name.RemoveSpaces().Length * DAL.Get.ToppingCookingTime();
        }
    }
}
