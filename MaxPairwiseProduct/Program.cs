using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxPairwiseProductFast
{
    class Program
    {
        static void Main(string[] args)
        {

            //string s = "I am new to Bangalore";
            //char[] charArray = s.ToCharArray();
            //var c = charArray.Where(x => x == 'a').Count();//s.Count(x => x == 'a');
            //Console.WriteLine(c);
            //Console.ReadLine();

            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int index1 = -1;
            for (int i = 0; i < n; i++)
            {
                if (index1 == -1 || array[i] > array[index1])
                    index1 = i;
            }
            int index2 = -1;
            for (int i = 0; i < n; i++)
            {
                if (index2 == -1 || (array[i] != array[index1] && array[i] > array[index2]))
                    index2 = i;
            }
            Console.WriteLine(array[index1] * array[index2]);
            Console.ReadLine();
        }
    }
}
