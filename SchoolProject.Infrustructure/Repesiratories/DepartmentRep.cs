using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entites;
using SchoolProject.Infrustructure.Abstraction;
using SchoolProject.Infrustructure.Database;
using SchoolProject.Infrustructure.Infrustructure;

namespace SchoolProject.Infrustructure.Repesiratories
{
	public class DepartmentRep : GenericRepositoryAsync<Department>, IDepartmentRep
	{
        #region Fields
        private readonly ApplicationDbContext dbContext;
        #endregion
        #region Constructor
        public DepartmentRep(ApplicationDbContext dbContext):base(dbContext) 
        { 
            this.dbContext = dbContext;
        }

        
        #endregion
        #region Handles Function
        public async Task<List<Department>> GetDepartmentsListAsync()
		{
			var Departments = await dbContext.Departments.Include(opt => opt.Students).ToListAsync();
			return Departments;
		}
		#endregion

	}
}
