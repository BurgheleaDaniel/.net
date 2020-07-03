namespace ThriftShop.DataAccess
{
	using Microsoft.EntityFrameworkCore;
	using ThriftShop.DataAccess.Entities;

	public class ApiDbContext : DbContext
	{
		public ApiDbContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Product> Products { get; set; }

	}
}
