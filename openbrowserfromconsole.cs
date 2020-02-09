using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace allfiles
{
    class openbrowserfromconsole
    {
        static void Main(string[] args)
        {
            Process myProcess = new Process();

            try
            {
                // true is the default, but it is important not to set it to false
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = "http://google.com";
                myProcess.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
