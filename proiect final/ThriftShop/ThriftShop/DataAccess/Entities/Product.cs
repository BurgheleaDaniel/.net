using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThriftShop.DataAccess.Entities
{
	public class Product
	{
		public int Id { get; set; }

		public String Name { get; set; }

		public String Description { get; set; }
	}
}
