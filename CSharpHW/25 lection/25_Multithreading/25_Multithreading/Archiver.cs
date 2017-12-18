using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ICSharpCode.SharpZipLib.Zip;
using ZipFile = System.IO.Compression.ZipFile;

namespace _25_Multithreading
{
    class Archiver
    {
        Semaphore sem = new Semaphore(Environment.ProcessorCount, Environment.ProcessorCount);

        public Archiver(string path)
        {
            var thread = new Thread(Zipping);
            thread.Start(path);
        }

        void Zipping(object obj)
        {
            sem.WaitOne();
            //lock (obj)
            {
                string pathFile = obj.ToString();
                var dirName = Path.GetDirectoryName(pathFile);
                var fullZipName = dirName + "\\" + Path.GetFileNameWithoutExtension(pathFile) + ".zip";
                var fileName = Path.GetFileName(pathFile);

                //ZipFile.CreateFromDirectory( dirName.ToString(), zipName );
                FastZip zip = new FastZip();
                string filter = string.Format(@"{0};-\.zip$", fileName);
                zip.CreateZip(fullZipName, dirName, false, filter);
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}");

            }
            sem.Release();
        }
    }
}