using System;
using System.Runtime.InteropServices;

// Token: 0x0200000C RID: 12
public sealed class \u0006\u2000
{
	// Token: 0x0600004E RID: 78
	[DllImport("User32.dll", EntryPoint = "GetLastInputInfo")]
	private static extern bool \u0002(ref \u0006\u2000.\u0002 \u0002);

	// Token: 0x0600004F RID: 79 RVA: 0x00005F1C File Offset: 0x0000411C
	public static uint \u0002()
	{
		\u0006\u2000.\u0002 u = default(\u0006\u2000.\u0002);
		u.\u0002 = Convert.ToUInt32(Marshal.SizeOf(u));
		\u0006\u2000.\u0002(ref u);
		return checked(Convert.ToUInt32(Environment.TickCount) - u.\u0003);
	}

	// Token: 0x02000010 RID: 16
	public struct \u0002
	{
		// Token: 0x04000073 RID: 115
		public uint \u0002;

		// Token: 0x04000074 RID: 116
		public uint \u0003;
	}
}
