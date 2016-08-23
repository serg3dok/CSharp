using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;


namespace ZipArchivator
{
    class Program
    {
        static void Main(string[] args)
        {
            string dropLocation = @"C:\Temp\ArcTest";
            string outputLocation = @"C:\Temp\test.zip";


            ZipFile.CreateFromDirectory(dropLocation, outputLocation, CompressionLevel.Optimal, true);



        }
    }
}
