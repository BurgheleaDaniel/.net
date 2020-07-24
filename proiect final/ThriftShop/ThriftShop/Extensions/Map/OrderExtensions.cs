using ThriftShop.DataAccess.Entities;
using ThriftShop.DataAccess.Models;

namespace ThriftShop.Extensions.Map
{
	public static class OrderExtensions
	{
		public static Order MapAsNewEntity(this CreateOrderRequestModel model)
		{
			return new Order
			{
				Total = model.Total,
				Customer = model.Customer,
				Products = model.Products
			};
		}

		public static OrderModel MapAsModel(this Order model)
		{
			return new OrderModel
			{
				Total = model.Total,
				Customer = model.Customer,
				Products = model.Products,
				Id = model.Id
			};
		}
	}
}
