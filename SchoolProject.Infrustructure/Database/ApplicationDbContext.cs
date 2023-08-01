
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entites;
using SchoolProject.Data.Entites.Identity;


namespace SchoolProject.Infrustructure.Database
{
	public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<int>, int, IdentityUserClaim<int>, IdentityUserRole<int>, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
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
