using SchoolProject.Data.Entites;
using SchoolProject.Infrustructure.Abstraction;
using SchoolProject.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Service.Impelementation
{
	public class DepartmentService : IDepartmentService
	{
		#region Fields
		private readonly IDepartmentRep departmentRep;
        #endregion
        #region Constructor
        public DepartmentService(IDepartmentRep departmentRep)
        {
            this.departmentRep = departmentRep;
        }
        #endregion
        #region Handles Functions

        #endregion
        public async Task<List<Department>> GetDepartmentsListAsync()
		{
            return await departmentRep.GetDepartmentsListAsync();
		}
	}
}
