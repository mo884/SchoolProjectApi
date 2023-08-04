using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Localization;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Authentication.Commands.Models;
using SchoolProject.Core.Features.User.Commands.Models;
using SchoolProject.Core.Features.Users.Commands.Models;
using SchoolProject.Core.SharedResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Authentication.Commands.Handlers
{
	public class AuthenticationHandler : ResponseHandler,
		IRequestHandler<SignInCommand, Response<string>>
	{
		#region Fildes
		private readonly IMapper mapper;
		private readonly UserManager<SchoolProject.Data.Entites.Identity.User> _userManager;
		private readonly IStringLocalizer<SharedResources> stringLocalizer;

		#endregion


		#region Constructor
		public AuthenticationHandler(IMapper mapper, UserManager<SchoolProject.Data.Entites.Identity.User> user, IStringLocalizer<SharedResources> stringLocalizer)
		{
			this.mapper = mapper;
			this._userManager = user;
			this.stringLocalizer = stringLocalizer;
		}


		#endregion

		#region Handles Function
		public async Task<Response<string>> Handle(SignInCommand request, CancellationToken cancellationToken)
		{
			////Check if user is exist or not
			//var User = await _userManager.FindByNameAsync(request.UserName);
			////Return The UserName Not Found
			//if (User == null) return BadRequest<JwtAuthResult>(stringLocalizer[SharedResourceKey.EmailIsExist]);
			////try To Sign in 
			//var signInResult = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);
			////if Failed Return Passord is wrong
			//if (!signInResult.Succeeded) return BadRequest<JwtAuthResult>(_stringLocalizer[SharedResourcesKeys.PasswordNotCorrect]);
			////confirm email
			//if (!User.EmailConfirmed)
			//	return BadRequest<JwtAuthResult>(_stringLocalizer[SharedResourcesKeys.EmailNotConfirmed]);
			////Generate Token
			//var result = await _authenticationService.GetJWTToken(user);
			////return Token 
			return Success("");
		}

		#endregion
	}
}
