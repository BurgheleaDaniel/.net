namespace OpenClosedShoppingCartBefore
{
	public class OrderItemEach : OrderItem
	{
		public double CalculateTotalAmount()
		{
			return Quantity * 5m;
		}
	}
}