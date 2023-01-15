using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
	internal class Task2
	{

		public void SumProduct()
		{

			int i, product = 1, sum = 0;

			Console.WriteLine("Input  a number(integer): ");
			int n = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Would you like to compute the sum(press s) or the product(press p)");
			string chooseCompute = Console.ReadLine();

			
			if ( chooseCompute == "s") {

				for (i = 1; i<= n; i++) 
				{
					sum = sum + i;
					
				}
				Console.WriteLine(sum);
			}
			if ( chooseCompute == "p") {

				for (i = 1; i <= n;i++)
				{
					product = product * i;
					Console.WriteLine(product);
				}
				Console.WriteLine(product);
			}
			
		}
	}
}
