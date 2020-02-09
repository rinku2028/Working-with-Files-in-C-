using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace deleteallfiles
{
    class readfile
    {
        static void Main(string []args)
        {
            string text;
            using (var streamReader = new StreamReader(@"e:\file.txt", Encoding.UTF8))
            {
                text = streamReader.ReadToEnd();
                Console.WriteLine(text);
            }
            Console.ReadLine();
        }
    }
}
