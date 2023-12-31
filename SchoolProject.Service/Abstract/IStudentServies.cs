﻿using SchoolProject.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Service.Abstract
{
	public interface IDepartmentServies
	{
		public Task<List<Student>> GetStudentsListAsync();
		public Task<Student> GetStudentByIdAsync(int id);
		public Task<string> CreateStudentAsync(Student student);
		public Task<string>EditeStudentAsync(Student student);
		public Task<string> DeleteStudentAsync(Student student);
	}
}
