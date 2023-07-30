using AutoMapper;
using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Students.Quieres.Models;
using SchoolProject.Core.Features.Students.Quieres.Response;
using SchoolProject.Data.Entites;
using SchoolProject.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Quieres.Handlers
{
	public class StudentHandlers : ResponseHandler
		,IRequestHandler<GetStudentListQuerey,Response<List<GetStudentListResponse>>>
		, IRequestHandler<GetStudentByIdQuerey, Response<GetStudentByIDResponse>>
	{
		#region Fieldes
		private readonly IStudentServies studentServies;
		private readonly IMapper mapper;
		#endregion

		#region Constructor
		public StudentHandlers(IStudentServies studentServies, IMapper mapper)
        {
			this.studentServies = studentServies;
			this.mapper = mapper;
		}
		#endregion

		#region Handles  Function
		public async Task<Response<List<GetStudentListResponse>>> Handle(GetStudentListQuerey request, CancellationToken cancellationToken)
		{

			var studentList = await studentServies.GetStudentsListAsync();
			var studentListMapper = mapper.Map<List<GetStudentListResponse>>(studentList);
			return Success(studentListMapper);
		}

		public async Task<Response<GetStudentByIDResponse>> Handle(GetStudentByIdQuerey request, CancellationToken cancellationToken)
		{

			var student = await studentServies.GetStudentByIdAsync(request.Id);
			if (student == null) return NotFound<GetStudentByIDResponse>("Object not found");
			var studentMapper = mapper.Map<GetStudentByIDResponse>(student);
			return Success(studentMapper);
		}
		#endregion

	}
}
