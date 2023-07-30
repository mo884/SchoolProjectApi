using SchoolProject.Core.Features.Students.Quieres.Response;
using SchoolProject.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Mapping.Students
{
	
	public partial class StudentProfile
	{
		public void GetStudentById()
		{
			CreateMap<Student, GetStudentByIDResponse>()
				.ForMember(dist => dist.DepartmentName, opt => opt.MapFrom(src => src.Department.DName))
				;
		}
	}
}
