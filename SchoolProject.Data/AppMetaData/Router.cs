using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.AppMetaData
{
	public static class Router
	{
		public const string root = "Api";
		public const string version = "v1";
		public const string Rule = root+ "/"+ version + "/";

		public static class StudentRouting
		{
			public const string perfix = Rule + "Student";
			public const string List = perfix + "/List";
			public const string GetById = perfix + "/{id}";
			public const string Create = perfix + "/Create";
			public const string Edit = perfix + "/Edit";
			public const string Delete = perfix + "/Delete";
		}
		public static class DepartmentRouting
		{
			public const string perfix = Rule + "Department";
			public const string List = perfix + "/List";
			public const string GetById = perfix + "/{id}";
			public const string Create = perfix + "/Create";
			public const string Edit = perfix + "/Edit";
			public const string Delete = perfix + "/Delete";
		}

		public static class UsertRouting
		{
			public const string perfix = Rule + "User";
			public const string List = perfix + "/List";
			public const string GetById = perfix + "/{id}";
			public const string Create = perfix + "/Create";
			public const string Edit = perfix + "/Edit";
			public const string Delete = perfix + "/Delete";
			public const string ChangePassword = perfix + "/ChangePassword";
		}
	}
}
