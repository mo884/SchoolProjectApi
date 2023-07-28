using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Core.Features.Students.Quieres.Models;

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
		[HttpGet("/Student/List")]
		public async Task<IActionResult> GetStudentsList()
		{
			var response =await mediator.Send(new GetStudentListQuerey());
			return Ok(response);
		} 
        #endregion
    }
}
