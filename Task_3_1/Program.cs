using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Task_2_4
{
	class Programm
	{
		static double f(int n)
		{
			return (double)(Math.Sqrt(n) + n);
		}

		static void Main(string[] agrs)
		{
			double res = (f(6) / 2) + (f(13) / 2) + (f(21) / 2);

			Console.WriteLine("{0:f2}", res);
		}
	}
}