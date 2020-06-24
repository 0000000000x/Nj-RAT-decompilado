using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02000018 RID: 24
internal static class \u0006\u2001
{
	// Token: 0x06000094 RID: 148 RVA: 0x0000CF28 File Offset: 0x0000B128
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string \u0002(int \u0002)
	{
		string result;
		lock (\u0006\u2001.\u0002)
		{
			string text;
			while (!\u0006\u2001.\u0002.TryGetValue(\u0002, out text))
			{
				int num3;
				if (\u0006\u2001.\u0003 == null)
				{
					Assembly executingAssembly = Assembly.GetExecutingAssembly();
					Assembly assembly = Assembly.GetCallingAssembly();
					\u0006\u2001.\u0006 = 1610370;
					Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("\u2005\u2009\u2001\u2001\u2007\u2004\u2006\u2007\u2001\u200a");
					int num = 1;
					StackTrace stackTrace = new StackTrace(num, false);
					\u0006\u2001.\u0006 ^= (6470 | num);
					num--;
					StackFrame frame = stackTrace.GetFrame(num);
					MethodBase methodBase = (frame == null) ? null : frame.GetMethod();
					\u0006\u2001.\u0006 ^= num + 128;
					Type type = (methodBase == null) ? null : methodBase.DeclaringType;
					if (frame == null)
					{
						\u0006\u2001.\u0006 ^= 219315;
					}
					bool flag = type == typeof(RuntimeMethodHandle);
					\u0006\u2001.\u0006 ^= 160;
					if (!flag)
					{
						flag = (type == null);
						if (flag)
						{
							\u0006\u2001.\u0006 ^= 219283;
						}
					}
					if (flag == (stackTrace != null))
					{
						\u0006\u2001.\u0006 ^= 32;
					}
					\u0006\u2001.\u0006 ^= (6502 | num + 1);
					\u0006\u2001.\u0003 = new BinaryReader(manifestResourceStream);
					short num2 = \u0006\u2001.\u0003.ReadInt16() ^ ~(-(-(~(~(-(-(~(~(-(~-23493))))))))));
					if (num2 == 0)
					{
						\u0006\u2001.\u0008 = (\u0006\u2001.\u0003.ReadInt16() ^ -(~(~(-(-(~(-(~(~22396)))))))));
					}
					else
					{
						\u0006\u2001.\u0005 = \u0006\u2001.\u0003.ReadBytes((int)num2);
					}
					assembly = executingAssembly;
					AssemblyName assemblyName;
					try
					{
						assemblyName = assembly.GetName();
					}
					catch
					{
						assemblyName = new AssemblyName(assembly.FullName);
					}
					\u0006\u2001.\u000E = assemblyName.GetPublicKeyToken();
					if (\u0006\u2001.\u000E != null && \u0006\u2001.\u000E.Length == 0)
					{
						\u0006\u2001.\u000E = null;
					}
					num3 = 1265964285;
					long num4 = \u000F\u2001.\u0002();
					num3 ^= (int)((uint)num4);
					num3 ^= -(~(-(~(-(~(~(-(-(~(~1299258884))))))))));
					\u0006\u2001.\u000F = num3;
					\u0006\u2001.\u0006 = ((\u0006\u2001.\u0006 & 268435314) ^ 6788);
				}
				else
				{
					num3 = \u0006\u2001.\u000F;
				}
				int num5 = \u0002 ^ -2069188374 ^ num3;
				\u0006\u2001.\u0003.BaseStream.Position = (long)num5;
				byte[] array;
				if (\u0006\u2001.\u0005 != null)
				{
					array = \u0006\u2001.\u0005;
				}
				else
				{
					short num6;
					if (\u0006\u2001.\u0008 == -1)
					{
						num6 = (short)((int)(\u0006\u2001.\u0003.ReadInt16() ^ -10118) ^ num5);
					}
					else
					{
						num6 = \u0006\u2001.\u0008;
					}
					if (num6 == 0)
					{
						array = null;
					}
					else
					{
						array = \u0006\u2001.\u0003.ReadBytes((int)num6);
						for (int num7 = 0; num7 != array.Length; num7++)
						{
							byte[] array2 = array;
							int num8 = num7;
							array2[num8] ^= (byte)(\u0006\u2001.\u000F >> ((num7 & 3) << 3));
						}
					}
				}
				int num9 = \u0006\u2001.\u0003.ReadInt32() ^ num5 ^ -(~(-(~(-(~(~(-(-(~(~-1241042075)))))))))) ^ num3;
				if (num9 != -2)
				{
					bool flag2 = (num9 & int.MinValue) != 0;
					bool flag3 = (num9 & 1073741824) != 0;
					bool flag4 = (num9 & 536870912) != 0;
					num9 &= 536870911;
					byte[] array3 = \u000E\u2001.\u0002(array, \u0006\u2001.\u0003.ReadBytes(num9));
					if (\u0006\u2001.\u000E != null != (\u0006\u2001.\u0006 != 1607814))
					{
						for (int i = 0; i < num9; i++)
						{
							byte b = \u0006\u2001.\u000E[i & 7];
							b = (byte)((int)b << 3 | b >> 5);
							array3[i] ^= b;
						}
					}
					int num10 = \u0006\u2001.\u0006 - 12;
					byte[] array4;
					int num11;
					if (!flag3)
					{
						array4 = array3;
						num11 = num9;
					}
					else
					{
						num11 = ((int)array3[2] | (int)array3[0] << 16 | (int)array3[3] << 8 | (int)array3[1] << 24);
						array4 = new byte[num11];
						\u0006\u2001.\u0002(array3, 4, array4);
					}
					if (flag2 && num10 == 1607802)
					{
						char[] array5 = new char[num11];
						for (int j = 0; j < num11; j++)
						{
							array5[j] = (char)array4[j];
						}
						text = new string(array5);
					}
					else
					{
						text = Encoding.Unicode.GetString(array4, 0, array4.Length);
					}
					num10 += 127 + (num10 & 3) << 5;
					if (num10 != 1611930)
					{
						text = (\u0002 + num9 ^ 936568 ^ (num10 & 1293)).ToString("X");
					}
					if (!flag4)
					{
						text = string.Intern(text);
						\u0006\u2001.\u0002.Add(\u0002, text);
						if (\u0006\u2001.\u0002.Count == 1479)
						{
							\u0006\u2001.\u0003.Close();
							\u0006\u2001.\u0003 = null;
							\u0006\u2001.\u0005 = (\u0006\u2001.\u000E = null);
						}
					}
					return text;
				}
				byte[] array6 = \u0006\u2001.\u0003.ReadBytes(4);
				\u0002 = (1241042077 ^ num3);
				\u0002 = (((int)array6[2] | (int)array6[3] << 16 | (int)array6[0] << 8 | (int)array6[1] << 24) ^ -\u0002);
			}
			result = text;
		}
		return result;
	}

	// Token: 0x06000095 RID: 149 RVA: 0x0000D4C0 File Offset: 0x0000B6C0
	private static void \u0002(byte[] \u0002, int \u0003, byte[] \u0005)
	{
		int i = 0;
		int num = 0;
		int num2 = 128;
		int num3 = \u0005.Length;
		while (i < num3)
		{
			if ((num2 <<= 1) == 256)
			{
				num2 = 1;
				num = (int)\u0002[\u0003++];
			}
			if ((num & num2) != 0)
			{
				int num4 = (\u0002[\u0003] >> 2) + 3;
				int num5 = ((int)\u0002[\u0003] << 8 | (int)\u0002[\u0003 + 1]) & 1023;
				\u0003 += 2;
				int num6 = i - num5;
				if (num6 < 0)
				{
					return;
				}
				while (--num4 >= 0)
				{
					if (i >= num3)
					{
						break;
					}
					\u0005[i++] = \u0005[num6++];
				}
			}
			else
			{
				\u0005[i++] = \u0002[\u0003++];
			}
		}
	}

	// Token: 0x0400008A RID: 138
	private static readonly Dictionary<int, string> \u0002 = new Dictionary<int, string>(1479);

	// Token: 0x0400008B RID: 139
	private static BinaryReader \u0003;

	// Token: 0x0400008C RID: 140
	private static byte[] \u0005;

	// Token: 0x0400008D RID: 141
	private static short \u0008;

	// Token: 0x0400008E RID: 142
	private static int \u0006;

	// Token: 0x0400008F RID: 143
	private static byte[] \u000E;

	// Token: 0x04000090 RID: 144
	private static int \u000F;
}
