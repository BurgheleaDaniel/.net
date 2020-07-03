using System;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ThriftShop.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[ApiExplorerSettings(IgnoreApi = true)]
	public class ErrorController : ControllerBase
	{
		ILogger<ErrorController> logger;
		public ErrorController(ILogger<ErrorController> logger)
		{
			this.logger = logger;
		}

		[Route("/error-local-development")]
		public IActionResult ErrorLocalDevelopment(
			[FromServices] IWebHostEnvironment webHostEnvironment)
		{
			if (webHostEnvironment.EnvironmentName != "Development")
			{
				throw new InvalidOperationException(
					"This shouldn't be invoked in non-development environments.");
			}

			var context = HttpContext.Features.Get<IExceptionHandlerFeature>();

			this.logger.LogError(context.Error.Message);

			return Problem(
				detail: context.Error.StackTrace,
				title: context.Error.Message);
		}

		[Route("/error")]
		public IActionResult Error() => Problem();
	}
}