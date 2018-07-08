using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            String approval = "Y";
            while (approval.ToLower() == "y")
            {
                Console.WriteLine("Please enter n for Fibbo and m for Modulus");
                long n = long.Parse(Console.ReadLine());
                long m = long.Parse(Console.ReadLine());
                long[] fibArray = new long[n];
                fibArray[0] = 1;
                fibArray[1] = 1;
                for (long i = 2; i < (n <= 60 ? n : 60); i++)
                {
                    fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
                }
                //foreach (int number in fibArray)
                //{
                int lastDigitOfFibbo = Convert.ToInt32(n <= 60 ? (fibArray[n - 1] % 10) : (fibArray[(n % 60) - 1] % 10));
                int FibboModulus = Convert.ToInt32(n <= 60 ? (fibArray[n - 1] % m) : (fibArray[(n % 60) - 1] % m));
                Console.WriteLine(FibboModulus);
                Console.ReadLine();
                // }
                Console.WriteLine("Do you want to continue?");
                approval = Console.ReadLine();

            }
        }
    }
}
