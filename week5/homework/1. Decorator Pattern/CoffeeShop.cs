namespace Decorator
{
    using System;

    public static class CoffeeShop
    {
        public static void Main()
        {
            var coffee = new Coffee("Filtered");
            coffee.Prepare();


            Console.WriteLine("Making coffee with Milk and Chocolate");
            var customizableDrink = new CustomizableDrink(coffee);

            Milk milk = new Milk();
            Chocolate chocolate = new Chocolate();

            customizableDrink.AddExtraIngredient(milk);
            customizableDrink.AddExtraIngredient(chocolate);
            customizableDrink.Prepare();


            Console.WriteLine("Making coffee with Milk");
            var customizableDrink = new CustomizableDrink(coffee);
            customizableDrink.AddExtraIngredient(milk);
            customizableDrink.Prepare();

        }
    }
}
