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

		public DbSet<Order> Orders { get; set; }

		public DbSet<Customer> Customers { get; set; }

		public DbSet<Employee> Employees { get; set; }

		public DbSet<Store> Stores { get; set; }
	}
}
