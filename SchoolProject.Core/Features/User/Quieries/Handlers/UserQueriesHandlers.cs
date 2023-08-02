using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Localization;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.User.Quieries.Models;
using SchoolProject.Core.Features.User.Quieries.Response;
using SchoolProject.Core.SharedResource;


namespace SchoolProject.Core.Features.Users.Quieries.Handlers
{
	public class UserQueriesHandlers : ResponseHandler

		, IRequestHandler<GetListUserQuerey, Response<List<GetListUserResponse>>>
	{
		#region Fieldes
		private readonly UserManager<SchoolProject.Data.Entites.Identity.User> user;
		private readonly IMapper mapper;
		private readonly IStringLocalizer<SharedResources> stringLocalizer;
		#endregion

		#region Constructor
		public UserQueriesHandlers(UserManager<SchoolProject.Data.Entites.Identity.User> user, IMapper mapper, IStringLocalizer<SharedResources> stringLocalizer)
		{
			this.user = user;
			this.mapper = mapper;
			this.stringLocalizer = stringLocalizer;
		}
		#endregion

		#region Handles  Function
		public async Task<Response<List<GetListUserResponse>>> Handle(GetListUserQuerey request, CancellationToken cancellationToken)
		{
			var users =  user.Users.AsQueryable();
			var UserMapping = mapper.Map<List<GetListUserResponse>>(users);

			return Success( UserMapping);
		}
		#endregion
	}
}
