using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace PizzaFactory.Pizza
{
    public static class Factory
    {
        public static Base GetPizza(string name, List<DAL.DTO.Topping> toppingDtos)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new InvalidCastException("You haven't given a name for the type of pizza you want, please select a valid pizza type");

            string tidiedName = name.Trim().ToUpper();

            List<Type> allPizzaTypes = AllPizzaTypes();
            List<string> allPizzaTypeNames = AllPizzaTypeNames();

            if(!allPizzaTypeNames.Any(n => n == tidiedName))
                throw new InvalidCastException($"The pizza type you have requested {name} does not exist in this factory unfortunately, please select a valid pizza type");

            Type selectedPizzaType = allPizzaTypes.First(t => t.Name.Trim().ToUpper() == tidiedName);

            Base pizza = (Base)Activator.CreateInstance(selectedPizzaType, toppingDtos);

            return pizza;
        }

        public static List<Type> AllPizzaTypes()
        {
            return typeof(Base)
                .Assembly.GetTypes()
                .Where(t => t.IsSubclassOf(typeof(Base)) && !t.IsAbstract)
                .Select(t => t)
                .ToList();
        }

        public static List<string> AllPizzaTypeNames()
        {
            return AllPizzaTypes()
                .Select(t => t.Name.Trim().ToUpper())
                .ToList();
        }
    }
}
