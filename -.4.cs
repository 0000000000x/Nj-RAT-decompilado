using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

// Token: 0x02000005 RID: 5
public sealed class \u0006
{
	// Token: 0x0600000C RID: 12 RVA: 0x00002180 File Offset: 0x00000380
	public static void \u0002(string \u0002, string \u0003)
	{
		global::\u0006.\u0002(\u0002, \u0003, 50U, 50U);
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002190 File Offset: 0x00000390
	public static void \u0002(string \u0002, string \u0003, uint \u0005, uint \u0008)
	{
		global::\u0006.\u000E u000E = global::\u0006.\u000E.\u0002(\u0003);
		IntPtr intPtr = global::\u0006.\u0002.\u0002(\u0002, false);
		byte[] array = u000E.\u0002(\u0008);
		IntPtr u = intPtr;
		IntPtr intPtr2 = new IntPtr(14L);
		IntPtr u2 = intPtr2;
		IntPtr intPtr3 = new IntPtr((long)((ulong)\u0005));
		global::\u0006.\u0002.\u0002(u, u2, intPtr3, 0, array, array.Length);
		int num = 0;
		checked
		{
			int num2 = u000E.\u0002() - 1;
			for (int i = num; i <= num2; i++)
			{
				byte[] array2 = u000E.\u0002(i);
				IntPtr u3 = intPtr;
				intPtr3 = new IntPtr(3L);
				IntPtr u4 = intPtr3;
				intPtr2 = new IntPtr((long)(unchecked((ulong)\u0008) + (ulong)(unchecked((long)i))));
				global::\u0006.\u0002.\u0002(u3, u4, intPtr2, 0, array2, array2.Length);
			}
			global::\u0006.\u0002.\u0002(intPtr, false);
		}
	}

	// Token: 0x0200002C RID: 44
	[SuppressUnmanagedCodeSecurity]
	public sealed class \u0002
	{
		// Token: 0x060000F8 RID: 248
		[DllImport("kernel32", EntryPoint = "BeginUpdateResource")]
		public static extern IntPtr \u0002(string \u0002, [MarshalAs(UnmanagedType.Bool)] bool \u0003);

		// Token: 0x060000F9 RID: 249
		[DllImport("kernel32", EntryPoint = "UpdateResource")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool \u0002(IntPtr \u0002, IntPtr \u0003, IntPtr \u0005, short \u0008, [MarshalAs(UnmanagedType.LPArray, SizeConst = 0)] byte[] \u0006, int \u000E);

		// Token: 0x060000FA RID: 250
		[DllImport("kernel32", EntryPoint = "EndUpdateResource")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool \u0002(IntPtr \u0002, [MarshalAs(UnmanagedType.Bool)] bool \u0003);
	}

	// Token: 0x0200002D RID: 45
	private struct \u0003
	{
		// Token: 0x040000B2 RID: 178
		public ushort \u0002;

		// Token: 0x040000B3 RID: 179
		public ushort \u0003;

		// Token: 0x040000B4 RID: 180
		public ushort \u0005;
	}

	// Token: 0x0200002E RID: 46
	private struct \u0005
	{
		// Token: 0x040000B5 RID: 181
		public byte \u0002;

		// Token: 0x040000B6 RID: 182
		public byte \u0003;

		// Token: 0x040000B7 RID: 183
		public byte \u0005;

		// Token: 0x040000B8 RID: 184
		public byte \u0008;

		// Token: 0x040000B9 RID: 185
		public ushort \u0006;

		// Token: 0x040000BA RID: 186
		public ushort \u000E;

		// Token: 0x040000BB RID: 187
		public int \u000F;

		// Token: 0x040000BC RID: 188
		public int \u0002\u2000;
	}

	// Token: 0x0200002F RID: 47
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	private struct \u0006
	{
		// Token: 0x040000BD RID: 189
		public byte \u0002;

		// Token: 0x040000BE RID: 190
		public byte \u0003;

		// Token: 0x040000BF RID: 191
		public byte \u0005;

		// Token: 0x040000C0 RID: 192
		public byte \u0008;

		// Token: 0x040000C1 RID: 193
		public ushort \u0006;

		// Token: 0x040000C2 RID: 194
		public ushort \u000E;

		// Token: 0x040000C3 RID: 195
		public int \u000F;

		// Token: 0x040000C4 RID: 196
		public ushort \u0002\u2000;
	}

	// Token: 0x02000030 RID: 48
	private struct \u0008
	{
		// Token: 0x040000C5 RID: 197
		public uint \u0002;

		// Token: 0x040000C6 RID: 198
		public int \u0003;

		// Token: 0x040000C7 RID: 199
		public int \u0005;

		// Token: 0x040000C8 RID: 200
		public ushort \u0008;

		// Token: 0x040000C9 RID: 201
		public ushort \u0006;

		// Token: 0x040000CA RID: 202
		public uint \u000E;

		// Token: 0x040000CB RID: 203
		public uint \u000F;

		// Token: 0x040000CC RID: 204
		public int \u0002\u2000;

		// Token: 0x040000CD RID: 205
		public int \u0003\u2000;

		// Token: 0x040000CE RID: 206
		public uint \u0005\u2000;

		// Token: 0x040000CF RID: 207
		public uint \u0008\u2000;
	}

	// Token: 0x02000031 RID: 49
	private sealed class \u000E
	{
		// Token: 0x060000FB RID: 251 RVA: 0x0000E844 File Offset: 0x0000CA44
		private \u000E()
		{
			this.\u0002 = default(global::\u0006.\u0003);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000E858 File Offset: 0x0000CA58
		public int \u0002()
		{
			return (int)this.\u0002.\u0005;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000E870 File Offset: 0x0000CA70
		public byte[] \u0002(int \u0002)
		{
			return this.\u0005[\u0002];
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000E888 File Offset: 0x0000CA88
		public static global::\u0006.\u000E \u0002(string \u0002)
		{
			global::\u0006.\u000E u000E = new global::\u0006.\u000E();
			byte[] array = File.ReadAllBytes(\u0002);
			GCHandle gchandle = GCHandle.Alloc(array, GCHandleType.Pinned);
			u000E.\u0002 = (global::\u0006.\u0003)Marshal.PtrToStructure(gchandle.AddrOfPinnedObject(), typeof(global::\u0006.\u0003));
			checked
			{
				u000E.\u0003 = new global::\u0006.\u0005[(int)(u000E.\u0002.\u0005 - 1 + 1)];
				u000E.\u0005 = new byte[(int)(u000E.\u0002.\u0005 - 1 + 1)][];
				int num = Marshal.SizeOf(u000E.\u0002);
				Type typeFromHandle = typeof(global::\u0006.\u0005);
				int num2 = Marshal.SizeOf(typeFromHandle);
				int num3 = 0;
				int num4 = (int)(u000E.\u0002.\u0005 - 1);
				for (int i = num3; i <= num4; i++)
				{
					IntPtr ptr = new IntPtr(gchandle.AddrOfPinnedObject().ToInt64() + unchecked((long)num));
					global::\u0006.\u0005 u = (global::\u0006.\u0005)Marshal.PtrToStructure(ptr, typeFromHandle);
					u000E.\u0003[i] = u;
					u000E.\u0005[i] = new byte[u.\u000F - 1 + 1];
					Buffer.BlockCopy(array, u.\u0002\u2000, u000E.\u0005[i], 0, u.\u000F);
					num += num2;
				}
				gchandle.Free();
				return u000E;
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000E9DC File Offset: 0x0000CBDC
		public byte[] \u0002(uint \u0002)
		{
			checked
			{
				int num = Marshal.SizeOf(typeof(global::\u0006.\u0003)) + Marshal.SizeOf(typeof(global::\u0006.\u0006)) * this.\u0002();
				byte[] array = new byte[num - 1 + 1];
				GCHandle gchandle = GCHandle.Alloc(array, GCHandleType.Pinned);
				Marshal.StructureToPtr(this.\u0002, gchandle.AddrOfPinnedObject(), false);
				int num2 = Marshal.SizeOf(this.\u0002);
				int num3 = 0;
				int num4 = this.\u0002() - 1;
				for (int i = num3; i <= num4; i++)
				{
					global::\u0006.\u0006 u = default(global::\u0006.\u0006);
					global::\u0006.\u0008 u2 = default(global::\u0006.\u0008);
					GCHandle gchandle2 = GCHandle.Alloc(u2, GCHandleType.Pinned);
					Marshal.Copy(this.\u0002(i), 0, gchandle2.AddrOfPinnedObject(), Marshal.SizeOf(typeof(global::\u0006.\u0008)));
					gchandle2.Free();
					u.\u0002 = this.\u0003[i].\u0002;
					u.\u0003 = this.\u0003[i].\u0003;
					u.\u0005 = this.\u0003[i].\u0005;
					u.\u0008 = this.\u0003[i].\u0008;
					u.\u0006 = u2.\u0008;
					u.\u000E = u2.\u0006;
					u.\u000F = this.\u0003[i].\u000F;
					u.\u0002\u2000 = (ushort)(unchecked((ulong)\u0002) + (ulong)(unchecked((long)i)));
					object structure = u;
					IntPtr ptr = new IntPtr(gchandle.AddrOfPinnedObject().ToInt64() + unchecked((long)num2));
					Marshal.StructureToPtr(structure, ptr, false);
					num2 += Marshal.SizeOf(typeof(global::\u0006.\u0006));
				}
				gchandle.Free();
				return array;
			}
		}

		// Token: 0x040000D0 RID: 208
		private global::\u0006.\u0003 \u0002;

		// Token: 0x040000D1 RID: 209
		private global::\u0006.\u0005[] \u0003;

		// Token: 0x040000D2 RID: 210
		private byte[][] \u0005;
	}
}
