using System;
using System.IO;

namespace writetofile
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Write text to the file!";  
            File.WriteAllText("filename.txt", str);  // Creates a file name filename.txt and write the content of string str to the file created

            string readText = File.ReadAllText("filename.txt");  // Read the contents of the file named filename.txt
            Console.WriteLine("Content of file:"+"\t"+readText);  // Output of the content
            Console.ReadLine();
        }
    }
}
