using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] lst = { 4, 9, 7, 1, 3, 6, 5 };
            int minimum;
            for (int i = 0; i < lst.Length; i++)
            {
                minimum = lst[i];
                int index = i;
                for (int j = i; j < lst.Length; j++)
                {
                    if (lst[j] < minimum)
                    {
                        minimum = lst[j];
                        index = j;
                    }
                }

                int temp = lst[i];
                lst[i] = minimum;
                lst[index] = temp;
            }

            Console.WriteLine(string.Join(",", lst));
            Console.ReadLine();
        }
    }
}
