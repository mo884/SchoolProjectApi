using AutoMapper;
using MediatR;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.User.Commands.Models;
using SchoolProject.Core.Features.Users.Commands.Models;
using SchoolProject.Core.SharedResource;
using SchoolProject.Data.Entites.Identity;

namespace SchoolProject.Core.Features.Users.Commands.Handlers
{
	public class UserCommandHandler : ResponseHandler,
		IRequestHandler<AddUserCommand, Response<string>>,
		IRequestHandler<EditUserCommand, Response<string>>,
		IRequestHandler<DeleteUserCommand, Response<string>>
	{

		#region Fildes
		private readonly IMapper mapper;
		private readonly UserManager<SchoolProject.Data.Entites.Identity.User> _userManager;
		private readonly IStringLocalizer<SharedResources> stringLocalizer;

		#endregion


		#region Constructor
		public UserCommandHandler(IMapper mapper, UserManager<SchoolProject.Data.Entites.Identity.User> user, IStringLocalizer<SharedResources> stringLocalizer)
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
			var identityUser = mapper.Map<SchoolProject.Data.Entites.Identity.User>(request);

			//Check Email is Exist 
			var user_Email_Is_Exist = await _userManager.FindByEmailAsync(request.Email);
			//Exist
			if (user_Email_Is_Exist is not null)
				return BadRequest<string>(stringLocalizer[SharedResourceKey.EmailIsExist]);
			//Creat
			var createResult = await _userManager.CreateAsync(identityUser, request.Password);
			//Create Not Sucess
			if (!createResult.Succeeded)
				return BadRequest<string>(stringLocalizer[SharedResourceKey.RegistrationNotSuccessed]);
			//Create Sucess
			return Success<string>(stringLocalizer[SharedResourceKey.RegistrationSuccessed]);
		}

		public async Task<Response<string>> Handle(EditUserCommand request, CancellationToken cancellationToken)
		{
			//check if user is exist
			var oldUser = await _userManager.FindByIdAsync(request.Id.ToString());
			//if Not Exist notfound
			if (oldUser == null) return NotFound<string>();
			//mapping
			var newUser = mapper.Map(request, oldUser);

			//if username is Exist
			var userByUserName = await _userManager.Users.FirstOrDefaultAsync(x => x.UserName == newUser.UserName && x.Id != newUser.Id);
			//username is Exist
			if (userByUserName != null) return BadRequest<string>(stringLocalizer[SharedResourceKey.EmailIsExist]);

			//update
			var result = await _userManager.UpdateAsync(newUser);
			//result is not success
			if (!result.Succeeded) return BadRequest<string>("Not Updated");
			//message
			return Success("Updated");
		}

		public async Task<Response<string>> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
		{
			//check if user is exist
			var user = await _userManager.FindByIdAsync(request.Id.ToString());
			//if Not Exist notfound
			if (user == null) return NotFound<string>();
			//Delete the User
			var result = await _userManager.DeleteAsync(user);
			//in case of Failure
			if (!result.Succeeded) return BadRequest<string>("Delete Faild");
			return Success("IS Deleted");
		}
	
		#endregion
	}
}
