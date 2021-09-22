using System;
using System.Collections.Generic;

namespace PizzaFactory.Pizza
{
    public static class Factory
    {
        public static Base GetPizza(string name, List<DAL.DTO.Topping> toppingDtos)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new InvalidCastException("You haven't given a name for the type of pizza you want, please select a valid pizza type");

            switch (name.Trim().ToUpper())
            {
                case "DEEPPAN":
                    return new DeepPan(toppingDtos);
                case "DEEP PAN":
                    return new DeepPan(toppingDtos);
                case "STUFFEDCRUST":
                    return new StuffedCrust(toppingDtos);
                case "STUFFED CRUST":
                    return new StuffedCrust(toppingDtos);
                case "THINANDCRISPY":
                    return new ThinAndCrispy(toppingDtos);
                case "THIN AND CRISPY":
                    return new ThinAndCrispy(toppingDtos);
                default:
                    throw new InvalidCastException($"The pizza type you have requested {name} does not exist in this factory unfortunately, please select a valid pizza type");
            }
        }
    }
}
