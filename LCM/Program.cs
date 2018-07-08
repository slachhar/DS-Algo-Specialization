using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GCD;

namespace LCM
{
    class Program
    {
        static void Main(string[] args)
        {
            String approval = "Y";
            while (approval.ToLower() == "y")
            {
                Console.WriteLine("Please give 2 nos for LCM");
                int a = int.Parse(Console.ReadLine().Split(' ')[0]);
                int b = int.Parse(Console.ReadLine().Split(' ')[0]);
                Program lcm = new Program();
                Console.WriteLine(lcm.LCM(a, b));
                Console.ReadLine();
                Console.WriteLine("Do you want to continue?");
                approval = Console.ReadLine();

            }
        }

        public int LCM(int a, int b)
        {
            GCD.Program obj = new GCD.Program();
            int gcd = obj.GCD(a, b);
            int lcm = 1;
            while (gcd > 1)
            {
                lcm = lcm * gcd;
                a = a / gcd;
                b = b / gcd;
                gcd = obj.GCD(a, b);
            }

            lcm = lcm * a * b;
            return lcm;
        }
    }
}
