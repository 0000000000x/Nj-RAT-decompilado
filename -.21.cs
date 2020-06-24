using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x0200001B RID: 27
internal static class \u000F\u2001
{
	// Token: 0x06000099 RID: 153 RVA: 0x0000D624 File Offset: 0x0000B824
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long \u0002()
	{
		if (Assembly.GetCallingAssembly() != typeof(\u000F\u2001).Assembly || !\u000F\u2001.\u0002())
		{
			return 5038234971328056794L;
		}
		long result;
		lock (\u000F\u2001.\u0002)
		{
			long num = \u000F\u2001.\u0002.\u0002();
			if (num == 0L)
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				List<byte> list = new List<byte>();
				AssemblyName assemblyName;
				try
				{
					assemblyName = executingAssembly.GetName();
				}
				catch
				{
					assemblyName = new AssemblyName(executingAssembly.FullName);
				}
				byte[] array = assemblyName.GetPublicKeyToken();
				if (array != null && array.Length == 0)
				{
					array = null;
				}
				if (array != null)
				{
					list.AddRange(array);
				}
				list.AddRange(Encoding.Unicode.GetBytes(assemblyName.Name));
				int num2 = \u000F\u2001.\u0002(typeof(\u000F\u2001));
				int num3 = \u000F\u2001.\u0005.\u0002();
				list.Add((byte)(num2 >> 24));
				list.Add((byte)(num3 >> 16));
				list.Add((byte)(num2 >> 8));
				list.Add((byte)num3);
				list.Add((byte)(num2 >> 16));
				list.Add((byte)(num3 >> 8));
				list.Add((byte)num2);
				list.Add((byte)(num3 >> 24));
				int count = list.Count;
				ulong num4 = 0UL;
				for (int num5 = 0; num5 != count; num5++)
				{
					num4 += (ulong)list[num5];
					num4 += num4 << 20;
					num4 ^= num4 >> 12;
					list[num5] = 0;
				}
				num4 += num4 << 6;
				num4 ^= num4 >> 22;
				num4 += num4 << 30;
				num = (long)num4;
				num ^= 5880588886910754974L;
				\u000F\u2001.\u0002.\u0002(num);
			}
			result = num;
		}
		return result;
	}

	// Token: 0x0600009A RID: 154 RVA: 0x0000D820 File Offset: 0x0000BA20
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool \u0002()
	{
		return \u000F\u2001.\u0003();
	}

	// Token: 0x0600009B RID: 155 RVA: 0x0000D830 File Offset: 0x0000BA30
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool \u0003()
	{
		StackTrace stackTrace = new StackTrace();
		StackFrame frame = stackTrace.GetFrame(3);
		MethodBase methodBase = (frame == null) ? null : frame.GetMethod();
		Type type = (methodBase == null) ? null : methodBase.DeclaringType;
		return type != typeof(RuntimeMethodHandle) && type != null && type.Assembly == typeof(\u000F\u2001).Assembly;
	}

	// Token: 0x0600009C RID: 156 RVA: 0x0000D8A8 File Offset: 0x0000BAA8
	private static int \u0002(Type \u0002)
	{
		return \u0002.MetadataToken;
	}

	// Token: 0x04000094 RID: 148
	private static \u000F\u2001.\u0002 \u0002 = new \u000F\u2001.\u0002();

	// Token: 0x02000021 RID: 33
	private sealed class \u0002
	{
		// Token: 0x060000AD RID: 173 RVA: 0x0000D8B0 File Offset: 0x0000BAB0
		internal \u0002()
		{
			this.\u0002(0L);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000D8C0 File Offset: 0x0000BAC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal long \u0002()
		{
			if (Assembly.GetCallingAssembly() != typeof(\u000F\u2001.\u0002).Assembly)
			{
				return 2918384L;
			}
			if (!\u000F\u2001.\u0002())
			{
				return 2918384L;
			}
			int[] array = new int[]
			{
				0,
				0,
				0,
				~(-(~(-(-(~(~(-(~(-(~-1045932181))))))))))
			};
			array[1] = ~(-(~(-(-(~(~(-(~-2048989600))))))));
			array[2] = -(~(-(~(~(-(-(~(~-382933819))))))));
			array[0] = ~(-(~(-(-(~(~(-(~-434347950))))))));
			int num = this.\u0002;
			int num2 = this.\u0003;
			int num3 = -(~(-(~(~(-(-(~(~1640531528))))))));
			int num4 = ~(-(~(-(-(~(~(-(~957401309))))))));
			for (int num5 = 0; num5 != 32; num5++)
			{
				num2 -= ((num << 4 ^ num >> 5) + num ^ num4 + array[num4 >> 11 & 3]);
				num4 -= num3;
				num -= ((num2 << 4 ^ num2 >> 5) + num2 ^ num4 + array[num4 & 3]);
			}
			for (int num6 = 0; num6 != 4; num6++)
			{
				array[num6] = 0;
			}
			ulong num7 = (ulong)((ulong)((long)num2) << 32);
			return (long)(num7 | (ulong)num);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000D9EC File Offset: 0x0000BBEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void \u0002(long \u0002)
		{
			if (Assembly.GetCallingAssembly() != typeof(\u000F\u2001.\u0002).Assembly)
			{
				return;
			}
			if (!\u000F\u2001.\u0002())
			{
				return;
			}
			int[] array = new int[4];
			array[1] = ~(-(~(-(-(~(~(-(~(-(~-2048989601))))))))));
			array[0] = ~(-(-(~(~(-(-(~(-(~(~-434347947))))))))));
			array[2] = -(~(-(~(-(~(~(-(~-382933819))))))));
			array[3] = ~(-(~(-(-(~(~(-(~-1045932180))))))));
			int num = ~(-(~(-(-(~(~(-(~1640531524))))))));
			int num2 = (int)\u0002;
			int num3 = (int)(\u0002 >> 32);
			int num4 = 0;
			for (int num5 = 0; num5 != 32; num5++)
			{
				num2 += ((num3 << 4 ^ num3 >> 5) + num3 ^ num4 + array[num4 & 3]);
				num4 += num;
				num3 += ((num2 << 4 ^ num2 >> 5) + num2 ^ num4 + array[num4 >> 11 & 3]);
			}
			for (int num6 = 0; num6 != 4; num6++)
			{
				array[num6] = 0;
			}
			this.\u0002 = num2;
			this.\u0003 = num3;
		}

		// Token: 0x0400009A RID: 154
		private int \u0002;

		// Token: 0x0400009B RID: 155
		private int \u0003;
	}

	// Token: 0x02000022 RID: 34
	private static class \u0003
	{
		// Token: 0x060000B0 RID: 176 RVA: 0x0000DAF8 File Offset: 0x0000BCF8
		internal static int \u0002(int \u0002, int \u0003)
		{
			return \u0002 ^ \u0003 - -(~(-(~(-(~(~(-(~1113994853))))))));
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000DB0C File Offset: 0x0000BD0C
		internal static int \u0003(int \u0002, int \u0003)
		{
			return \u0002 - ~(-(~(-(~(-(-(~(~(-(~417531392)))))))))) ^ \u0003 + -(~(~(-(~(-(~(-(~-2119923981))))))));
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000DB34 File Offset: 0x0000BD34
		internal static int \u0005(int \u0002, int \u0003)
		{
			return \u0002 ^ (\u0003 - -(~(-(~(~(-(-(~(-(~(~59052470)))))))))) ^ \u0002 - \u0003);
		}
	}

	// Token: 0x02000023 RID: 35
	private sealed class \u0005
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x0000DB58 File Offset: 0x0000BD58
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int \u0002()
		{
			if (Assembly.GetCallingAssembly() != typeof(\u000F\u2001.\u0005).Assembly || !\u000F\u2001.\u0002())
			{
				return -1509110933;
			}
			return \u000F\u2001.\u0003.\u0005(\u000F\u2001.\u0003.\u0003(\u000F\u2001.\u0002(typeof(\u000F\u2001.\u0006)), \u000F\u2001.\u0003.\u0005(\u000F\u2001.\u0002(typeof(\u000F\u2001.\u0005)), \u000F\u2001.\u0002(typeof(\u000F\u2001.\u000F)))), \u000F\u2001.\u0002\u2000.\u0002());
		}
	}

	// Token: 0x02000024 RID: 36
	private sealed class \u0006
	{
		// Token: 0x060000B6 RID: 182 RVA: 0x0000DBD8 File Offset: 0x0000BDD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int \u0002()
		{
			if (Assembly.GetCallingAssembly() != typeof(\u000F\u2001.\u0006).Assembly || !\u000F\u2001.\u0002())
			{
				return -82806859;
			}
			return \u000F\u2001.\u0003.\u0002(\u000F\u2001.\u0002(typeof(\u000F\u2001.\u0008)), \u000F\u2001.\u0002(typeof(\u000F\u2001.\u000E)) ^ \u000F\u2001.\u0003.\u0003(\u000F\u2001.\u0002(typeof(\u000F\u2001.\u0006)), \u000F\u2001.\u0003.\u0005(\u000F\u2001.\u0002(typeof(\u000F\u2001.\u0002\u2000)), \u000F\u2001.\u000E.\u0002())));
		}
	}

	// Token: 0x02000025 RID: 37
	private sealed class \u0008
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x0000DC68 File Offset: 0x0000BE68
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int \u0002()
		{
			if (Assembly.GetCallingAssembly() != typeof(\u000F\u2001.\u0008).Assembly || !\u000F\u2001.\u0002())
			{
				return 1294352278;
			}
			return \u000F\u2001.\u0003.\u0005(\u000F\u2001.\u0003.\u0002(\u000F\u2001.\u0006.\u0002() ^ ~(-(-(~(~(-(~(-(~(-(~-527758450)))))))))), \u000F\u2001.\u0002(typeof(\u000F\u2001.\u000E))), \u000F\u2001.\u0003.\u0003(\u000F\u2001.\u0002(typeof(\u000F\u2001.\u0005)) ^ \u000F\u2001.\u0002(typeof(\u000F\u2001.\u0002\u2000)), -(~(-(~(~(-(-(~(~-1723311776))))))))));
		}
	}

	// Token: 0x02000026 RID: 38
	private sealed class \u000E
	{
		// Token: 0x060000BA RID: 186 RVA: 0x0000DD08 File Offset: 0x0000BF08
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int \u0002()
		{
			if (Assembly.GetCallingAssembly() != typeof(\u000F\u2001.\u000E).Assembly || !\u000F\u2001.\u0002())
			{
				return 402344241;
			}
			return \u000F\u2001.\u0003.\u0005(\u000F\u2001.\u0002(typeof(\u000F\u2001.\u000E)), \u000F\u2001.\u0003.\u0002(\u000F\u2001.\u0002(typeof(\u000F\u2001.\u0005)), \u000F\u2001.\u0003.\u0003(\u000F\u2001.\u0002(typeof(\u000F\u2001.\u0006)), \u000F\u2001.\u0003.\u0005(\u000F\u2001.\u0002(typeof(\u000F\u2001.\u0008)), \u000F\u2001.\u0003.\u0002(\u000F\u2001.\u0002(typeof(\u000F\u2001.\u000F)), \u000F\u2001.\u0002(typeof(\u000F\u2001.\u0002\u2000)))))));
		}
	}

	// Token: 0x02000027 RID: 39
	private sealed class \u000F
	{
		// Token: 0x060000BC RID: 188 RVA: 0x0000DDBC File Offset: 0x0000BFBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int \u0002()
		{
			if (Assembly.GetCallingAssembly() != typeof(\u000F\u2001.\u000F).Assembly || !\u000F\u2001.\u0002())
			{
				return -56237163;
			}
			return \u000F\u2001.\u0003.\u0003(\u000F\u2001.\u0003.\u0003(\u000F\u2001.\u0008.\u0002(), \u000F\u2001.\u0003.\u0002(\u000F\u2001.\u0002(typeof(\u000F\u2001.\u000F)), \u000F\u2001.\u0006.\u0002())), \u000F\u2001.\u0002(typeof(\u000F\u2001.\u0002\u2000)));
		}
	}

	// Token: 0x02000028 RID: 40
	private sealed class \u0002\u2000
	{
		// Token: 0x060000BE RID: 190 RVA: 0x0000DE34 File Offset: 0x0000C034
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int \u0002()
		{
			if (Assembly.GetCallingAssembly() != typeof(\u000F\u2001.\u0002\u2000).Assembly || !\u000F\u2001.\u0002())
			{
				return 1106695601;
			}
			return \u000F\u2001.\u0003.\u0002(\u000F\u2001.\u0002(typeof(\u000F\u2001.\u0002\u2000)), \u000F\u2001.\u0003.\u0005(\u000F\u2001.\u0003.\u0003(\u000F\u2001.\u0002(typeof(\u000F\u2001.\u000F)), \u000F\u2001.\u0002(typeof(\u000F\u2001.\u0005))), \u000F\u2001.\u0003.\u0005(\u000F\u2001.\u0002(typeof(\u000F\u2001.\u0008)) ^ -(~(-(~(-(~(~(-(-(~(~596406639)))))))))), \u000F\u2001.\u000F.\u0002())));
		}
	}
}
