using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
	public class CalculatorFunctions
	{

		public static double SimpleAdd(double a, double b)
		{
			return a + b;
		}

		public static double SimpleSubtract(double a, double b)
		{
			return a - b;
		}

		public static double SimpleMultiply(double a, double b)
		{
			return a * b;
		}

		public static double SimpleDivide(double a, double b)
		{
			// divide by 0 safe-guard
			// returns 0 when divided by 0
			if (a == 0 || b == 0)
				return 0;
			else
				return a / b;
		}

		public static double SimpleSquareRoot(double a)
		{
			return Math.Sqrt(a);
		}
	}
}