using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
	internal class Task5
	{
		public void SortNumbers(){

			int[] arr = new int[] { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };

			Array.Sort(arr);
			Console.WriteLine("Ascending: ");
			foreach (int value in arr)
			{
				Console.Write(value + " ");
			}

		}
	}
}
