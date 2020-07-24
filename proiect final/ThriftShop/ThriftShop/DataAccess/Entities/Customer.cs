using System;

namespace ThriftShop.DataAccess.Entities
{
	public class Customer
	{
		public int Id { get; set; }

		public String Name { get; set; }

		public String City { get; set; }
		
		public String Address { get; set; }
	}
}