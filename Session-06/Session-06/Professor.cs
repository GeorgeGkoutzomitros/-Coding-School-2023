using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
	public class Professor :Person {
		
		//properties
		public string? Rank { get; set; }
		public Course[]? Courses { get; set; }

		//methods
		public void Teach(string course , int datetime)
		{

		}

		public void SetGrade(string studentID, int courseID, int grade)
		{

		}

		public void GetName() {
		
		}

	
	}
	



}
