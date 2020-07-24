using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ThriftShop.DataAccess.Entities;

namespace ThriftShop.DataAccess.Models
{
	public class CreateOrderRequestModel
	{
		[Required] public double Total { get; set; }

		[Required] public Customer Customer { get; set; }

		[Required] public IList<Product> Products { get; set; }

	}
}
