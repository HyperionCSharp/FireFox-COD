using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace FireFoxAPITwo
{
    // Token: 0x02000007 RID: 7
    public class FireFoxAPI2
    {
        //Used To Be Mem.
        // Token: 0x0600003F RID: 63 RVA: 0x00005798 File Offset: 0x00003998
        public static bool IsProcessRunning(string processName)
        {
            try
            {
                Process process = Process.GetProcessesByName(processName)[0];
                if (process.Handle.ToInt64() != 0L)
                {
                    BaseAddress = process.MainModule.BaseAddress.ToInt64();
                    ProcessID = process.Id;
                    ProcessHandle = process.Handle;
                    return true;
                }
            }
            catch (Exception)
            {
                BaseAddress = 0L;
                ProcessID = 0;
                ProcessHandle = IntPtr.Zero;
                return false;
            }
            return false;
        }

        // Token: 0x06000040 RID: 64
        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(IntPtr hProcess, long lpBaseAddress, [Out] byte[] lpBuffer, uint nSize, out uint lpNumberOfBytesRead);

        // Token: 0x06000041 RID: 65
        [DllImport("kernel32.dll")]
        public static extern bool WriteProcessMemory(IntPtr hProcess, long lpBaseAddress, byte[] lpBuffer, uint nSize, out uint lpNumberOfBytesRead);



        // Token: 0x06000042 RID: 66 RVA: 0x0000582C File Offset: 0x00003A2C
        public static void WriteInt(long pAddress, int value)
        {
            try
            {
                uint num = 0U;
                FireFoxAPI2.WriteProcessMemory(ProcessHandle, pAddress, BitConverter.GetBytes(value), 4U, out num);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Token: 0x06000043 RID: 67 RVA: 0x00005870 File Offset: 0x00003A70
        public static void WriteUInt(long pAddress, uint value)
        {
            try
            {
                uint num = 0U;
                FireFoxAPI2.WriteProcessMemory(ProcessHandle, pAddress, BitConverter.GetBytes(value), 4U, out num);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Token: 0x06000044 RID: 68 RVA: 0x000058B4 File Offset: 0x00003AB4
        public static void WriteFloat(long pAddress, float value)
        {
            try
            {
                uint num = 0U;
                FireFoxAPI2.WriteProcessMemory(ProcessHandle, pAddress, BitConverter.GetBytes(value), 4U, out num);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Token: 0x06000045 RID: 69 RVA: 0x000058F8 File Offset: 0x00003AF8
        public static string ReadString(long pAddress)
        {
            try
            {
                byte[] array = new byte[1280];
                uint num = 0U;
                if (FireFoxAPI2.ReadProcessMemory(ProcessHandle, pAddress, array, 1280U, out num))
                {
                    string text = "";
                    int num2 = 0;
                    while (array[num2] > 0)
                    {
                        string str = text;
                        char c = (char)array[num2];
                        text = str + c.ToString();
                        num2++;
                    }
                    return text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return "";
        }

        // Token: 0x06000046 RID: 70 RVA: 0x0000597C File Offset: 0x00003B7C
        public static long ReadInt64(long pAddress)
        {
            try
            {
                uint num = 0U;
                byte[] array = new byte[8];
                if (FireFoxAPI2.ReadProcessMemory(ProcessHandle, pAddress, array, 8U, out num))
                {
                    return BitConverter.ToInt64(array, 0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return 0L;
        }

        // Token: 0x06000047 RID: 71 RVA: 0x000059D4 File Offset: 0x00003BD4
        public static int ReadInt(long pAddress)
        {
            try
            {
                uint num = 0U;
                byte[] array = new byte[4];
                if (FireFoxAPI2.ReadProcessMemory(ProcessHandle, pAddress, array, 4U, out num))
                {
                    return BitConverter.ToInt32(array, 0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return 0;
        }

        // Token: 0x06000048 RID: 72 RVA: 0x00005A28 File Offset: 0x00003C28
        public static float ReadFloat(long pAddress)
        {
            try
            {
                uint num = 0U;
                byte[] array = new byte[4];
                if (FireFoxAPI2.ReadProcessMemory(ProcessHandle, pAddress, array, 4U, out num))
                {
                    return BitConverter.ToSingle(array, 0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return 0f;
        }

        // Token: 0x06000049 RID: 73 RVA: 0x00005A80 File Offset: 0x00003C80
        public static byte[] ReadBytes(long pAddress, int length)
        {
            byte[] array = new byte[length];
            uint num = 0U;
            byte[] result;
            if (FireFoxAPI2.ReadProcessMemory(ProcessHandle, pAddress, array, (uint)length, out num))
            {
                result = array;
            }
            else
            {
                result = array;
            }
            return result;
        }

        // Token: 0x0600004A RID: 74 RVA: 0x00005AB0 File Offset: 0x00003CB0
        public static void WriteString(long pAddress, string pString)
        {
            try
            {
                uint num = 0U;
                if (FireFoxAPI2.WriteProcessMemory(ProcessHandle, pAddress, Encoding.UTF8.GetBytes(pString), (uint)pString.Length, out num))
                {
                    byte[] lpBuffer = new byte[1];
                    FireFoxAPI2.WriteProcessMemory(ProcessHandle, pAddress + (long)pString.Length, lpBuffer, 1U, out num);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Token: 0x04000045 RID: 69
        public static long BaseAddress;

        // Token: 0x04000046 RID: 70
        public static int ProcessID;

        // Token: 0x04000047 RID: 71
        public static IntPtr ProcessHandle;
    }
}
