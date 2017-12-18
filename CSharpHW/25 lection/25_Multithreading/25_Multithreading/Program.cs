using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            var startDir = "asd";
            Directory.EnumerateFiles(startDir);
            GoThroughDirectories(startDir);
            Console.ReadKey();
        }

        static void GoThroughDirectories(string startPath)
        {
            var dirsList = Directory.EnumerateDirectories(startPath);
            foreach (var dir in dirsList)
            {
                GoThroughDirectories(dir);
            }

            var filesList = Directory.EnumerateFiles(startPath);
            foreach (var file in filesList)
            {
                if (Path.GetExtension(file) == ".zip")
                {
                    continue;
                }
                else
                {
                    var archive = new Archiver(file);
                }
            }
        }
    }
}