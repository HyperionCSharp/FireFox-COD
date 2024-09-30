using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace FireFoxAPI1One
{
	// Token: 0x02000003 RID: 3
	internal class FireFoxAPI1
	{
		// Token: 0x06000034 RID: 52
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern IntPtr OpenProcess(FireFoxAPI1.ProcessAccessFlags processAccess, bool bInheritHandle, int processId);

		// Token: 0x06000035 RID: 53
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, long nSize, out IntPtr lpNumberOfBytesRead);

		// Token: 0x06000036 RID: 54
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [MarshalAs(UnmanagedType.AsAny)] object lpBuffer, long nSize, out IntPtr lpNumberOfBytesWritten);

		// Token: 0x06000037 RID: 55
		[DllImport("kernel32.dll")]
		private static extern bool Process32First(IntPtr hSnapshot, ref FireFoxAPI1.PROCESSENTRY32 lppe);

		// Token: 0x06000038 RID: 56
		[DllImport("kernel32.dll")]
		private static extern bool Process32Next(IntPtr hSnapshot, ref FireFoxAPI1.PROCESSENTRY32 lppe);

		// Token: 0x06000039 RID: 57
		[DllImport("kernel32.dll")]
		private static extern bool Module32First(IntPtr hSnapshot, ref FireFoxAPI1.MODULEENTRY32 lpme);

		// Token: 0x0600003A RID: 58
		[DllImport("kernel32.dll")]
		private static extern bool Module32Next(IntPtr hSnapshot, ref FireFoxAPI1.MODULEENTRY32 lpme);

		// Token: 0x0600003B RID: 59
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool CloseHandle(IntPtr hHandle);

		// Token: 0x0600003C RID: 60
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr CreateToolhelp32Snapshot(FireFoxAPI1.SnapshotFlags dwFlags, int th32ProcessID);

		// Token: 0x0600003D RID: 61 RVA: 0x00004AE8 File Offset: 0x00002CE8
		public static IntPtr GetModuleBaseAddress(Process proc, string modName)
		{
			IntPtr result = IntPtr.Zero;
			foreach (object obj in proc.Modules)
			{
				ProcessModule processModule = (ProcessModule)obj;
				bool flag = processModule.ModuleName == modName;
				bool flag2 = flag;
				if (flag2)
				{
					result = processModule.BaseAddress;
					break;
				}
			}
			return result;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00004B74 File Offset: 0x00002D74
		public static IntPtr GetModuleBaseAddress(int procId, string modName)
		{
			IntPtr result = IntPtr.Zero;
			IntPtr intPtr = FireFoxAPI1.CreateToolhelp32Snapshot(FireFoxAPI1.SnapshotFlags.Module | FireFoxAPI1.SnapshotFlags.Module32, procId);
			bool flag = intPtr.ToInt64() != -1L;
			bool flag2 = flag;
			if (flag2)
			{
				FireFoxAPI1.MODULEENTRY32 moduleentry = default(FireFoxAPI1.MODULEENTRY32);
				moduleentry.dwSize = (uint)Marshal.SizeOf(typeof(FireFoxAPI1.MODULEENTRY32));
				bool flag3 = FireFoxAPI1.Module32First(intPtr, ref moduleentry);
				bool flag4 = flag3;
				if (flag4)
				{
					for (; ; )
					{
						bool flag5 = moduleentry.szModule.Equals(modName);
						bool flag6 = flag5;
						if (flag6)
						{
							break;
						}
						bool flag7 = !FireFoxAPI1.Module32Next(intPtr, ref moduleentry);
						if (flag7)
						{
							goto Block_4;
						}
					}
					result = moduleentry.modBaseAddr;
				Block_4:;
				}
			}
			FireFoxAPI1.CloseHandle(intPtr);
			return result;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00004C28 File Offset: 0x00002E28
		public static IntPtr FindDMAAddy(IntPtr hProc, IntPtr ptr, int[] offsets)
		{
			byte[] array = new byte[IntPtr.Size];
			foreach (int offset in offsets)
			{
				IntPtr intPtr;
				FireFoxAPI1.ReadProcessMemory(hProc, ptr, array, (long)array.Length, out intPtr);
				ptr = ((IntPtr.Size == 4) ? IntPtr.Add(new IntPtr(BitConverter.ToInt32(array, 0)), offset) : (ptr = IntPtr.Add(new IntPtr(BitConverter.ToInt64(array, 0)), offset)));
			}
			return ptr;
		}

		// Token: 0x04000064 RID: 100
		private const int INVALID_HANDLE_VALUE = -1;

		// Token: 0x02000008 RID: 8
		[Flags]
		public enum ProcessAccessFlags : uint
		{
			// Token: 0x0400006C RID: 108
			All = 2035711U,
			// Token: 0x0400006D RID: 109
			Terminate = 1U,
			// Token: 0x0400006E RID: 110
			CreateThread = 2U,
			// Token: 0x0400006F RID: 111
			VirtualMemoryOperation = 8U,
			// Token: 0x04000070 RID: 112
			VirtualMemoryRead = 16U,
			// Token: 0x04000071 RID: 113
			VirtualMemoryWrite = 32U,
			// Token: 0x04000072 RID: 114
			DuplicateHandle = 64U,
			// Token: 0x04000073 RID: 115
			CreateProcess = 128U,
			// Token: 0x04000074 RID: 116
			SetQuota = 256U,
			// Token: 0x04000075 RID: 117
			SetInformation = 512U,
			// Token: 0x04000076 RID: 118
			QueryInformation = 1024U,
			// Token: 0x04000077 RID: 119
			QueryLimitedInformation = 4096U,
			// Token: 0x04000078 RID: 120
			Synchronize = 1048576U
		}

		// Token: 0x02000009 RID: 9
		public struct PROCESSENTRY32
		{
			// Token: 0x04000079 RID: 121
			public uint dwSize;

			// Token: 0x0400007A RID: 122
			public uint cntUsage;

			// Token: 0x0400007B RID: 123
			public uint th32ProcessID;

			// Token: 0x0400007C RID: 124
			public IntPtr th32DefaultHeapID;

			// Token: 0x0400007D RID: 125
			public uint th32ModuleID;

			// Token: 0x0400007E RID: 126
			public uint cntThreads;

			// Token: 0x0400007F RID: 127
			public uint th32ParentProcessID;

			// Token: 0x04000080 RID: 128
			public int pcPriClassBase;

			// Token: 0x04000081 RID: 129
			public uint dwFlags;

			// Token: 0x04000082 RID: 130
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public string szExeFile;
		}

		// Token: 0x0200000A RID: 10
		public struct MODULEENTRY32
		{
			// Token: 0x04000083 RID: 131
			internal uint dwSize;

			// Token: 0x04000084 RID: 132
			internal uint th32ModuleID;

			// Token: 0x04000085 RID: 133
			internal uint th32ProcessID;

			// Token: 0x04000086 RID: 134
			internal uint GlblcntUsage;

			// Token: 0x04000087 RID: 135
			internal uint ProccntUsage;

			// Token: 0x04000088 RID: 136
			internal IntPtr modBaseAddr;

			// Token: 0x04000089 RID: 137
			internal uint modBaseSize;

			// Token: 0x0400008A RID: 138
			internal IntPtr hModule;

			// Token: 0x0400008B RID: 139
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			internal string szModule;

			// Token: 0x0400008C RID: 140
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			internal string szExePath;
		}

		// Token: 0x0200000B RID: 11
		[Flags]
		private enum SnapshotFlags : uint
		{
			// Token: 0x0400008E RID: 142
			HeapList = 1U,
			// Token: 0x0400008F RID: 143
			Process = 2U,
			// Token: 0x04000090 RID: 144
			Thread = 4U,
			// Token: 0x04000091 RID: 145
			Module = 8U,
			// Token: 0x04000092 RID: 146
			Module32 = 16U,
			// Token: 0x04000093 RID: 147
			Inherit = 2147483648U,
			// Token: 0x04000094 RID: 148
			All = 31U,
			// Token: 0x04000095 RID: 149
			NoHeaps = 1073741824U
		}

		internal static void WriteProcessMemory(IntPtr hProc, IntPtr intPtr, int v, out long _)
		{
			throw new NotImplementedException();
		}
	}
}
