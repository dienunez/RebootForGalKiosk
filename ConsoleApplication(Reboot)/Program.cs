using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication_Reboot_
{
    class Program
    {
        public static void Main()
        {
            Launch();
            Console.ReadLine();
        }
        private static void Launch()
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "C:\\Windows\\Galkiosk.exe";

            Process p = new Process();
            p.StartInfo = psi;
            p.EnableRaisingEvents = true;
            p.Exited += LaunchAgain;

            p.Start();
        }

        private static void LaunchAgain(object o, EventArgs e)
        {
            Console.WriteLine("Process was killed; launching again");
            Launch();
        }

    }
}
