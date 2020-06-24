using System;
using System.Runtime.InteropServices;
using System.Security;

// Token: 0x02000006 RID: 6
[SuppressUnmanagedCodeSecurity]
public sealed class \u0008
{
	// Token: 0x0600000F RID: 15
	[DllImport("kernel32", EntryPoint = "BeginUpdateResource")]
	public static extern IntPtr \u0002(string \u0002, [MarshalAs(UnmanagedType.Bool)] bool \u0003);

	// Token: 0x06000010 RID: 16
	[DllImport("kernel32", EntryPoint = "UpdateResource")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool \u0002(IntPtr \u0002, IntPtr \u0003, IntPtr \u0005, short \u0008, [MarshalAs(UnmanagedType.LPArray, SizeConst = 0)] byte[] \u0006, int \u000E);

	// Token: 0x06000011 RID: 17
	[DllImport("kernel32", EntryPoint = "EndUpdateResource")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool \u0002(IntPtr \u0002, [MarshalAs(UnmanagedType.Bool)] bool \u0003);
}
