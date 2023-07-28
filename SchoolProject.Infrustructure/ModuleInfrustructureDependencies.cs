using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infrustructure.Abstraction;
using SchoolProject.Infrustructure.Repesiratories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrustructure
{
	public static class ModuleInfrustructureDependencies
	{
		public static IServiceCollection AddInfrustructureDependencies(this IServiceCollection services)
		{
			services.AddTransient<IStudentRep, StudentRep>();
			return services;
		}
	}
}
