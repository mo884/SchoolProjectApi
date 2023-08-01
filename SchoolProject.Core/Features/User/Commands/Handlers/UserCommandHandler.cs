using AutoMapper;
using MediatR;

using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Localization;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Users.Commands.Models;
using SchoolProject.Core.SharedResource;
using SchoolProject.Data.Entites.Identity;

namespace SchoolProject.Core.Features.Users.Commands.Handlers
{
	public class UserCommandHandler : ResponseHandler,
		IRequestHandler<AddUserCommand, Response<string>>
	{

		#region Fildes
		private readonly IMapper mapper;
		private readonly UserManager<User> _userManager;
		private readonly IStringLocalizer<SharedResources> stringLocalizer;

		#endregion


		#region Constructor
		public UserCommandHandler(IMapper mapper, UserManager<User> user, IStringLocalizer<SharedResources> stringLocalizer)
        {
            this.mapper = mapper;
			this._userManager = user;
			this.stringLocalizer = stringLocalizer;
		}
        #endregion

        #region Handles Function
        public async Task<Response<string>> Handle(AddUserCommand request, CancellationToken cancellationToken)
		{
			//mapping
			var identityUser = mapper.Map<User>(request);

			//Check Email is Exist 
			var user_Email_Is_Exist = await _userManager.FindByEmailAsync(request.Email);
			//Exist
			if (user_Email_Is_Exist is not null)
				return BadRequest<string>(stringLocalizer[SharedResourceKey.EmailIsExist]);
			//Creat
			var createResult = await _userManager.CreateAsync(identityUser,request.Password)
			//Create Field
			if(!createResult.Succeeded)
				return BadRequest<string>(stringLocalizer[SharedResourceKey.RegistrationNotSuccessed]);
			//Create Sucess
			return Success<string>(stringLocalizer[SharedResourceKey.RegistrationSuccessed]);
		}
		#endregion
	}
}
