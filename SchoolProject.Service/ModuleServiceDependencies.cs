﻿using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infrustructure.Abstraction;
using SchoolProject.Infrustructure.Repesiratories;
using SchoolProject.Service.Abstract;
using SchoolProject.Service.Impelementation;

namespace SchoolProject.Service
{
	public static class ModuleServiceDependencies
	{
		public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
		{
			services.AddTransient<IDepartmentServies, StudentService>();
			services.AddTransient<IDepartmentService, DepartmentService>();
			//services.AddTransient<IAuthenticationService, AuthenticationService>();
			return services;
		}
	}
}