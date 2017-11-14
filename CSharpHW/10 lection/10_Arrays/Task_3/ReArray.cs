using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class ReArray
    {
        public int[] _array { get; set; }

        public ReArray(int n)
        {
            _array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                _array[i] = random.Next(0, n);
            }
        }

        public void Add(params int[] elements)
        {
            int[] bufArray = new int[_array.Length + elements.Length];
            for (int i = 0; i < _array.Length; i++)
            {
                bufArray[i] = _array[i];
            }
            for (int i = _array.Length; i < _array.Length + elements.Length; i++)
            {
                bufArray[i] = elements[i - _array.Length];
            }
            _array = bufArray;
        }

        public bool Contains(int element)
        {
            for (int i=0; i < _array.Length; i++)
            {
                if (_array[i] == element)
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
                return _array[index];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public void ShowInfo()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                Console.Write("{0} ",_array[i].ToString());
            }
            Console.WriteLine();
        }
    }
}
