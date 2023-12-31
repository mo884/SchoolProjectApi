﻿using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entites;
using SchoolProject.Infrustructure.Abstraction;
using SchoolProject.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Service.Impelementation
{
	public class StudentService : IDepartmentServies
	{
		#region Fieldes
		private readonly IStudentRep studentRep;

		#endregion

		#region Constructor
		public StudentService(IStudentRep studentRep)
        {
			this.studentRep = studentRep;
		}

		

		#endregion

		#region Handles  Functions
		public async Task<List<Student>> GetStudentsListAsync()
		{
			return await studentRep.GetStudentsListAsync();
		}
		//Get Student By ID 
		public async Task<Student> GetStudentByIdAsync(int id)
		{
			var student = await studentRep.GetTableNoTracking()
				.Include(a=>a.Department)
				.Where(filter=>filter.StudID == id)
				.FirstOrDefaultAsync();
			return student;
		}

		public async Task<string> CreateStudentAsync(Student student)
		{
			await studentRep.AddAsync(student);
			var IsFound = await studentRep.GetTableNoTracking()

				.Where(filter => filter.Name == student.Name)
				.FirstOrDefaultAsync();


			if (IsFound == null) return "not sucesses due the name is Exist";
			return null;
		}

		public async Task<string> EditeStudentAsync(Student student)
		{
			try
			{
				await studentRep.UpdateAsync(student);
				return null;

			}
			catch (Exception)
			{

				return "not success";
			}
		}

		public async Task<string> DeleteStudentAsync(Student student)
		{
			try
			{
				await studentRep.DeleteAsync(student);
				return null;

			}
			catch (Exception)
			{

				return "not success";
			}
		}

		#endregion
	}
}
