using System;
using Calculate;
namespace Test
{
	class Program
	{
		static void Main(string[] args)
		{
			Calculate T = new Calculate();

			Console.WriteLine(T.Calc(7, 8));
			Console.ReadKey();
		}
	}

	
}

namespace Calculate
{
	class Calculate
	{
		internal int Calc(int x, int y) 
		{
			return x + y;
		}

		internal int Calc(int x, int y, int z)
		{
			return x + y + z;
		}
	}
}
