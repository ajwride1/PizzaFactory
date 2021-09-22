using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace PizzaFactory.DAL
{
    public static class Get
    {
        private static Config _Config;

        private static string _ConfigFilePath()
        {
            return @"C:\Scratch\PizzaFactoryConfig.json";
        }

        private static void _SetConfig()
        {
            if (_Config == null)
            {
                string configFilePath = _ConfigFilePath();

                if(!File.Exists(configFilePath))
                    throw new MissingMemberException($"Missing the config file : {configFilePath}. Please create a valid config file in this location to continue");

                string rawFileDetail = File.ReadAllText(configFilePath);

                _Config = JsonConvert.DeserializeObject<Config>(rawFileDetail);
            }
        }

        public static double BaseCookingTime()
        {
            _SetConfig();

            return _Config.BaseCookingTime;
        }

        public static double CookingInterval()
        {
            _SetConfig();

            return _Config.CookingInterval;
        }

        public static double ToppingCookingTime()
        {
            _SetConfig();

            return _Config.ToppingCookingTime;
        }

        public static List<DTO.Topping> Toppings()
        {
            _SetConfig();

            return _Config.Toppings;
        }

        public static int RequiredPizzas()
        {
            _SetConfig();

            return _Config.RequiredPizzas;
        }
    }
}
