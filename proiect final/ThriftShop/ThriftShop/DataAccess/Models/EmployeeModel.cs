using System;
using System.ComponentModel.DataAnnotations;

namespace ThriftShop.DataAccess.Models
{
	public class EmployeeModel
	{
		public int Id { get; set; }

		[Required] public String Name { get; set; }

		[Required] public Double Paycheck { get; set; }
	}
}
