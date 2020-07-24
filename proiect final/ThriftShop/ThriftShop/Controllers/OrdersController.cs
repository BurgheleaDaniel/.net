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
	[Route("api/orders")]
	[ApiController]
	public class OrdersController : Controller
	{
		private readonly ApiDbContext context;
		private readonly INotificationService notificationService;

		public OrdersController(ApiDbContext context, INotificationService notificationService)
		{
			this.context = context;
			this.notificationService = notificationService;
		}

		// GET: api/orders/1
		[HttpGet("{id}")]
		public async Task<ActionResult<OrderModel>> Get(int id)
		{
			if (id < 0)
			{
				throw new AccessViolationException("Negative id exception");
			}

			var entity = await this.context.Orders.FindAsync(id);

			if (entity == null)
			{
				return this.NotFound();
			}

			return entity.MapAsModel();
		}

		// GET: api/orders
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Order>>> GetAll()
		{
			return await this.context.Orders.ToListAsync();
		}

		// POST: api/orders
		[HttpPost]
		public async Task<ActionResult<Order>> PostOrder(Order order)
		{
			this.context.Orders.Add(order);
			await this.context.SaveChangesAsync();

			return this.CreatedAtAction("Get", new { id = order.Id }, order);
		}

		// PUT: api/orders/1
		[HttpPut("{id}")]
		public async Task<IActionResult> Put(int id, Order order)
		{
			if (id != order.Id)
			{
				return this.BadRequest();
			}

			this.context.Entry(order).State = EntityState.Modified;

			await this.context.SaveChangesAsync();

			return this.NoContent();
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<Order>> Delete(int id)
		{
			var order = await this.context.Orders.FindAsync(id);

			if (order == null)
			{
				return this.NotFound();
			}

			this.context.Orders.Remove(order);
			await this.context.SaveChangesAsync();

			this.notificationService.Notify($"Order deleted: {id}");

			return order;
		}
	}
}