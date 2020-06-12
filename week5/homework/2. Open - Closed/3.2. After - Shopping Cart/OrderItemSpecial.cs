namespace OpenClosedShoppingCartBefore
{
	public class OrderItemSpecial : OrderItem
	{
		public double CalculateTotalAmount()
		{
			double subTotal = Quantity * .4m;
			int setsOfThree = Quantity / 3;
			subTotal -= setsOfThree * .2m;

			return subTotal;
		}
	}
}