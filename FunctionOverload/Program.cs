using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculate;
namespace FunctionOverload
{
	class Program
	{
		static void Main(string[] args)
		{
			Calculate.Calculate T = new Calculate.Calculate();

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

