using AutoMapper;
using SchoolProject.Core.Features.Students.Quieres.Models;
using SchoolProject.Core.Features.Students.Quieres.Response;
using SchoolProject.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Mapping.Students
{
	public partial class StudentProfile:Profile
	{
        public StudentProfile()
        {
			GetStudentsList();
			GetStudentById();


		}
	}
}
