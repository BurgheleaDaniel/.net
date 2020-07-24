using System;
using System.ComponentModel.DataAnnotations;

namespace ThriftShop.DataAccess.Models
{
	public class CreateEmployeeRequestModel
	{
		[Required] public String Name { get; set; }

		[Required] public Double Paycheck { get; set; }
	}
}
