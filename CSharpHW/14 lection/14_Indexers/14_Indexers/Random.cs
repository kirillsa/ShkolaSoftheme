using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Indexers
{
    class RandomArr
    {
        private int[] _arr;

        public RandomArr(int n)
        {
            _arr = new int[n];
            var rand = new Random();
            for (var i = 0; i < _arr.Length; i++)
            {
                _arr[i] = rand.Next(1,10);
            }
        }
        public int this[int i] => _arr[i];

        public int GetLength()
        {
            return _arr.Length;
        }

        public void ShowInfo()
        {
            Console.Write("It's a lotery numbers: ");
            for (var i = 0; i < _arr.Length; i++)
            {
                Console.Write($"{_arr[i]} ");
            }
            Console.WriteLine();
        }
    }
}
