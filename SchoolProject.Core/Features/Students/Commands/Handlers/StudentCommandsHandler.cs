using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Localization;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Students.Commands.Models;
using SchoolProject.Core.Features.Students.Quieres.Models;
using SchoolProject.Core.Features.Students.Quieres.Response;
using SchoolProject.Core.SharedResource;
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
		, IRequestHandler<DeleteStudentCommands, Response<string>>
	{
		#region Fieldes
		private readonly IStudentServies studentServies;
		private readonly IMapper mapper;
		private readonly IStringLocalizer<SharedResources> stringLocalizer;
		#endregion

		#region Constructor
		public StudentCommandsHandler(IStudentServies studentServies, IMapper mapper, IStringLocalizer<SharedResources> stringLocalizer)
		{
			this.studentServies = studentServies;
			this.mapper = mapper;
			this.stringLocalizer = stringLocalizer;
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
			if (IsFound == null)
				return NotFound<string>(stringLocalizer[SharedResourceKey.StudentNotFound]);
			var student = mapper.Map<Student>(request);
			string isEdite = await studentServies.EditeStudentAsync(student);
			if (isEdite == null)
				return Success<string>(" Edite is Success");
			return BadRequest<string>(isEdite);

		}

		public async Task<Response<string>> Handle(DeleteStudentCommands request, CancellationToken cancellationToken)
		{
			var IsFound = await studentServies.GetStudentByIdAsync(request.Id);
			if (IsFound == null) 
				return NotFound<string>(stringLocalizer[SharedResourceKey.StudentNotFound]);
			string isDeleted = await studentServies.DeleteStudentAsync(IsFound);
			if (isDeleted == null)
				return Success(" Deleted is Success");
			return BadRequest<string>(isDeleted);
		}
		#endregion
	}
}
