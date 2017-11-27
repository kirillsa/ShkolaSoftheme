using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Indexers
{
    class Program
    {
        static int[] InputLotery(int[] arr)
        {
            var inputInt = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Please enter 6 numbers from 1 to 9");
                    Console.WriteLine($"Number {i + 1} is ");
                    var inputS = Console.ReadLine();
                    if (!int.TryParse(inputS, out inputInt))
                    {
                        continue;
                    }
                }
                while (inputInt < 1 || inputInt > 9);
                arr[i] = inputInt;
            }
            return arr;
        }

        static bool CheckTicket( RandomArr lotery, int[] ticket )
        {
            for (var i = 0; i < ticket.Length; i++)
            {
                for (var j = 0; j < lotery.GetLength(); j++)
                {
                    if (ticket[i] == lotery[j])
                    {
                        break;
                    }
                    else if (j == lotery.GetLength()-1 && ticket[i] != lotery[lotery.GetLength()-1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static void ShowArr(int[] arr)
        {
            Console.Write("It's your ticket: ");
            for (var i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            var arr = new int[6];
            arr = InputLotery(arr);
            var arrLotery = new RandomArr(arr.Length);
            if (CheckTicket(arrLotery, arr))
            {
                Console.Clear();
                Console.WriteLine("You win");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You lost");
            }
            ShowArr(arr);
            arrLotery.ShowInfo();
            Console.ReadKey();

        }
    }
}
