using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static int[] GenerateArray(int n)
        {
            int[] arr = new int[n];
            int count = default(int);
            var value = default(int);
            var pos = default(int);
            Random random = new Random();
            pos = random.Next(0,n);
            for (int i = 0; i < n; i++)
            {
                if (i == pos)
                {
                    if (count == 0)
                    {
                        arr[i] = value++;
                        count = 0;
                    }
                    else
                    {
                        arr[i] = ++value;
                        count = 1;
                    }
                }
                else
                {
                    arr[i] = value;
                    count++;
                }
                if (count == 2)
                {
                    value++;
                    count = 0;
                }
            }
            Console.WriteLine(pos);
            return arr;
        }

        static int Method(int[] arr)
        {
            if (arr[0] != arr[1])
            {
                return arr[0];
            }
            else
            {
                for (int i = 1; i < arr.Length - 1; i++)
                {
                    if (arr[i] != arr[i - 1] && arr[i] != arr[i + 1])
                    {
                        return arr[i];
                    }
                }
            }
            return arr.Last();
        }

        static void Main(string[] args)
        {
            int[] arr = GenerateArray (1001);
            foreach (int el in arr)
            {
                Console.Write("{0} ", el);
            }
            var theOne = Method(arr);
            Console.WriteLine(theOne.ToString());
            Console.ReadKey();
        }
    }
}
