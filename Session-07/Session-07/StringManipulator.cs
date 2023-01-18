using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_07
{
	
	public class StringManipulator
	{

		public string Text { get; set; }

		public virtual string Manipulate()
		{

			return string.Empty;
		}

	}

	public class StringConvert : StringManipulator
	{


		public override string Manipulate()
		{
			string result = string.Empty;

			int num = Convert.ToInt32(Text);
			result = "";
			while (num > 1)
			{
				int remainder = num % 2;
				result = Convert.ToString(remainder) + result;
				num /= 2;
			}
			result = Convert.ToString(num) + result;
			//Console.WriteLine("Binary: {0}", result);

			return result;
		}
	}

	public class StringReverse : StringManipulator
	{

		public override string Manipulate()
		{

			string reverseString = string.Empty;

			for (int i = Text.Length - 1; i >= 0; i--)
			{
				reverseString += Text[i];
			}

			return reverseString;

		}

	}

	public class StringUppercase : StringManipulator
	{

		public override string Manipulate()
		{
			
			

				return string.Empty.ToUpper();
			

			
		}
	}
}
