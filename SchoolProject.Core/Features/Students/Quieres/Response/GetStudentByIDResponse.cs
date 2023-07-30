﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Quieres.Response
{
	public class GetStudentByIDResponse
	{
		public int StudID { get; set; }

		public string? Name { get; set; }

		public string? Address { get; set; }
		public string Phone { get; set; }
		public int? DID { get; set; }

		public string? DepartmentName { get; set; }

	}
}
