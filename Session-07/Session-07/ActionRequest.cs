using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
	public enum ActionEnum
	{
		Convert,
		Uppercase,
		Reverse
	}

	public class ActionRequest
	{
		//properties 
		public Guid RequestID { get; set; }
		public string Input { get; set; }
		public ActionEnum Action {  get; set; }

		//method
		public string Calculate(ActionEnum action, string Input) {
		
			switch (action)
			{
				case ActionEnum.Convert:
					return Convert.ToString(Input);

				case ActionEnum.Uppercase:
					return Input.ToUpper();


				case ActionEnum.Reverse:
					return Input;

				default:
					Console.WriteLine("please select another type");
					break;

			}

		}

				

	}
}
