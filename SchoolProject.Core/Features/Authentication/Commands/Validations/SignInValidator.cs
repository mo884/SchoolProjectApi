using FluentValidation;
using SchoolProject.Core.Features.Authentication.Commands.Models;
using SchoolProject.Core.Features.Students.Commands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Authentication.Commands.Validations
{
    public class SignInValidator : AbstractValidator<SignInCommand>
	{
		#region Fileds

		#endregion

		#region Constructor
		public SignInValidator()
		{
			ApplyValidationRules();
			
		}
		#endregion

		#region Handels Method
		public void ApplyValidationRules()
		{
			RuleFor(x => x.UserName)
				.NotEmpty().WithMessage("UserName must not Empty !")
				.NotNull().WithMessage("UserName must not null ")
				.MaximumLength(20).WithMessage("UserName Max Length 20 ")
				.MinimumLength(3).WithMessage("UserName  Min Length 3  ");

			RuleFor(x => x.Passward)
				.NotEmpty().WithMessage("Passward must not Empty !")
				.NotNull().WithMessage("Passward must not null ")
				.MaximumLength(40).WithMessage("Passward Max Length 40 ")
				.MinimumLength(3).WithMessage("Passward  Min Length 3  ");
		}

	
		#endregion

	}
}
