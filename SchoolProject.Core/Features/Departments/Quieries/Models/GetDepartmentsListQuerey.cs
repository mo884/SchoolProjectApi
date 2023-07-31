using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Departments.Quieries.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Departments.Quieries.Models
{
	public class GetDepartmentsListQuerey : IRequest<Response<List<GetDepartmentListResponse>>>
    {
	}
}
