using SchoolProject.Data.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SchoolProject.Core.Bases;

namespace SchoolProject.Core.Features.Students.Commands.Models
{
	public class AddStudentCommands:IRequest<Response<string>>
	{
		[Required]
		public string Name { get; set; }
		[Required]
		public string Address { get; set; }
		
		public string Phone { get; set; }
		public int? DepartmentID { get; set; }

		
	}
}
