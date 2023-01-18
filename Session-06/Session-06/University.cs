using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
	public class University : Institute
	{

		//properties
		public Student[]? Students { get; set; }
		public Course[]? Courses { get;set; }
		public Grade[]? grades { get; set; }
		public Schedule[]? ScheduledCourse { get; set; }

		//methods
		public void GetStudents()
		{

		}

		public void GetCourses() 
		{ 

		}

		public void GetGrades()
		{

		}

		public void SetSchedule( string CourseID, string ProfessorID, int datetime)
		{

		}

	}
}
