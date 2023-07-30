using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Students.Quieres.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Quieres.Models
{
	public class GetStudentByIdQuerey:IRequest<Response<GetStudentByIDResponse> >
	{
		public int Id { get; set; }
        public GetStudentByIdQuerey(int id)
        {
            Id = id;
        }
    }
}
