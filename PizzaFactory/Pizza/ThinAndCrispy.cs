namespace PizzaFactory.Pizza
{
    public class ThinAndCrispy : Base
    {
        public ThinAndCrispy():base("Thin and Crispy") { }

        protected override void _SetCookingMultiplyer()
        {
            _CookingMultiplyer = 1;
        }
    }
}
