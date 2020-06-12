namespace Decorator
{
    /// <summary>
    /// The 'Component' abstract class
    /// </summary>
    internal abstract class Drink
    {
        public int Type { get; set; }

        public abstract void Prepare();
    }
}
