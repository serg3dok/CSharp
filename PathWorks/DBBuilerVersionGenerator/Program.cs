using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace DBBuilerVersionGenerator
{
    class Program
    {
        static void Main(string[] args) // Expected 2 arguments: [0] source location, [1] database type
        {

            string src = args[0];
            string databaseType = args[1];
            string version = args[2];
            string gotoSrcLocation = String.Format(@"{0}\DBBuilder", src);
            string cmdArgs = String.Format(@" /wait DBBuilder.exe -s -q:C:\Oracle\11.2.0\dbhome_1\BIN\sqlplus.exe -c:{0}", databaseType);
            const string key = @"SOFTWARE\Wow6432Node\Omnicell\DBBuilder";

            RegistryKey rk = Registry.LocalMachine.OpenSubKey(key, false);
            RegistryKey rkw = Registry.LocalMachine.OpenSubKey(key, true);
            string exitCode = "";
            string previousVersion = "";


            object versionObject = rk.GetValue("Version");
            if(versionObject != null)
            {
                previousVersion = versionObject.ToString();
                Console.WriteLine("Version: {0}", version);
            }
            

            if (previousVersion != version || previousVersion == null)
            {
                 //Run DBBuilder...
                Process process = new System.Diagnostics.Process();
                ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo()
                {
                    WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
                    FileName = @"C:\Windows\SysWOW64\cmd.exe",
                    WorkingDirectory = gotoSrcLocation,
                    RedirectStandardInput = true,
                    UseShellExecute = false
                };

                process.StartInfo = startInfo;
                process.Start();

                process.StandardInput.WriteLine(@"start " + cmdArgs);
                process.StandardInput.WriteLine(@"start " + cmdArgs); 

            }

           


            //Read ExitCode from Registry
            object exitCodeObject = rk.GetValue("ExitCode");
            exitCode = exitCodeObject.ToString();
            Console.WriteLine("Exit Code: {0}", exitCode);
            if (exitCode != "0")
            {
                Console.WriteLine("Exit code: " + exitCode);
                Registry.SetValue(key, "Version", "0.0.0.0"); // Write bad version if exception throwed
                Environment.Exit(0);

            }


            // Write new version to registry
            if (Int32.Parse(exitCode) == 0)
            {
                //previousVersion = (Int32.Parse(version) + 1).ToString();
                //Registry.SetValue(key, "Version", "0.0.0." + version);
                rkw.SetValue("Version", "0.0.0." + version);
                
            }

            string a = Console.ReadLine();
        }


    }
}
