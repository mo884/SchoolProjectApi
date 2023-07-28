using SchoolProject.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrustructure.Abstraction
{
	public interface IStudentRep
	{
		public Task<List<Student>> GetStudentsListAsync();
	}
}
