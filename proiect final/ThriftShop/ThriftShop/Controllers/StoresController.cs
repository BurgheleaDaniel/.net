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
	[Route("api/stores")]
	[ApiController]
	public class StoresController : Controller
	{
		private readonly ApiDbContext context;
		private readonly INotificationService notificationService;

		public StoresController(ApiDbContext context, INotificationService notificationService)
		{
			this.context = context;
			this.notificationService = notificationService;
		}

		// GET: api/stores/1
		[HttpGet("{id}")]
		public async Task<ActionResult<StoreModel>> Get(int id)
		{
			if (id < 0)
			{
				throw new AccessViolationException("Negative id exception");
			}

			var entity = await this.context.Stores.FindAsync(id);

			if (entity == null)
			{
				return this.NotFound();
			}

			return entity.MapAsModel();
		}

		// GET: api/stores
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Store>>> GetAll()
		{
			return await this.context.Stores.ToListAsync();
		}

		// POST: api/stores
		[HttpPost]
		public async Task<ActionResult<Store>> PostStore(Store store)
		{
			this.context.Stores.Add(store);
			await this.context.SaveChangesAsync();

			return this.CreatedAtAction("Get", new { id = store.Id }, store);
		}

		// PUT: api/stores/1
		[HttpPut("{id}")]
		public async Task<IActionResult> Put(int id, Store store)
		{
			if (id != store.Id)
			{
				return this.BadRequest();
			}

			this.context.Entry(store).State = EntityState.Modified;

			await this.context.SaveChangesAsync();

			return this.NoContent();
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<Store>> Delete(int id)
		{
			var store = await this.context.Stores.FindAsync(id);

			if (store == null)
			{
				return this.NotFound();
			}

			this.context.Stores.Remove(store);
			await this.context.SaveChangesAsync();

			this.notificationService.Notify($"Store deleted: {id}");

			return store;
		}

	}
}