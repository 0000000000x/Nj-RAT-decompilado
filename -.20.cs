using System;

// Token: 0x0200001A RID: 26
internal static class \u000E\u2001
{
	// Token: 0x06000097 RID: 151 RVA: 0x0000D590 File Offset: 0x0000B790
	public static byte[] \u0002(byte[] \u0002, byte[] \u0003)
	{
		byte b = \u0002[1];
		int num = \u0003.Length;
		byte b2 = (byte)(num + 11 ^ (int)(b + 7));
		uint num2 = (uint)(((int)\u0002[0] | (int)\u0002[2] << 8) + ((int)b2 << 3));
		ushort num3 = 0;
		for (int i = 0; i < num; i++)
		{
			if ((i & 1) == 0)
			{
				num2 = num2 * 214013U + 2531011U;
				num3 = (ushort)(num2 >> 16);
			}
			byte b3 = (byte)num3;
			num3 = (ushort)(num3 >> 8);
			byte b4 = \u0003[i];
			\u0003[i] = (b4 ^ b ^ b2 + 3 ^ b3);
			b2 = b4;
		}
		return \u0003;
	}
}
