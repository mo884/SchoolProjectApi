using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Data.Entites.Identity
{
	public class User:IdentityUser<int>
	{
		public User()
		{
			UserRefreshTokens = new HashSet<UserRefreshToken>();
		}
		public string FullName { get; set; }
		//[EncryptColumn]
		public string? Code { get; set; }
		[InverseProperty(nameof(UserRefreshToken.user))]
		public virtual ICollection<UserRefreshToken> UserRefreshTokens { get; set; }
	}
}
