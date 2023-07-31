using SchoolProject.Core.Features.Departments.Quieries.Response;
using SchoolProject.Core.Features.Students.Quieres.Response;
using SchoolProject.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Mapping.Departments
{
	public partial class DepartmentProfile 
	{
		public void GetDepartmentList()
		{
			CreateMap<Department , GetDepartmentListResponse>()
			
				.ForMember(dist => dist.Students, opt => opt.MapFrom(src => src.Students))
				;
		}
	}
}
