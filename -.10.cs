using System;

// Token: 0x0200000B RID: 11
public sealed class \u0005\u2000
{
	// Token: 0x0600004C RID: 76 RVA: 0x00005E54 File Offset: 0x00004054
	public double \u0002(\u0005\u2000 \u0002)
	{
		double num = this.\u000E;
		double u000F = this.\u000F;
		double num2 = \u0002.\u000E;
		double u000F2 = \u0002.\u000F;
		num *= global::\u0005\u2000.\u000F\u2000;
		num2 *= global::\u0005\u2000.\u000F\u2000;
		double num3 = num2 - num;
		double num4 = (u000F2 - u000F) * global::\u0005\u2000.\u000F\u2000;
		double num5 = Math.Pow(Math.Sin(num3 / 2.0), 2.0) + Math.Cos(num) * Math.Cos(num2) * Math.Pow(Math.Sin(num4 / 2.0), 2.0);
		return global::\u0005\u2000.\u0006\u2000 * Math.Atan2(Math.Sqrt(num5), Math.Sqrt(1.0 - num5));
	}

	// Token: 0x04000041 RID: 65
	public string \u0002;

	// Token: 0x04000042 RID: 66
	public string \u0003;

	// Token: 0x04000043 RID: 67
	public string \u0005;

	// Token: 0x04000044 RID: 68
	public string \u0008;

	// Token: 0x04000045 RID: 69
	public string \u0006;

	// Token: 0x04000046 RID: 70
	public double \u000E;

	// Token: 0x04000047 RID: 71
	public double \u000F;

	// Token: 0x04000048 RID: 72
	public int \u0002\u2000;

	// Token: 0x04000049 RID: 73
	public int \u0003\u2000;

	// Token: 0x0400004A RID: 74
	public string \u0005\u2000;

	// Token: 0x0400004B RID: 75
	public int \u0008\u2000;

	// Token: 0x0400004C RID: 76
	private static double \u0006\u2000 = 12756.4;

	// Token: 0x0400004D RID: 77
	private static double \u000E\u2000 = 3.14159265;

	// Token: 0x0400004E RID: 78
	private static double \u000F\u2000 = global::\u0005\u2000.\u000E\u2000 / 180.0;
}
