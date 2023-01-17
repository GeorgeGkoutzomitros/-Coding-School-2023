using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
	public class Message
	{

		//properties
		public Guid ID { get; set; }
		public DateTime TimeStamp { get; set; }
		public string Messages { get; set; }

		//contructors
		public Message()
		{

		}

		public Message(Guid id)
		{
			ID = id;
		}

		public Message(Guid id, DateTime stamp)
		{
			ID = id;
			TimeStamp = stamp;
		}

		public Message(Guid id, DateTime stamp, string messages) {

			ID = id;
			TimeStamp = stamp;
			Messages = messages;

		}

	}	
	
}
