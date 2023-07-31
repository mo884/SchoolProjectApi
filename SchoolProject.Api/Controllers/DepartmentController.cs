using MediatR;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Core.Features.Departments.Quieries.Models;
using SchoolProject.Core.Features.Students.Quieres.Models;
using SchoolProject.Data.AppMetaData;

namespace SchoolProject.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DepartmentController : ControllerBase
	{
		#region Fieldes
		private readonly IMediator mediator;

		#endregion

		#region Constructor
		public DepartmentController(IMediator mediator)
		{
			this.mediator = mediator;
		}
		#endregion

		#region GetAll Student 
		[HttpGet(Router.DepartmentRouting.List)]
		public async Task<IActionResult> GetDepartmentsList()
		{
			var response = await mediator.Send(new GetDepartmentsListQuerey());
			return Ok(response);
		}
		#endregion

	}
}
