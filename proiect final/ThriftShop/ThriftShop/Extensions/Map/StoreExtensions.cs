using ThriftShop.DataAccess.Entities;
using ThriftShop.DataAccess.Models;

namespace ThriftShop.Extensions.Map
{
	public static class StoreExtensions
	{
		public static Store MapAsNewEntity(this CreateStoreRequestModel model)
		{
			return new Store
			{
				Name = model.Name,
				Branch = model.Branch,
				Address = model.Address,
				Employees = model.Employees
			};
		}

		public static StoreModel MapAsModel(this Store model)
		{
			return new StoreModel
			{
				Name = model.Name,
				Branch = model.Branch,
				Address = model.Address,
				Employees = model.Employees,
				Id = model.Id
			};
		}
	}
}
