using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace allfiles
{
    class getdirectory
    {
        static void Main(string []args)
        {
            string path = Path.GetDirectoryName(Assembly.GetAssembly(typeof(getdirectory)).CodeBase);
            Console.WriteLine(path);//Prints the location of Directory of the class file
            Console.ReadLine();

        }
    }
}
