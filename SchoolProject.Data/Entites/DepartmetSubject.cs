﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Entites
{
	public class DepartmetSubject
	{
		[Key]
		public int StudSubID { get; set; }
		public int StudID { get; set; }
		public int SubID { get; set; }

		[ForeignKey("StudID")]
		public virtual Student Student { get; set; }

		[ForeignKey("SubID")]
		public virtual Subjects Subject { get; set; }
	}
}
