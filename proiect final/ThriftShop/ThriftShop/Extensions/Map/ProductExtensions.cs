using ThriftShop.DataAccess.Entities;
using ThriftShop.DataAccess.Models;

namespace ThriftShop.Extensions.Map
{
	public static class ProductExtensions
	{
		public static Product MapAsNewEntity(this CreateProductRequestModel model)
		{
			return new Product
			{
				Name = model.Name,
				Description = model.Description
			};
		}

		public static ProductModel MapAsModel(this Product model)
		{
			return new ProductModel
			{
				Name = model.Name,
				Description = model.Description,
				Id = model.Id
			};
		}
	}
}
