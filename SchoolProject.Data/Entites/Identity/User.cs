using Microsoft.AspNetCore.Identity;


namespace SchoolProject.Data.Entites.Identity
{
	public class User:IdentityUser<int>
	{
        public string FullName { get; set; }
    }
}
