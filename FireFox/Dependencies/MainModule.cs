using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace FirFox.Kill.Your.Shit
{
    internal static class MainModule
    {
        internal static void SelfDelete()
        {
            KillProgram1();
            KillProgram2();
            KillProgram3();
            Crash1();
            Crash2();
            Crash3();
            Crash4();
            Crash5();
        }
        public static void KillProgram1()
        {
            Process.GetCurrentProcess().Kill();
        }
        public static void KillProgram2()
        {
            Environment.Exit(0);
        }
        public static void KillProgram3()
        {
            Application.Exit();
        }

        public static void Crash1()
        {
            int[] x = { 0 };
            int blah = x[2];
        }

        public static void Crash2()
        {
            System.Diagnostics.Debugger.Launch();
        }

        public static void Crash3()
        {
            throw new Exception();
        }

        public static void Crash4()
        {
            void MyMethod()
            {
                MyMethod();
            }
        }

        public static void Crash5()
        {
            throw new Exception("Get Fucked");
        }
    }
}