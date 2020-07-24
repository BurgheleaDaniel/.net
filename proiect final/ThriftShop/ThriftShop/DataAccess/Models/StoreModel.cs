using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ThriftShop.DataAccess.Entities;

namespace ThriftShop.DataAccess.Models
{
	public class StoreModel
	{
		public int Id { get; set; }

		[Required] public String Name { get; set; }

		[Required] public String Branch { get; set; }

		[Required] public String Address { get; set; }

		[Required] public IList<Employee> Employees { get; set; }
	}
}
