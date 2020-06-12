namespace Decorator
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The 'ConcreteDecorator' class
    /// </summary>
    internal class CustomizableDrink : Decorator
    {
        private readonly List<IIngedient> extraIngredients = new List<string>();

        public CustomizableDrink(Drink drink)
            : base(drink)
        {
        }

        public void AddExtraIngredient(IIngedient name)
        {
            this.extraIngredients.Add(name);
        }


        public override void Prepare()
        {
            base.Prepare();

            foreach (var extraIngredient in this.extraIngredients)
            {
                // add extra extraIngredient
            }
        }
    }
}
