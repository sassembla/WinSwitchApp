using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var from = "";
            var to = "";

            for (var i = 0; i < args.Length; i++)
            {
                if (args[i] == "-f")
                {
                    from = args[i + 1];
                }

                if (args[i] == "-t") {
                    to = args[i + 1];
                }
            }

            string fromProcessTitle = "", toProcessTitle = "";

            Process[] processlist = Process.GetProcesses();
            foreach(Process theprocess in processlist){
                
                if (from == theprocess.ProcessName)
                {
                    fromProcessTitle = Process.GetProcessById(theprocess.Id).MainWindowTitle;
                }

                if (to == theprocess.ProcessName)
                {
                    toProcessTitle = Process.GetProcessById(theprocess.Id).MainWindowTitle;
                }
            }

            if (fromProcessTitle == "") return;
 
            ActivateWindow(fromProcessTitle);

            if (toProcessTitle != "")
            {
                System.Threading.Thread.Sleep(100);
                ActivateWindow(toProcessTitle);
            }
        }



        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern IntPtr FindWindow(
            string lpClassName,
            string lpWindowName);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        /**
         * Activate
         */
        public static void ActivateWindow(string windowTitle)
        {
            IntPtr hWnd = FindWindow(null, windowTitle);
            if (hWnd != IntPtr.Zero)
            {
                SetForegroundWindow(hWnd);
            }

        }
    }
}
