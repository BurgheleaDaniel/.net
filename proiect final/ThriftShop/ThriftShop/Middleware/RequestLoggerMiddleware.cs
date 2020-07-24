using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using ThriftShop.Services;

namespace ThriftShop.Middleware
{
	public class RequestLoggerMiddleware
	{
		private readonly RequestDelegate next;

		public RequestLoggerMiddleware(RequestDelegate next)
		{
			this.next = next;
		}

		public async Task Invoke(HttpContext context, INotificationService notificationService)
		{
			notificationService.Notify($"Handling request: {context.Request.Method} {context.Request.Path}");

			await next.Invoke(context);

			notificationService.Notify("Finished handling request.");
		}
	}
}
