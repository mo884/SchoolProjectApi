using SchoolProject.Data.Entites;
using SchoolProject.Infrustructure.Infrustructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrustructure.Abstraction
{
	public interface IStudentRep: IGenericRepositoryAsync<Student>
	{
		public Task<List<Student>> GetStudentsListAsync();
	}
}
