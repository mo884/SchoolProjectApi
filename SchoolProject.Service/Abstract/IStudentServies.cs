﻿using SchoolProject.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Service.Abstract
{
	public interface IStudentServies
	{
		public Task<List<Student>> GetStudentsListAsync();
		public Task<Student> GetStudentByIdAsync(int id);
		public Task<string> CreateStudentAsync(Student student);
	}
}
