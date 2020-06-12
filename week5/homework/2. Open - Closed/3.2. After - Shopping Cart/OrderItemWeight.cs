namespace OpenClosedShoppingCartBefore
{
	public class OrderItemWeight : OrderItem
	{
		public double CalculateTotalAmount()
		{
			return Quantity * 4m / 1000;
		}
	}
}