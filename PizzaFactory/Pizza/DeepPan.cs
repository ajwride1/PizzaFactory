namespace PizzaFactory.Pizza
{
    public class DeepPan : Base
    {
        public DeepPan() : base("DeepPan") { }

        protected override void _SetCookingMultiplyer()
        {
            _CookingMultiplyer = 2;
        }
    }
}
