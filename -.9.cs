using System;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x0200000A RID: 10
public sealed class \u0003\u2000
{
	// Token: 0x06000045 RID: 69 RVA: 0x00005CE0 File Offset: 0x00003EE0
	public \u0003\u2000(string \u0002)
	{
		this.\u000F\u2001 = \u0002;
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00005CF0 File Offset: 0x00003EF0
	public int \u0002()
	{
		if (this.\u000F\u2001 == null | Operators.CompareString(this.\u000F\u2001, string.Empty, false) == 0)
		{
			return global::\u0003\u2000.\u0002;
		}
		return checked(Convert.ToInt32(this.\u000F\u2001.Substring(4, 3)) - 105);
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00005D3C File Offset: 0x00003F3C
	public bool \u0002()
	{
		return this.\u000F\u2001.IndexOf(global::\u0006\u2001.\u0002(-1829129748)) < 0;
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00005D64 File Offset: 0x00003F64
	public DateTime \u0002()
	{
		int num = 0;
		checked
		{
			int num2 = this.\u000F\u2001.Length - 10;
			for (int i = num; i <= num2; i++)
			{
				if (char.IsWhiteSpace(this.\u000F\u2001[i]))
				{
					string s = this.\u000F\u2001.Substring(i + 1, 8);
					try
					{
						return DateTime.ParseExact(s, global::\u0006\u2001.\u0002(-1829129759), null);
					}
					catch (Exception ex)
					{
						Console.Write(ex.Message);
						break;
					}
				}
			}
			return DateTime.Now;
		}
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00005E04 File Offset: 0x00004004
	public string \u0002()
	{
		return this.\u000F\u2001;
	}

	// Token: 0x0400002C RID: 44
	public static int \u0002 = 1;

	// Token: 0x0400002D RID: 45
	public static int \u0003 = 7;

	// Token: 0x0400002E RID: 46
	public static int \u0005 = 3;

	// Token: 0x0400002F RID: 47
	public static int \u0008 = 6;

	// Token: 0x04000030 RID: 48
	public static int \u0006 = 2;

	// Token: 0x04000031 RID: 49
	public static int \u000E = 5;

	// Token: 0x04000032 RID: 50
	public static int \u000F = 4;

	// Token: 0x04000033 RID: 51
	public static int \u0002\u2000 = 8;

	// Token: 0x04000034 RID: 52
	public static int \u0003\u2000 = 9;

	// Token: 0x04000035 RID: 53
	public static int \u0005\u2000 = 10;

	// Token: 0x04000036 RID: 54
	public static int \u0008\u2000 = 11;

	// Token: 0x04000037 RID: 55
	public static int \u0006\u2000 = 12;

	// Token: 0x04000038 RID: 56
	public static int \u000E\u2000 = 21;

	// Token: 0x04000039 RID: 57
	public static int \u000F\u2000 = 22;

	// Token: 0x0400003A RID: 58
	public static int \u0002\u2001 = 23;

	// Token: 0x0400003B RID: 59
	public static int \u0003\u2001 = 24;

	// Token: 0x0400003C RID: 60
	public static int \u0005\u2001 = 30;

	// Token: 0x0400003D RID: 61
	public static int \u0008\u2001 = 31;

	// Token: 0x0400003E RID: 62
	public static int \u0006\u2001 = 32;

	// Token: 0x0400003F RID: 63
	public static int \u000E\u2001 = 33;

	// Token: 0x04000040 RID: 64
	private string \u000F\u2001;
}
