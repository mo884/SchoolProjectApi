using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using SchoolProject.Data.Entites.Identity;
using SchoolProject.Infrustructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrustructure
{
	public static class ServiceRegistration
	{
		public static IServiceCollection AddServiceRegistration(this IServiceCollection services)
		{
			services.AddIdentity<User, IdentityRole<int>>(option =>
			{
				// Default Password settings
				option.User.RequireUniqueEmail = true;
				option.Password.RequireDigit = true;
				option.Password.RequireLowercase = false;
				option.Password.RequireNonAlphanumeric = false;
				option.Password.RequireUppercase = false;
				option.Password.RequiredLength = 6;
				option.Password.RequiredUniqueChars = 0;

				// Lockout settings.
				option.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
				option.Lockout.MaxFailedAccessAttempts = 5;
				option.Lockout.AllowedForNewUsers = true;

				// User settings.
				option.User.AllowedUserNameCharacters =
				"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
				option.User.RequireUniqueEmail = true;
				option.SignIn.RequireConfirmedEmail = false;

			}).AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
			return services;
		}
	}
}
