using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infrustructure.Abstraction;
using SchoolProject.Infrustructure.Repesiratories;
using SchoolProject.Service.Abstract;
using SchoolProject.Service.Impelementation;

namespace SchoolProject.Service
{
	public static class ModuleServiceDependencies
	{
		public static IServiceCollection AddInfrustructureDependencies(this IServiceCollection services)
		{
			services.AddTransient<IStudentServies, StudentService>();
			return services;
		}
	}
}