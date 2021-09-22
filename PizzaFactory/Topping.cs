using Extensions;

namespace PizzaFactory
{
    public class Topping
    {
        public string Name { get; set; }

        public double CookingTime()
        {
            return Name.RemoveSpaces().Length * DAL.Get.ToppingCookingTime();
        }
    }
}
