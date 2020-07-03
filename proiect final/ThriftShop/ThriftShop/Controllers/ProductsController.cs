using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThriftShop.DataAccess;
using ThriftShop.DataAccess.Entities;

namespace ThriftShop.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ProductsController : ControllerBase
	{
		private readonly ApiDbContext context;

		public ProductsController(ApiDbContext context)
		{
			this.context = context;
		}

		// GET: api/products
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
		{
			return await this.context.Products.ToListAsync();
		}

		// POST: api/products
		[HttpPost]
		public async Task<ActionResult<Product>> PostProduct(Product product)
		{
			this.context.Products.Add(product);
			await this.context.SaveChangesAsync();

			return this.CreatedAtAction("GetProduct", new { id = product.Id }, product);
		}

	}
}
