using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05;
	public class TaskA
	{
		public string ReverseName()
		{
			string name1 = "George";
			string reverseString = string.Empty;

			for (int i = name1.Length - 1; i >= 0; i--)
			{
				reverseString += name1[i];
			}

			return reverseString;


		}

	}

