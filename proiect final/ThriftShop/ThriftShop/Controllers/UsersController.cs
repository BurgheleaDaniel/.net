using Microsoft.AspNetCore.Mvc;
using ThriftShop.Services;
using ThriftShop.DataAccess.Models;
using Microsoft.AspNetCore.Authorization;

namespace ThriftShop.Controllers
{
	[ApiController]
	[Route("api/users")]
	public class UsersController : Controller
	{
		private IUserService _userService;

		public UsersController(IUserService userService)
		{
			_userService = userService;
		}

		[HttpPost("authenticate")]
		public IActionResult Authenticate(AuthenticateRequest model)
		{
			var response = _userService.Authenticate(model);

			if (response == null)
				return BadRequest(new { message = "Username or password is incorrect" });

			return Ok(response);
		}

		[Authorize]
		[HttpGet]
		public IActionResult GetAll()
		{
			var users = _userService.GetAll();
			return Ok(users);
		}
	}
}