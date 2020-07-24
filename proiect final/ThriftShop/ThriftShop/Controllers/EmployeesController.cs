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
	[Route("api/employees")]
	[ApiController]
	public class EmployeesController : Controller
	{
		private readonly ApiDbContext context;
		private readonly INotificationService notificationService;

		public EmployeesController(ApiDbContext context, INotificationService notificationService)
		{
			this.context = context;
			this.notificationService = notificationService;
		}

		// GET: api/employees/1
		[HttpGet("{id}")]
		public async Task<ActionResult<EmployeeModel>> Get(int id)
		{
			if (id < 0)
			{
				throw new AccessViolationException("Negative id exception");
			}

			var entity = await this.context.Employees.FindAsync(id);

			if (entity == null)
			{
				return this.NotFound();
			}

			return entity.MapAsModel();
		}

		// GET: api/employees
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Employee>>> GetAll()
		{
			return await this.context.Employees.ToListAsync();
		}

		// POST: api/employees
		[HttpPost]
		public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
		{
			this.context.Employees.Add(employee);
			await this.context.SaveChangesAsync();

			return this.CreatedAtAction("Get", new { id = employee.Id }, employee);
		}

		// PUT: api/employees/1
		[HttpPut("{id}")]
		public async Task<IActionResult> Put(int id, Employee employee)
		{
			if (id != employee.Id)
			{
				return this.BadRequest();
			}

			this.context.Entry(employee).State = EntityState.Modified;

			await this.context.SaveChangesAsync();

			return this.NoContent();
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<Employee>> Delete(int id)
		{
			var employee = await this.context.Employees.FindAsync(id);

			if (employee == null)
			{
				return this.NotFound();
			}

			this.context.Employees.Remove(employee);
			await this.context.SaveChangesAsync();

			this.notificationService.Notify($"Rmployee deleted: {id}");

			return employee;
		}
	}
}