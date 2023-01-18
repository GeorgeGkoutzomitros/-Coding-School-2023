using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
	public class Schedule
	{

		//properties
		public Guid ID { get; set; }
		public Guid CourseID { get; set; }
		public Guid ProffesorID { get; set; }
		public DateTime Callendar { get; set; }

	}
}
