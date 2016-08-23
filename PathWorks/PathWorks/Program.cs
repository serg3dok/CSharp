using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PathWorks
{
    class OraclePathMover
    {

        private static readonly string OldPath = Environment.GetEnvironmentVariable("Path");
        private static string newPath;
        
        static void Main(string[] args)
        {


            newPath = "C:\\Oracle\\11.2.0\\dbhome_1\\bin;C:\\Oracle\\11.2.0\\client_1\\bin;" + OldPath.Replace("C:\\Oracle\\11.2.0\\dbhome_1\\bin;", "");
            Environment.SetEnvironmentVariable("Path", null, EnvironmentVariableTarget.Machine);
            if (Environment.GetEnvironmentVariable("Path") == null)
            {
                Console.WriteLine("Path removed");
            }
            Environment.SetEnvironmentVariable("Path", newPath, EnvironmentVariableTarget.Machine);
            if (Environment.GetEnvironmentVariable("Path") != null)
            {
                Console.WriteLine("Path added\n");
            }
            //Console.WriteLine(OldPath);
            //Console.WriteLine("_", 30);
            //Console.WriteLine(newPath);
            //Thread.Sleep(25000);

            
            

        }
    }
}
