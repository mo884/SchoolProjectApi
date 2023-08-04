using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Core.Features.Students.Commands.Models;
using SchoolProject.Core.Features.Students.Quieres.Models;
using SchoolProject.Core.Features.User.Commands.Models;
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

		#region Get Identity User By Id 
		[HttpGet(Router.UsertRouting.GetById)]
		public async Task<IActionResult> GetStudentByID([FromRoute] int id)
		{
			return Ok(await mediator.Send(new GetUserByIdQuery(id)));
		}
		#endregion

		#region Edite Identity User By Id 
		[HttpPut(Router.UsertRouting.Edit)]
		public async Task<IActionResult> Edit([FromBody] EditUserCommand command)
		{
			var response = await mediator.Send(command);
			return Ok(response);
		}

		#endregion

		#region Delete Identity User 
		[HttpDelete(Router.UsertRouting.Delete)]
		public async Task<IActionResult> Delete( int id)
		{
			return Ok(await mediator.Send(new DeleteUserCommand(id)));
		}
		#endregion

		#region Delete Identity User 

		[HttpPut(Router.UsertRouting.ChangePassword)]
		public async Task<IActionResult> ChangePassword([FromBody] ChangeUserPasswordCommand command)
		{
			var response = await mediator.Send(command);
			return Ok(response);
		}
		#endregion

	}
}
