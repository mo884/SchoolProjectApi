using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Students.Quieres.Response;
using SchoolProject.Core.Features.User.Quieries.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.User.Quieries.Models
{
	public class GetUserByIdQuery:IRequest<Response<GetUserByIdResponse>>
	{
		public int Id { get; set; }
		public GetUserByIdQuery(int id)
		{
			Id = id;
		}

	}
}
