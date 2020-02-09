using System;
using System.Collections.Generic;
using System.Text;

namespace allfiles
{
    class openimage
    {
        static void Main(string []args)
        {
            //opens default given image from e drive
            System.Diagnostics.Process.Start(@"e:\image.jpg");

        }
    }
}
