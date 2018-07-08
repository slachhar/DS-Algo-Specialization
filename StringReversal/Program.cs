using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReversal
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "Hi I am new to Bangalore";
            char[] c = s.ToCharArray();

            for (int i = c.Length - 1; i >= 0; i--)
            {
                Console.Write(c[i]);
            }
            Console.ReadLine();
        }
    }
}
