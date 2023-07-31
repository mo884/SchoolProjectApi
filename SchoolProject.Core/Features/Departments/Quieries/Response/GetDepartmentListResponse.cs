using SchoolProject.Core.Features.Students.Quieres.Response;
using SchoolProject.Data.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Departments.Quieries.Response
{
	public class GetDepartmentListResponse
	{
		
		public string DName { get; set; }
		public virtual ICollection<GetStudentListResponse> Students { get; set; }
	}
}
