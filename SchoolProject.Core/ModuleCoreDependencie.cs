using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infrustructure.Abstraction;
using SchoolProject.Infrustructure.Repesiratories;
using System.Reflection;

namespace SchoolProject.Core
{
	public static class ModuleCoreDependencie
	{
		public static IServiceCollection AddCoreDependencie(this IServiceCollection services)
		{
			services.AddMediatR(a => a.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
			return services;
		}
	}
}