namespace PizzaFactory.Pizza
{
    public class StuffedCrust : Base
    {
        public StuffedCrust() : base("Stuffed Crust") { }

        protected override void _SetCookingMultiplyer()
        {
            _CookingMultiplyer = 1.5;
        }
    }
}
