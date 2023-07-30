using SchoolProject.Core.Features.Students.Commands.Models;
using SchoolProject.Core.Features.Students.Quieres.Response;
using SchoolProject.Data.Entites;


namespace SchoolProject.Core.Mapping.Students
{

	public partial class StudentProfile
	{
		public void AddStudentProfile()
		{
			CreateMap<AddStudentCommands, Student>().ForMember(dest=> dest.DID,opt=> opt.MapFrom(src=>src.DepartmentID));
			
		}
	}
}