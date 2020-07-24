using System;
using System.ComponentModel.DataAnnotations;

namespace ThriftShop.DataAccess.Models
{
	public class CustomerModel
	{
		public int Id { get; set; }

		[Required] public String Name { get; set; }

		[Required] public String City { get; set; }

		[Required] public String Address { get; set; }
	}
}
