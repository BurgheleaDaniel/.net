namespace Decorator
{
    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    internal abstract class Decorator : Drink
    {
        protected Decorator(Drink drink)
        {
            this.drink = drink;
        }

        protected Drink drink { get; private set; }

        public override void Prepare()
        {
            this.drink.Prepare();
        }
    }
}
