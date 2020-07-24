using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThriftShop.DataAccess;
using ThriftShop.DataAccess.Entities;
using ThriftShop.DataAccess.Models;
using ThriftShop.Extensions.Map;
using ThriftShop.Services;

namespace ThriftShop.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomersController : Controller
    {
		private readonly ApiDbContext context;
		private readonly INotificationService notificationService;

		public CustomersController(ApiDbContext context, INotificationService notificationService)
		{
			this.context = context;
			this.notificationService = notificationService;
		}

		// GET: api/customers/1
		[HttpGet("{id}")]
		public async Task<ActionResult<CustomerModel>> Get(int id)
		{
			if (id < 0)
			{
				throw new AccessViolationException("Negative id exception");
			}

			var entity = await this.context.Customers.FindAsync(id);

			if (entity == null)
			{
				return this.NotFound();
			}

			return entity.MapAsModel();
		}

		// GET: api/customers
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Customer>>> GetAll()
		{
			return await this.context.Customers.ToListAsync();
		}

		// POST: api/customers
		[HttpPost]
		public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
		{
			this.context.Customers.Add(customer);
			await this.context.SaveChangesAsync();

			return this.CreatedAtAction("Get", new { id = customer.Id }, customer);
		}

		// PUT: api/customers/1
		[HttpPut("{id}")]
		public async Task<IActionResult> Put(int id, Customer customer)
		{
			if (id != customer.Id)
			{
				return this.BadRequest();
			}

			this.context.Entry(customer).State = EntityState.Modified;

			await this.context.SaveChangesAsync();

			return this.NoContent();
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<Customer>> Delete(int id)
		{
			var customer = await this.context.Customers.FindAsync(id);

			if (customer == null)
			{
				return this.NotFound();
			}

			this.context.Customers.Remove(customer);
			await this.context.SaveChangesAsync();

			this.notificationService.Notify($"Customer deleted: {id}");

			return customer;
		}
	}
}