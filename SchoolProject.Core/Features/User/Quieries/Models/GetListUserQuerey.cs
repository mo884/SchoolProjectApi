using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.User.Quieries.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.User.Quieries.Models
{
	public class GetListUserQuerey :IRequest<Response<List<GetListUserResponse>>>
	{
	}
}
