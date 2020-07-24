using System;
using System.Collections.Generic;

namespace ThriftShop.DataAccess.Entities
{
	public class Store
	{
		public int Id { get; set; }

		public String Name { get; set; }

		public String Branch { get; set; }

		public String Address { get; set; }

		public IList<Employee> Employees { get; set; }
	}
}
