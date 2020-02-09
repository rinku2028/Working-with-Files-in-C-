using System;
using System.IO;

namespace deleteallfiles
{
    class deleteallfiles
    {
       //How to delete all files(*.*) from a folder in C#.


        static void Main(string[] args)
        {
            try
            {
                string[] filePaths = Directory.GetFiles(@"c:\mydir\");
                foreach (string filePath in filePaths)
                    File.Delete(filePath);
                Console.WriteLine("The files has been deleted in c drive of mydir folder.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Location of the folder cannot be found!");

            }
            Console.ReadLine();
        }
    }
}
