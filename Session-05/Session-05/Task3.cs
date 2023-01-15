using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
	public class Task3
	{
		public void PrimeNumbers() {


			int i, j, isPrime;

			Console.WriteLine("Input  a number(integer): ");
			int n = Convert.ToInt32(Console.ReadLine());

			for (i = 2; i <= n; i++)
			{
				isPrime = 1;

				for (j=2; j<i/2; j++)
				{

					if (i%j == 0)
					{

						isPrime = 0; break;
					}
				}

				if (isPrime == 1 )
				{

					Console.WriteLine(i);
				}
			}

			

		}
	}
}
