using ThriftShop.DataAccess.Entities;
using ThriftShop.DataAccess.Models;

namespace ThriftShop.Extensions.Map
{
	public static class CustomerExtensions
	{
		public static Customer MapAsNewEntity(this CreateCustomerRequestModel model)
		{
			return new Customer
			{
				Name = model.Name,
				City = model.City,
				Address = model.Address
			};
		}

		public static CustomerModel MapAsModel(this Customer model)
		{
			return new CustomerModel
			{
				Name = model.Name,
				City = model.City,
				Address = model.Address
			};
		}
	}
}
