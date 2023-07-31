using AutoMapper;
using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Departments.Quieries.Models;
using SchoolProject.Core.Features.Departments.Quieries.Response;
using SchoolProject.Core.Features.Students.Quieres.Response;
using SchoolProject.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Departments.Quieries.Handlers
{
	public class DepartmentHandler : ResponseHandler
		, IRequestHandler<GetDepartmentsListQuerey, Response<List<GetDepartmentListResponse>>>
	{

		#region Fields
		private readonly IDepartmentService DepartmentServies;
		private readonly IMapper mapper;
        #endregion
        #region Constructor
        public DepartmentHandler(IDepartmentService DepartmentServies, IMapper mapper)
        {
            this.mapper = mapper;
			this.DepartmentServies = DepartmentServies;
        }
		#endregion
		#region Handles Functions
		public async Task<Response<List<GetDepartmentListResponse>>> Handle(GetDepartmentsListQuerey request, CancellationToken cancellationToken)
		{
			var Departments = await DepartmentServies.GetDepartmentsListAsync();
			var DepartmentListMapper = mapper.Map<List<GetDepartmentListResponse>>(Departments);
			return Success(DepartmentListMapper);
		}
		#endregion

	}
}
