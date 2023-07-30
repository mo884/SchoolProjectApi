using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entites;
using SchoolProject.Infrustructure.Abstraction;
using SchoolProject.Infrustructure.Database;
using SchoolProject.Infrustructure.Infrustructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrustructure.Repesiratories
{
	public class StudentRep : GenericRepositoryAsync<Student>, IStudentRep
	{
		#region Fields
		private readonly ApplicationDbContext dbContext;

		#endregion


		#region Constructor
		public StudentRep(ApplicationDbContext dbContext) :base(dbContext)
        {
			this.dbContext = dbContext;
		}
		#endregion


		#region Handles Functions
		public async Task<List<Student>> GetStudentsListAsync()
		{
			var Students = await dbContext.Students.Include(opt=>opt.Department).ToListAsync();
			return Students;
		}
		#endregion
	}
}
