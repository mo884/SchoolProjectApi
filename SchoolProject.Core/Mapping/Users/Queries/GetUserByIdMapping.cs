using SchoolProject.Core.Features.User.Quieries.Response;
using SchoolProject.Data.Entites.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Mapping.Users
{
	public partial class UserProfile
	{
		public void GetUserByIdMapping()
		{
			CreateMap<User, GetUserByIdResponse>()

				.ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))

				.ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
				.ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName));
		}


	}
}
