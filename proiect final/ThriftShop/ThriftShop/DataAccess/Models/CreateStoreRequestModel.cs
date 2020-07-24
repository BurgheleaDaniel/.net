using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ThriftShop.DataAccess.Entities;

namespace ThriftShop.DataAccess.Models
{
	public class CreateStoreRequestModel
	{
		[Required] public String Name { get; set; }

		[Required] public String Branch { get; set; }

		[Required] public String Address { get; set; }

		[Required] public IList<Employee> Employees { get; set; }
	}
}
