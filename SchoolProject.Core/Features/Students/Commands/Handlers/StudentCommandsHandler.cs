using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Students.Commands.Models;
using SchoolProject.Core.Features.Students.Quieres.Models;
using SchoolProject.Core.Features.Students.Quieres.Response;
using SchoolProject.Data.Entites;
using SchoolProject.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Commands.Handlers
{
	public class StudentCommandsHandler : ResponseHandler
		, IRequestHandler<AddStudentCommands, Response<string>>
		, IRequestHandler<EditeStudentCommands, Response<string>>
	{
		#region Fieldes
		private readonly IStudentServies studentServies;
		private readonly IMapper mapper;
		#endregion

		#region Constructor
		public StudentCommandsHandler(IStudentServies studentServies, IMapper mapper)
		{
			this.studentServies = studentServies;
			this.mapper = mapper;
		}
		#endregion

		#region Handles  Function
		public async Task<Response<string>> Handle(AddStudentCommands request, CancellationToken cancellationToken)
		{
			var student = mapper.Map<Student>(request);
			string ISAdded = await studentServies.CreateStudentAsync(student);
			if (ISAdded != null)
				return BadRequest<string>(ISAdded);
			 return Success<string>(" Add is Success");
		}

		public async Task<Response<string>> Handle(EditeStudentCommands request, CancellationToken cancellationToken)
		{
			var IsFound = await studentServies.GetStudentByIdAsync(request.Id);
			if (IsFound == null) return NotFound<string>("Student not Found");
			var student = mapper.Map<Student>(request);
			string isEdite = await studentServies.EditeStudentAsync(student);
			if(isEdite == null)
				return Success<string>(" Edite is Success");
			return BadRequest<string>(isEdite);

		}
		#endregion
	}
}
