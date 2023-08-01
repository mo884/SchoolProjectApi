using FluentValidation;
using SchoolProject.Core.Features.Students.Commands.Models;
using SchoolProject.Core.Features.User.Commands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Users.Commands.Validations
{
	public class AddUserValidator : AbstractValidator<AddUserCommand>
	{
		#region Constructor
		public AddUserValidator()
		{
			ApplyValidationRules();
			
		}
#endregion

		#region Handels Method
		public void ApplyValidationRules()
		{
			RuleFor(x => x.FullName)
				.NotEmpty().WithMessage("Name must not Empty !")
				.NotNull().WithMessage("Name must not null ")
				.MaximumLength(20).WithMessage("Name Max Length 20 ")
				.MinimumLength(3).WithMessage("Name  Min Length 3  ");

			RuleFor(x => x.Email)
				.NotEmpty().WithMessage("Email must not Empty !")
				.NotNull().WithMessage("{PropertyValue} must not null ")
				.MaximumLength(50).WithMessage("Email Max Length 50 ")
				.MinimumLength(3).WithMessage("Email  Min Length 3  ");

			RuleFor(x => x.Password)
				.NotEmpty().WithMessage("Email must not Empty !")
				.NotNull().WithMessage("{PropertyValue} must not null ")
				.MaximumLength(40).WithMessage("Email Max Length 40 ")
				.MinimumLength(5).WithMessage("Email  Min Length 5  ");

			RuleFor(x => x.ConfirmPassword)
				.NotEmpty().WithMessage("ConfirmPassword must not Empty !")
				.Matches(a=>a.Password).WithMessage("ConfirmPassword Must Like The Current Password !")
				.NotNull().WithMessage("{PropertyValue} must not null ")
				.MaximumLength(40).WithMessage("ConfirmPassword Max Length 40 ")
				.MinimumLength(5).WithMessage("ConfirmPassword  Min Length 5  ");

			RuleFor(x => x.UserName)
				.NotEmpty().WithMessage("UserName must not Empty !")
				.NotNull().WithMessage("{PropertyValue} must not null ")
				.MaximumLength(40).WithMessage("UserName Max Length 40 ")
				.MinimumLength(3).WithMessage("UserName  Min Length 3  ");
		}
	}
	#endregion
}
