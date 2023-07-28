using MediatR;
using SchoolProject.Core.Features.Students.Quieres.Models;
using SchoolProject.Data.Entites;
using SchoolProject.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Quieres.Handlers
{
	public class StudentHandlers : IRequestHandler<GetStudentListQuerey, List<Student>>
	{
		#region Fieldes
		private readonly IStudentServies studentServies;

		#endregion

		#region Constructor
		public StudentHandlers(IStudentServies studentServies)
        {
			this.studentServies = studentServies;
		}
        #endregion

        #region Handles  Function
        #endregion
        public async Task<List<Student>> Handle(GetStudentListQuerey request, CancellationToken cancellationToken)
		{
			return await studentServies.GetStudentsListAsync();
		}
	}
}
