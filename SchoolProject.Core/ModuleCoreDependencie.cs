﻿using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Core.Behavior;
using SchoolProject.Infrustructure.Abstraction;
using SchoolProject.Infrustructure.Repesiratories;
using System.Reflection;

namespace SchoolProject.Core
{
	public static class ModuleCoreDependencie
	{
		public static IServiceCollection AddCoreDependencie(this IServiceCollection services)
		{

			//Configuration of Mediatr
			services.AddMediatR(a => a.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

			//Configuration of AutoMapper
			services.AddAutoMapper(Assembly.GetExecutingAssembly());

			// Configuration of Validators
			services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

			// Add Transiant 
			services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));


			return services;
		}
	}
}