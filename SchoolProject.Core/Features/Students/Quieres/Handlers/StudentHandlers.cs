using AutoMapper;
using MediatR;
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
	public class StudentHandlers : IRequestHandler<GetStudentListQuerey, List<GetStudentListResponse>>
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
        #endregion
        public async Task<List<GetStudentListResponse>> Handle(GetStudentListQuerey request, CancellationToken cancellationToken)
		{

			var studentList = await studentServies.GetStudentsListAsync();
			var studentListMapper = mapper.Map<List<GetStudentListResponse>>(studentList);
			return studentListMapper;
		}
	}
}
