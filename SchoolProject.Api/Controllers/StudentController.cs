using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Core.Features.Students.Commands.Models;
using SchoolProject.Core.Features.Students.Quieres.Models;
using SchoolProject.Data.AppMetaData;

namespace SchoolProject.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StudentController : ControllerBase
	{
		#region Fieldes
		private readonly IMediator mediator;

		#endregion

		#region Constructor
		public StudentController(IMediator mediator)
        {
			this.mediator = mediator;
		}
		#endregion

		#region GetAll Student 
		[HttpGet(Router.StudentRouting.List)]
		public async Task<IActionResult> GetStudentsList()
		{
			var response =await mediator.Send(new GetStudentListQuerey());
			return Ok(response);
		}
		#endregion

		#region GetAll Student 
		[HttpGet(Router.StudentRouting.GetById)]
		public async Task<IActionResult> GetStudentsByID([FromRoute]int id)
		{
			var response = await mediator.Send(new GetStudentByIdQuerey(id));
			return Ok(response);
		}
		#endregion
		#region Create Student 
		[HttpPost(Router.StudentRouting.Create)]
		public async Task<IActionResult> CreateStudent([FromBody] AddStudentCommands student)
		{
			if(ModelState.IsValid)
			{
				var response = await mediator.Send(student);
				return Ok(response);

			}
			else
			{
				return BadRequest();
			}
			
		}
		#endregion
		#region Edit Student 
		[HttpPut(Router.StudentRouting.Edit)]
		public async Task<IActionResult> EditStudent([FromBody] EditeStudentCommands student )
		{
			if (ModelState.IsValid)
			{
				var response = await mediator.Send(student);
				return Ok(response);

			}
			else
			{
				return BadRequest();
			}

		}
		#endregion
	}
}
