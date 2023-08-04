using FluentValidation;
using SchoolProject.Core.Features.User.Commands.Models;
using SchoolProject.Core.Features.Users.Commands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.User.Commands.Validations
{
	public class ChangeUserPasswordValidator : AbstractValidator<ChangeUserPasswordCommand>
	{
		#region Constructor
		public ChangeUserPasswordValidator()
		{
			ApplyValidationRules();

		}
		#endregion

		#region Handels Method
		public void ApplyValidationRules()
		{
			

			RuleFor(x => x.CurrentPassword)
				.NotEmpty().WithMessage("CurrentPassword must not Empty !")
				.NotNull().WithMessage("{PropertyValue} must not null ")
				.MaximumLength(50).WithMessage("CurrentPassword Max Length 50 ")
				.MinimumLength(3).WithMessage("CurrentPassword  Min Length 3  ");

			RuleFor(x => x.NewPassword)
				.NotEmpty().WithMessage("NewPassword must not Empty !")
				.NotNull().WithMessage("{PropertyValue} must not null ")
				.MaximumLength(40).WithMessage("NewPassword Max Length 40 ")
				
				.MinimumLength(5).WithMessage("NewPassword  Min Length 5  ");

			RuleFor(x => x.ConfirmPassword)
				.NotEmpty().WithMessage("ConfirmPassword must not Empty !")
				.Matches(a => a.NewPassword).WithMessage("ConfirmPassword Must Like The Current Password !")
				.NotNull().WithMessage("{PropertyValue} must not null ")
				.MaximumLength(40).WithMessage("ConfirmPassword Max Length 40 ")
				.MinimumLength(5).WithMessage("ConfirmPassword  Min Length 5  ");

			
		}
	}
	#endregion
}
