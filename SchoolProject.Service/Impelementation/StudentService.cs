﻿using SchoolProject.Data.Entites;
using SchoolProject.Infrustructure.Abstraction;
using SchoolProject.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Service.Impelementation
{
	public class StudentService : IStudentServies
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
		#endregion
	}
}