using System;
using System.ComponentModel.DataAnnotations;

namespace ThriftShop.DataAccess.Models
{
	public class ProductModel
	{
		public int Id { get; set; }

		[Required] public String Name { get; set; }

		public String Description { get; set; }
	}
}
