using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class ReArray
    {
        public int[] Array;

        public ReArray(int n)
        {
            Array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                Array[i] = random.Next(0, n);
            }
        }

        public void Add(params int[] elements)
        {
            int[] bufArray = new int[Array.Length + elements.Length];
            for (int i = 0; i < Array.Length; i++)
            {
                bufArray[i] = Array[i];
            }
            for (int i = Array.Length; i < Array.Length + elements.Length; i++)
            {
                bufArray[i] = elements[i - Array.Length];
            }
            Array = bufArray;
        }

        public bool Contains(int element)
        {
            for (int i=0; i < Array.Length; i++)
            {
                if (Array[i] == element)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetByIndex(int index)
        {
            try
            {
                return Array[index];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public void ShowInfo()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write("{0} ",Array[i].ToString());
            }
            Console.WriteLine();
        }
    }
}
