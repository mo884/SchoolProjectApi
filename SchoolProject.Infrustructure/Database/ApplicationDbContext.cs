using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrustructure.Database
{
	public class ApplicationDbContext:DbContext
	{
        public ApplicationDbContext()
        {
            
        }
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opt):base(opt)
		{

		}
		public DbSet<Department> Departments { get; set; }
		public DbSet<DepartmetSubject> DepartmetSubjects { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<StudentSubject> StudentSubjects { get; set; }
		public DbSet<Subjects> Subjects { get; set; }

	}
}
