﻿using SchoolProject.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Service.Abstract
{
	public interface IDepartmentService
	{
		public Task<List<Department>> GetDepartmentsListAsync();

	}
}
