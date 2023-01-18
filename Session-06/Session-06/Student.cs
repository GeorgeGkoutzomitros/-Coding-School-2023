using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
	public class Student : Person { 
	

		//properties 
		public int RegistrationNumber { get; set; }
		public Course[]? Courses { get; set; }

		//methods
		public void Attend (string course, string datetime) 
		{

		}

		public void WriteExam(string course, string datetime) 
		{ 
		
		}

	}
	
}
