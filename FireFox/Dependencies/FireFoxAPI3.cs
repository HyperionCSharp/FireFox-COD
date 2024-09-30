using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace FireFoxAPIThree
{
    public class FireFoxAPI3
    {
        // Token: 0x06000023 RID: 35 RVA: 0x00003CA8 File Offset: 0x00001EA8
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

        // Token: 0x06000024 RID: 36
        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(IntPtr hProcess, long lpBaseAddress, [Out] byte[] lpBuffer, uint nSize, out uint lpNumberOfBytesRead);

        // Token: 0x06000025 RID: 37
        [DllImport("kernel32.dll")]
        public static extern bool WriteProcessMemory(IntPtr hProcess, long lpBaseAddress, byte[] lpBuffer, uint nSize, out uint lpNumberOfBytesRead);

        // Token: 0x06000026 RID: 38 RVA: 0x00003D38 File Offset: 0x00001F38
        public static void WriteInt(long pAddress, int value)
        {
            try
            {
                uint num = 0U;
                FireFoxAPI3.WriteProcessMemory(ProcessHandle, pAddress, BitConverter.GetBytes(value), 4U, out num);
            }
            catch (Exception)
            {
            }
        }

        public static void WriteByte(long _lpBaseAddress, byte _Value)
        {
            byte[] bytes = BitConverter.GetBytes((short)_Value);
            uint num = 0u;
            FireFoxAPI3.WriteProcessMemory(ProcessHandle, _lpBaseAddress, bytes, (uint)(bytes.Length - 1), out num);
        }

        // Token: 0x06000027 RID: 39 RVA: 0x00003D74 File Offset: 0x00001F74
        public static void WriteUInt(long pAddress, uint value)
        {
            try
            {
                uint num = 0U;
                FireFoxAPI3.WriteProcessMemory(ProcessHandle, pAddress, BitConverter.GetBytes(value), 4U, out num);
            }
            catch (Exception)
            {
            }
        }

        // Token: 0x06000028 RID: 40 RVA: 0x00003DB0 File Offset: 0x00001FB0

        // Token: 0x06000029 RID: 41 RVA: 0x00003DEC File Offset: 0x00001FEC
        public static long GetPointerInt(long add, long[] offsets, int level)
        {
            long num = add;
            for (int i = 0; i < level; i++)
            {
                num = ReadInt64(num) + offsets[i];
            }
            return num;
        }

        public static void WriteXBytes(long _lpBaseAddress, byte[] _Value)
        {
            uint zero = 0u;
            FireFoxAPI3.WriteProcessMemory(ProcessHandle, _lpBaseAddress, _Value, (uint)_Value.Length, out zero);
        }

        // Token: 0x0600002A RID: 42 RVA: 0x00003E64 File Offset: 0x00002064
        public static long ReadInt64(long pAddress)
        {
            try
            {
                uint num = 0U;
                byte[] array = new byte[8];
                if (FireFoxAPI3.ReadProcessMemory(ProcessHandle, pAddress, array, 8U, out num))
                {
                    return BitConverter.ToInt64(array, 0);
                }
            }
            catch (Exception)
            {
            }
            return 0L;
        }

        public static string ReadString(long pAddress)
        {
            try
            {
                byte[] array = new byte[1280];
                uint num = 0U;
                if (FireFoxAPI3.ReadProcessMemory(ProcessHandle, pAddress, array, 1280U, out num))
                {
                    string text = "";
                    int num2 = 0;
                    while (array[num2] != 0)
                    {
                        string str = text;
                        char c = (char)array[num2];
                        text = str + c.ToString();
                        num2++;
                    }
                    return text;
                }
            }
            catch (Exception)
            {
            }
            return "";
        }

        public static int ReadInt(long pAddress)
        {
            try
            {
                uint num = 0U;
                byte[] array = new byte[4];
                if (FireFoxAPI3.ReadProcessMemory(ProcessHandle, pAddress, array, 4U, out num))
                {
                    return BitConverter.ToInt32(array, 0);
                }
            }
            catch (Exception)
            {
            }
            return 0;
        }

        public static void WriteFloat(long pAddress, float value)
        {
            try
            {
                uint num = 0U;
                FireFoxAPI3.WriteProcessMemory(ProcessHandle, pAddress, BitConverter.GetBytes(value), 4U, out num);
            }
            catch (Exception)
            {
            }
        }

        // Token: 0x0600002C RID: 44 RVA: 0x00003EFC File Offset: 0x000020FC
        public static float ReadFloat(long pAddress)
        {
            try
            {
                uint num = 0U;
                byte[] array = new byte[4];
                if (FireFoxAPI3.ReadProcessMemory(ProcessHandle, pAddress, array, 4U, out num))
                {
                    return BitConverter.ToSingle(array, 0);
                }
            }
            catch (Exception)
            {
            }
            return 0f;
        }

        public static byte[] ReadBytes(long pAddress, int length)
        {
            byte[] array = new byte[length];
            uint num = 0U;
            FireFoxAPI3.ReadProcessMemory(ProcessHandle, pAddress, array, (uint)length, out num);
            return array;
        }

        public static void WriteBool(long pAddress, bool value)
        {
            try
            {
                byte[] buff = new byte[] { value ? ((byte)1) : ((byte)0) };
                uint num = 0U;
                FireFoxAPI3.WriteProcessMemory(ProcessHandle, pAddress, buff, (uint)buff.Length, out num);
            }
            catch (Exception)
            {
            }
        }

        public static void WriteString(long pAddress, string pString)
        {
            try
            {
                uint num = 0U;

                if (FireFoxAPI3.WriteProcessMemory(ProcessHandle, pAddress, Encoding.UTF8.GetBytes(pString), (uint)pString.Length, out num))
                {
                    byte[] lpBuffer = new byte[1];
                    FireFoxAPI3.WriteProcessMemory(ProcessHandle, pAddress + (long)pString.Length, lpBuffer, 1U, out num);
                }
            }
            catch (Exception)
            {
            }
        }

        // Token: 0x04000023 RID: 35
        public static long BaseAddress;

        // Token: 0x04000024 RID: 36
        public static int ProcessID;

        // Token: 0x04000025 RID: 37
        public static IntPtr ProcessHandle;
    }
}