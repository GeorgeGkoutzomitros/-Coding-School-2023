﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
	public class Grade
	{
		//properties
		public Guid ID { get; set; }
		public Guid StudentID { get; set; }
		public Guid CourseID { get; set; }
		public int Grades { get; set; }
	}
}
