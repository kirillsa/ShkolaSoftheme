using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static int[] GenerateArray(int n)
        {
            var arr = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(0, n);
            }
            return arr;
        }

        static int[] SortArray(int[] arr)
        {
            var temp = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }

        static void ShowInfo(int[] arr)
        {
            foreach (int el in arr)
            {
                Console.Write("{0} ", el);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            var array = GenerateArray(10);
            ShowInfo(array);
            array = SortArray(array);
            ShowInfo(array);
            Console.ReadKey();

        }
    }
}