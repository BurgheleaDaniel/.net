﻿using System;
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
	[Route("api/products")]
	public class ProductsController : ControllerBase
	{
		private readonly ApiDbContext context;
		private readonly INotificationService notificationService;

		public ProductsController(ApiDbContext context, INotificationService notificationService)
		{
			this.context = context;
			this.notificationService = notificationService;
		}

		// GET: api/products/1
		[HttpGet("{id}")]
		public async Task<ActionResult<ProductModel>> Get(int id)
		{
			if (id < 0)
			{
				throw new AccessViolationException("Negative id exception");
			}

			var entity = await this.context.Products.FindAsync(id);

			if (entity == null)
			{
				return this.NotFound();
			}

			return entity.MapAsModel();
		}

		// GET: api/products
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Product>>> GetAll()
		{
			return await this.context.Products.ToListAsync();
		}

		// POST: api/products
		[HttpPost]
		public async Task<ActionResult<Product>> PostProduct(Product product)
		{
			this.context.Products.Add(product);
			await this.context.SaveChangesAsync();

			return this.CreatedAtAction("Get", new { id = product.Id }, product);
		}

		// PUT: api/products/1
		[HttpPut("{id}")]
		public async Task<IActionResult> Put(int id, Product product)
		{
			if (id != product.Id)
			{
				return this.BadRequest();
			}

			this.context.Entry(product).State = EntityState.Modified;

			await this.context.SaveChangesAsync();

			return this.NoContent();
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<Product>> Delete(int id)
		{
			var product = await this.context.Products.FindAsync(id);

			if (product == null)
			{
				return this.NotFound();
			}

			this.context.Products.Remove(product);
			await this.context.SaveChangesAsync();

			this.notificationService.Notify($"Product deleted: {id}");

			return product;
		}

	}
}
