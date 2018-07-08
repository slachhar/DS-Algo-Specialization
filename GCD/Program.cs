using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give 2 nos for GCD");
            int a = int.Parse(Console.ReadLine().Split(' ')[0]);
            int b = int.Parse(Console.ReadLine().Split(' ')[0]);

            Console.WriteLine(b);
            Console.ReadLine();
        }

        public int GCD(int a, int b)
        {
            int remainder = a % b;
            if (remainder > 0)
            {
                for (int i = 0; remainder > 0; i++)
                {
                    a = b;
                    b = remainder;
                    remainder = a % b;
                }
            }
            //else
            //{
            //    b = remainder;
            //}
            return b;
        }
    }
}
