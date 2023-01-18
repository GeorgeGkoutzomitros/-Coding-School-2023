using System;
using System.Collections.Generic;
using System.Linq;
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

	public class ActionResolver
	{
		//properties
		public MessageLogger Logger { get; set; }

		//ctor
		public ActionResolver()
		{
			Logger = new MessageLogger();
		}

		//methods
		public ActionResponse Execute(ActionRequest request)
		{

			ActionResponse response = new ActionResponse();
			response.ResponseID = Guid.NewGuid();
			response.RequestID = request.RequestID;

			Log("EXECUTION START");

			try
			{

				switch (request.Action)
				{
					case ActionEnum.Convert:
						Log("CONVERT");
						response.Output = Convert(request.Input);
						break;

					case ActionEnum.Uppercase:
						Log("UPPERCASE");
						response.Output = Uppercase(request.Input);
						break;

					case ActionEnum.Reverse:
						Log("REVERSE");
						response.Output = Reverse(request.Input);
						break;

					default:
						Console.WriteLine("please select another type");
						break;
				}
			}
			catch (Exception ex)
			{
				Log(ex.Message);

			}
			finally
			{
				Log("EXECUTION END");
			}


			return response;
		}



		private void Log(string text)
		{

			Logger.Write(new Message("------------"));

			Message message = new Message(text);
			Logger.Write(message);
		}

		public string Convert(string input)
		{

			StringConvert convert = new StringConvert();
			convert.Text = input;

			return convert.Manipulate();
		}

		public string Uppercase(string input)
		{
			StringUppercase uppercase= new StringUppercase();
			uppercase.Text = input;

			return uppercase.Manipulate();
		}

		public string Reverse(string input)
		{
			StringReverse reverse = new StringReverse();
			reverse.Text = input;

			return reverse.Manipulate();

		}

	}
	
}
