using FluentValidation;
using SchoolProject.Core.Features.Students.Commands.Models;


namespace SchoolProject.Core.Features.Students.Commands.Validations
{
	public class EditStudentValodator : AbstractValidator<EditeStudentCommands>
	{
		#region Constructor
		public EditStudentValodator()
		{
			ApplyValidationRules();
			
		}
		#endregion

		#region Handels Method
		public void ApplyValidationRules()
		{
			RuleFor(x => x.Name)
				.NotEmpty().WithMessage("Name must not Empty !")
				.NotNull().WithMessage("Name must not null ")
				.MaximumLength(20).WithMessage("Name Max Length 20 ")
				.MinimumLength(3).WithMessage("Name  Min Length 3  ");

			RuleFor(x => x.Address)
				.NotEmpty().WithMessage("Adress must not Empty !")
				.NotNull().WithMessage("{PropertyValue} must not null ")
				.MaximumLength(40).WithMessage("Adress Max Length 40 ")
				.MinimumLength(3).WithMessage("Adress  Min Length 3  ");
		}
		#endregion
	}
}
