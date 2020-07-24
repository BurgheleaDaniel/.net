using ThriftShop.DataAccess.Entities;
using ThriftShop.DataAccess.Models;

namespace ThriftShop.Extensions.Map
{
	public static class EmployeeExtensions
	{
		public static Employee MapAsNewEntity(this CreateEmployeeRequestModel model)
		{
			return new Employee
			{
				Name = model.Name,
				Paycheck = model.Paycheck
			};
		}

		public static EmployeeModel MapAsModel(this Employee model)
		{
			return new EmployeeModel
			{
				Name = model.Name,
				Paycheck = model.Paycheck,
				Id = model.Id
			};
		}
	}
}
