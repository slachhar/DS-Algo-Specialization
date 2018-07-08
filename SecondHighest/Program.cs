using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHighest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 5, 8, 9, 3, 6, 7 };
            int index1 = -1;
            for (int i = 0; i < list.Length; i++)
            {
                if (index1 == -1 || list[i] > list[index1])
                {
                    index1 = i;
                }
            }

            int index2 = -1;
            for (int i = 0; i < list.Length; i++)
            {
                if(index2==-1 || (list[i] < list[index1] && list[i] > list[index2] ))
                {
                    index2 = i;
                }
            }

            Console.WriteLine(list[index2]);
            Console.ReadLine();
        }
    }
}
