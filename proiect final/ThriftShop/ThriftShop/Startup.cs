using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using ThriftShop.DataAccess;
using ThriftShop.Helpers;
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

			services.AddCors();
			services.AddControllers();

			// configure strongly typed settings object
			services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));

			// configure DI for application services
			services.AddScoped<IUserService, UserService>();
			services.AddScoped<INotificationService, NotificationService>();

			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "Trift Shop API", Version = "v1" });
				c.AddSecurityDefinition("bearerAuth", new OpenApiSecurityScheme
				{
					Type = SecuritySchemeType.Http,
					Scheme = "bearer",
					BearerFormat = "JWT",
					Description = "JWT Authorization header using the Bearer scheme."
				});
				c.AddSecurityRequirement(new OpenApiSecurityRequirement
				{
					{
						new OpenApiSecurityScheme
						{
							Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "bearerAuth" }
						},
						new string[] {}
					}
				});
			});
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

			// global cors policy
			app.UseCors(x => x
				.AllowAnyOrigin()
				.AllowAnyMethod()
				.AllowAnyHeader());

			// custom jwt auth middleware
			app.UseAuthorization();
			app.UseMiddleware<JwtMiddleware>();

			app.UseMiddleware<RequestLoggerMiddleware>();

			app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
		}
	}
}
