﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolProject.Data.Entites;
using SchoolProject.Core.Features.Students.Quieres.Response;
using SchoolProject.Core.Bases;

namespace SchoolProject.Core.Features.Students.Quieres.Models
{
	public class GetStudentListQuerey:IRequest<Response<List<GetStudentListResponse>> >
	{
	}
}
