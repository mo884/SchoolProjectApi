using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entites;
using SchoolProject.Infrustructure.Abstraction;
using SchoolProject.Infrustructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrustructure.Repesiratories
{
	public class StudentRep : IStudentRep
	{
		#region Fields
		private readonly ApplicationDbContext dbContext;

		#endregion


		#region Constructor
		public StudentRep(ApplicationDbContext dbContext)
        {
			this.dbContext = dbContext;
		}
		#endregion


		#region Handles Functions
		public async Task<List<Student>> GetStudentsListAsync()
		{
			var Students = await dbContext.Students.ToListAsync();
			return Students;
		}
		#endregion
	}
}
