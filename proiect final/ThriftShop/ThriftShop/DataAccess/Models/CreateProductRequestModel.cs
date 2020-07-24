using System.ComponentModel.DataAnnotations;

namespace ThriftShop.DataAccess.Models
{
	public class CreateProductRequestModel
	{
		[Required] public string Name { get; set; }

		public string Description { get; set; }
	}
}
