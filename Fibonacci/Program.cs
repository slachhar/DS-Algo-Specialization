using System;
using System.Collections.Generic;

namespace Fibonacci
{
	public class Program
	{
	
		

		public static void Main(String[] args)
		{

			Console.WriteLine("Please enter n for Fibbo and m for Modulus");
			long n = long.Parse(Console.ReadLine());
			int m = int.Parse(Console.ReadLine());

			Console.WriteLine(get_fibonacci_huge(n, m));
			Console.ReadLine();
		}

		public static long get_pisano_period(long m)
		{
			long a = 0, b = 1, c = a + b;
			for (int i = 0; i < m * m; i++)
			{
				c = (a + b) % m;
				a = b;
				b = c;
				if (a == 0 && b == 1)
					return i + 1;
			}

			return 0;
		}

		public static long get_fibonacci_huge(long n, long m)
		{
			long remainder = n % get_pisano_period(m);

			long first = 0;
			long second = 1;

			long res = remainder;

			for (int i = 1; i < remainder; i++)
			{
				res = (first + second) % m;
				first = second;
				second = res;
			}

			return res % m;
		}
		#region commented code
		//    static void Main(string[] args)
		//    {
		//        String approval = "Y";
		//        while (approval.ToLower() == "y")
		//        {
		//            Console.WriteLine("Please enter n for Fibbo and m for Modulus");
		//long n = long.Parse(Console.ReadLine());
		//long m = long.Parse(Console.ReadLine());
		//decimal[] fibArray = new decimal[n+1];
		//decimal[] mod = new decimal[n+1];
		//            fibArray[0] = 0;

		//mod[0] = 0;

		//long lengthOfPeriod = 0;

		//long smallerFibbo = 0;
		//decimal solution = 0;

		//if (n > 0)
		//{
		//	fibArray[1] = 1;
		//	mod[1] = 1;
		//	for (long i = 2; n >= 2; i++)
		//	{
		//		fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
		//		mod[i] = fibArray[i] % m;
		//		if (mod[i] == 1 && mod[i - 1] == 0)
		//		{
		//			lengthOfPeriod = i - 1;
		//			smallerFibbo = n % m;
		//			solution = fibArray[smallerFibbo] % m;
		//			break;
		//		}

		//	}
		//	if(n == 1)
		//	{
		//		solution = fibArray[1] % m;
		//	}
		//}
		//else
		//{
		//	solution = fibArray[0] % m;
		//}
		////foreach (int number in fibArray)
		//////{
		////int lastDigitOfFibbo = Convert.ToInt32(n <= 60 ? (fibArray[n - 1] % 10) : (fibArray[(n % 60) - 1] % 10));
		////int FibboModulus = Convert.ToInt32(n <= 60 ? (fibArray[n - 1] % m) : (fibArray[(n % 60) - 1] % m));

		//Console.WriteLine(solution);
		//            Console.ReadLine();
		//            // }
		//            Console.WriteLine("Do you want to continue?");
		//            approval = Console.ReadLine();

		//        }
		//    }
		#endregion
	}


}