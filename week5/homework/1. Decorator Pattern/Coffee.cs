namespace Decorator
{
    internal class Coffee : Drink
    {
        private readonly string Type;

        public Coffee(string type)
        {
            this.type = type;
        }

        public override void Prepare()
        {
            // preparing coffee
            //
        }
    }
}
