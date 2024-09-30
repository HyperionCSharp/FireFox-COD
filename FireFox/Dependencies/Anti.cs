using FirFox.Kill.Your.Shit;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FireFox
{
    class Anti
    {
        [DllImport("user32.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        public static bool settingsReturn, refreshReturn;
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_REFRESH = 37;
        public static string[] _snoopers;
        public static BackgroundWorker AntisStartBGWorker = new BackgroundWorker();

        public static void IntAntisStart()
        {
            AntisStartBGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(StartAntis_DoWork);
            AntisStartBGWorker.RunWorkerAsync();
        }

        public static void StartAntis_DoWork(object sender, DoWorkEventArgs e)
        {
            while(true)
            {
                _snoopers = new string[41]{"codecracker","x32dbg","x64dbg","ollydbg","ida","charles","dnspy","simpleassembly","peek","httpanalyzer","httpdebug","fiddler","wireshark","dbx","mdbg","gdb","windbg","dbgclr","kdb","kgdb","mdb","processhacker","scylla_x86","scylla_x64","scylla","idau64","idau","idaq","idaq64","idaw","idaw64","idag","idag64","ida64","ida","ImportREC","IMMUNITYDEBUGGER","MegaDumper","CodeBrowser","reshacker","cheat engine"};
                CheckForForeignPrograms();
                DisableProxySettings();
                CheckForAnyProxyConnections();
                DumpProtectionAndMore();
                Thread.Sleep(30000);
            }
        }
        public static string[] Snoopers
        {
            get { return _snoopers; }
            set { _snoopers = value; }
        }
        public static void CheckForForeignPrograms()
        {
            for (int i = 0; i < Snoopers.Length; i++)
            {
                KillProcessByWindowTitle(Snoopers[i], false);
            }
        }

        public static void DumpProtectionAndMore()
        {
            Anti_DebugNET.AntiDebugTools.Scanner.ScanAndKill();
            if (Anti_DebugNET.AntiDebug.DebugProtect1.PerformChecks() == 1)
            {
                MainModule.SelfDelete();
            }
            if (Anti_DebugNET.AntiDebug.DebugProtect2.PerformChecks() == 1)
            {
                MainModule.SelfDelete();
            }
            Anti_DebugNET.AntiDebug.DebugProtect3.HideOSThreads();
        }

        public static void DisableProxySettings()
        {
            try
            {
                RegistryKey RegKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                RegKey.SetValue("ProxyServer", 0);
                RegKey.SetValue("ProxyEnable", 0);

                // These lines implement the Interface in the beginning of program 
                // They cause the OS to refresh the settings, causing IP to realy update
                settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
            }
            catch
            {

            }
        }
        public static void CheckForAnyProxyConnections()
        {
            try
            {
                RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                string ProxyEnabledOrNuh = registry.GetValue("ProxyEnable").ToString();
                object ProxyServerValue = registry.GetValue("ProxyServer");
                if (ProxyEnabledOrNuh == "1")
                {
                    Process.GetCurrentProcess().Kill();
                }
            }
            catch
            {

            }
            try
            {
                string FileContent = File.ReadAllText(@"C:\WINDOWS\System32\Drivers\Etc\hosts");

                if (FileContent.Contains("epictools.org"))
                {
                    Process.GetCurrentProcess().Kill();
                }
            }
            catch
            {

            }
        }
        public static void KillProcessByWindowTitle(string title, bool caseSensitive)
        {
            Process[] myPSList = Process.GetProcesses();

            foreach (Process p in myPSList)
            {

                if (caseSensitive)
                {
                    if (p.MainWindowTitle.Contains(title))
                    {
                        p.Kill();
                    }
                }
                else
                {
                    string mainWindowTitle = p.MainWindowTitle;
                    mainWindowTitle = mainWindowTitle.ToLower();
                    title = title.ToLower();

                    if (mainWindowTitle.Contains(title))
                    {
                        p.Kill();
                    }
                }
            }
        }

    }
}
