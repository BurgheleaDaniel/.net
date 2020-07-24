using System.Collections.Generic;

namespace ThriftShop.DataAccess.Entities
{
	public class Order
	{
		public int Id { get; set; }

		public double Total { get; set; }

		public Customer Customer { get; set; }

		public IList<Product> Products { get; set; }
	}
}
