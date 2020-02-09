using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace deleteallfiles
{
    class getfiletime
    {
        static void Main(string []args)
        {
            FileInfo fileInfo = new FileInfo(@"E:\file.txt");

            //Creation of Local time
            DateTime creationTime = fileInfo.CreationTime;
            DateTime lastWriteTime = fileInfo.LastWriteTime;
            DateTime lastAccessTime = fileInfo.LastAccessTime;

            // UTC time
            DateTime creationTimeUtc = fileInfo.CreationTimeUtc;
            DateTime lastWriteTimeUtc = fileInfo.LastWriteTimeUtc;
            DateTime lastAccessTimeUtc = fileInfo.LastAccessTimeUtc;

            // write file last modification time (local / UTC)
            Console.WriteLine("File Created Local Time:" +lastWriteTime);     // File creation Local Time
            Console.WriteLine("File Created UTC Time:" +lastWriteTimeUtc);  // File creation UTC Time
            Console.ReadLine();
        }
    }
}
