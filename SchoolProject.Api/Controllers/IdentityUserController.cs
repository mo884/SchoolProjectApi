using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Core.Features.Students.Commands.Models;
using SchoolProject.Core.Features.Students.Quieres.Models;
using SchoolProject.Core.Features.User.Quieries.Models;
using SchoolProject.Core.Features.Users.Commands.Models;
using SchoolProject.Data.AppMetaData;

namespace SchoolProject.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class IdentityUserController : ControllerBase
	{
		#region Fieldes
		private readonly IMediator mediator;

		#endregion

		#region Constructor
		public IdentityUserController(IMediator mediator)
		{
			this.mediator = mediator;
		}
		#endregion
		#region Create Identity User 
		[HttpPost(Router.UsertRouting.Create)]
		public async Task<IActionResult> Registration([FromBody] AddUserCommand user)
		{
			if (ModelState.IsValid)
			{
				var response = await mediator.Send(user);
				return Ok(response);

			}
			else
			{
				return BadRequest();
			}

		}
		#endregion

		#region GetAll Identity User 
		[HttpGet(Router.UsertRouting.List)]
		public async Task<IActionResult> GetStudentsList()
		{
			var response = await mediator.Send(new GetListUserQuerey());
			return Ok(response);
		}
		#endregion
	}
}
