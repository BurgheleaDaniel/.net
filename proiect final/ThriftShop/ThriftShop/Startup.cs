using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using ThriftShop.DataAccess;
using ThriftShop.Middleware;
using ThriftShop.Services;

namespace ThriftShop
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<ApiDbContext>(options =>
				options.UseSqlServer(this.Configuration.GetConnectionString("DefaultConnection")));

			services.AddControllers();

			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "Trift Shop API", Version = "v1" });
			});

			services.AddScoped<INotificationService, NotificationService>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseExceptionHandler("/error-local-development");

				app.UseSwagger();

				app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "Trift Shop API V1"); });
			}
			else
			{
				app.UseExceptionHandler("/error");
			}

			app.UseRouting();

			app.UseMiddleware<RequestLoggerMiddleware>();

			app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
		}
	}
}
