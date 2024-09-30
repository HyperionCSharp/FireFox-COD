using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Windows.Forms;

namespace FireFox
{
    static class IntFireFox
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Misc.FireFoxCheckForUpdate();
            string HomeDirectory = Directory.GetCurrentDirectory();
            if(HomeDirectory.Contains("AppData"))
            {
                XtraMessageBox.Show("Tool Must Be Extracted Into A Folder Before Usage...");
                Application.Exit();
                Process.GetCurrentProcess().Kill();
            }
            if (IsUserAdministrator() == false)
            {
                //MessageBox.Show("Program Must Be Ran As Admin To Work, Press Okay To Reopen As Admin!");
                ExecuteAsAdmin(System.AppDomain.CurrentDomain.FriendlyName);
                Process.GetCurrentProcess().Kill();
            }
            foreach (var process in Process.GetProcessesByName("Assets2"))
            {
                process.Kill();
            }
            string Assets1 = Path.Combine(Path.GetTempPath(), "Assets1.exe");
            File.WriteAllBytes(Assets1, FireFox.Properties.Resources.Assets1);
            string Assets2 = Path.Combine(Path.GetTempPath(), "Assets2.exe");
            File.WriteAllBytes(Assets2, FireFox.Properties.Resources.Assets2);
            if (!File.Exists(Assets1))
            {
                MessageBox.Show("Missing Assets1.exe File, The Tool Requires This To Run!");
                Process.GetCurrentProcess().Kill();
            }
            if (!File.Exists(Assets2))
            {
                MessageBox.Show("Missing Assets2.exe File, The Tool Requires This To Run!");
                Process.GetCurrentProcess().Kill();
            }
            int nProcessID = Process.GetCurrentProcess().Id;
            string CD = Directory.GetCurrentDirectory();
            string Advancedrun = Assets1;
            string ProtectFile = Assets2;
            ExecuteCommand(Advancedrun + " " + ProtectFile + " " + nProcessID);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new Firefox().Show();
            Application.Run();
        }
        public static void ExecuteAsAdmin(string fileName)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = fileName;
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Verb = "runas";
            proc.Start();
        }
        public static bool IsUserAdministrator()
        {
            bool isAdmin;
            try
            {
                WindowsIdentity user = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(user);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (UnauthorizedAccessException ex)
            {
                isAdmin = false;
            }
            catch (Exception ex)
            {
                isAdmin = false;
            }
            return isAdmin;
        }
        public static void ExecuteCommand(String command)
        {
            Process p = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/c " + command; // cmd.exe spesific implementation
            p.StartInfo.RedirectStandardOutput = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            p.StartInfo.Verb = "runas";
            p.StartInfo = startInfo;
            p.Start();
        }
    }
}
