using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000007 RID: 7
[StandardModule]
internal sealed class \u000E
{
	// Token: 0x06000013 RID: 19 RVA: 0x00002240 File Offset: 0x00000440
	public static string \u0002(int \u0002, int \u0003)
	{
		if (\u0003 == 0)
		{
			return \u0006\u2001.\u0002(-1829139047);
		}
		return (double.Parse(Conversions.ToString(\u0002)) / double.Parse(Conversions.ToString(\u0003)) * 100.0 / 100.0).ToString(\u0006\u2001.\u0002(-1829139047)).Replace(\u0006\u2001.\u0002(-1829138963), \u0006\u2001.\u0002(-1829138975));
	}

	// Token: 0x06000014 RID: 20 RVA: 0x000022B8 File Offset: 0x000004B8
	public static int \u0002(int \u0002, int \u0003)
	{
		if (\u0003 == 0)
		{
			return 0;
		}
		return checked((int)Math.Round(unchecked((double)\u0002 / (double)\u0003 * 100.0)));
	}

	// Token: 0x06000015 RID: 21 RVA: 0x000022E4 File Offset: 0x000004E4
	public static string \u0002(string \u0002, string \u0003)
	{
		string result;
		try
		{
			result = Conversions.ToString(\u0005.\u0002().Registry.CurrentUser.OpenSubKey(\u0006\u2001.\u0002(-1829138953) + \u000E\u2000.\u0003).GetValue(\u0002, \u0003));
		}
		catch (Exception ex)
		{
			result = \u0003;
		}
		return result;
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002350 File Offset: 0x00000550
	public static void \u0002(string \u0002, string \u0003)
	{
		if (\u0003 == null)
		{
			\u0003 = string.Empty;
		}
		try
		{
			\u0005.\u0002().Registry.CurrentUser.CreateSubKey(\u0006\u2001.\u0002(-1829138953) + \u000E\u2000.\u0003).SetValue(\u0002, \u0003);
		}
		catch (Exception ex)
		{
		}
	}

	// Token: 0x06000017 RID: 23 RVA: 0x000023C0 File Offset: 0x000005C0
	public static string \u0002(string \u0002)
	{
		return \u000E.\u0002(\u000E.\u0002(ref \u0002));
	}

	// Token: 0x06000018 RID: 24 RVA: 0x000023DC File Offset: 0x000005DC
	public static string \u0002(byte[] \u0002)
	{
		MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
		\u0002 = md5CryptoServiceProvider.ComputeHash(\u0002);
		string text = string.Empty;
		foreach (byte b in \u0002)
		{
			text += b.ToString(\u0006\u2001.\u0002(-1829139001));
		}
		return text;
	}

	// Token: 0x06000019 RID: 25
	[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "memcpy")]
	public static extern IntPtr \u0002(IntPtr \u0002, IntPtr \u0003, int \u0005);

	// Token: 0x0600001A RID: 26 RVA: 0x00002438 File Offset: 0x00000638
	public static string \u0002(int \u0002)
	{
		Random random = new Random();
		string text = string.Empty;
		string text2 = \u0006\u2001.\u0002(-1829138978);
		checked
		{
			for (int i = 1; i <= \u0002; i++)
			{
				text += Conversions.ToString(text2[random.Next(0, text2.Length)]);
			}
			return text;
		}
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002494 File Offset: 0x00000694
	public static TreeNode \u0002(string \u0002, TreeNodeCollection \u0003)
	{
		if (\u0002.EndsWith(\u0006\u2001.\u0002(-1829139395)))
		{
			\u0002 = \u0002.Remove(checked(\u0002.Length - 1), 1);
		}
		TreeNode treeNode = null;
		foreach (string key in Strings.Split(\u0002, \u0006\u2001.\u0002(-1829139395), -1, CompareMethod.Binary))
		{
			treeNode = \u0003[key];
			\u0003 = treeNode.Nodes;
		}
		return treeNode;
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002508 File Offset: 0x00000708
	public static byte[] \u0002(byte[] \u0002, ref bool \u0003)
	{
		checked
		{
			if (\u0003)
			{
				MemoryStream memoryStream = new MemoryStream();
				GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Compress, true);
				gzipStream.Write(\u0002, 0, \u0002.Length);
				gzipStream.Dispose();
				memoryStream.Position = 0L;
				byte[] array = new byte[(int)memoryStream.Length + 1];
				memoryStream.Read(array, 0, array.Length);
				memoryStream.Dispose();
				return array;
			}
			MemoryStream memoryStream2 = new MemoryStream(\u0002);
			GZipStream gzipStream2 = new GZipStream(memoryStream2, CompressionMode.Decompress);
			byte[] array2 = new byte[4];
			memoryStream2.Position = memoryStream2.Length - 5L;
			memoryStream2.Read(array2, 0, 4);
			int num = BitConverter.ToInt32(array2, 0);
			memoryStream2.Position = 0L;
			byte[] array3 = new byte[num - 1 + 1];
			gzipStream2.Read(array3, 0, num);
			gzipStream2.Dispose();
			memoryStream2.Dispose();
			return array3;
		}
	}

	// Token: 0x0600001D RID: 29 RVA: 0x000025DC File Offset: 0x000007DC
	public static Array \u0002(byte[] \u0002, string \u0003)
	{
		List<byte[]> list = new List<byte[]>();
		checked
		{
			int num = Array.IndexOf<byte>(\u0002, (byte)Strings.Asc(\u0003[0]));
			while (num > -1 & num + \u0003.Length <= \u0002.Length)
			{
				byte[] array = new byte[\u0003.Length - 1 + 1];
				int num2 = 0;
				int num3 = num;
				int num4 = num + \u0003.Length - 1;
				for (int i = num3; i <= num4; i++)
				{
					array[num2] = \u0002[i];
					num2++;
				}
				if (Operators.CompareString(\u000E.\u0002(ref array), \u0003, false) == 0)
				{
					MemoryStream memoryStream = new MemoryStream();
					memoryStream.Write(\u0002, 0, num);
					list.Add(memoryStream.ToArray());
					memoryStream.Dispose();
					memoryStream = new MemoryStream();
					memoryStream.Write(\u0002, num + \u0003.Length, \u0002.Length - (num + \u0003.Length));
					list.Add(memoryStream.ToArray());
					memoryStream.Dispose();
					break;
				}
				num = Array.IndexOf<byte>(\u0002, (byte)Strings.Asc(\u0003[0]), num + 1);
			}
			if (list.Count == 0)
			{
				list.Add(\u0002);
			}
			return list.ToArray();
		}
	}

	// Token: 0x0600001E RID: 30 RVA: 0x0000270C File Offset: 0x0000090C
	public static Form \u0002(string \u0002)
	{
		return \u0005.\u0002().OpenForms[\u0002];
	}

	// Token: 0x0600001F RID: 31 RVA: 0x0000272C File Offset: 0x0000092C
	public static byte[] \u0002(ref string \u0002)
	{
		return Encoding.Default.GetBytes(\u0002);
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002748 File Offset: 0x00000948
	public static string \u0002(ref byte[] \u0002)
	{
		return Encoding.Default.GetString(\u0002);
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002764 File Offset: 0x00000964
	public static string \u0002()
	{
		return \u0005.\u0002().Clock.LocalTime.ToString(\u0006\u2001.\u0002(-1829139403));
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002794 File Offset: 0x00000994
	public static string \u0002(ref string \u0002)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(\u0002);
		return Convert.ToBase64String(bytes);
	}

	// Token: 0x06000023 RID: 35 RVA: 0x000027B8 File Offset: 0x000009B8
	public static int \u0002(int \u0002, int \u0003, bool \u0005)
	{
		checked
		{
			\u000E.\u0002 = (long)Math.Round(unchecked((double)\u000E.\u0002 + 333.33));
			Random random = new Random((int)\u000E.\u0002);
			return random.Next(\u0002, \u0003 + 1);
		}
	}

	// Token: 0x06000024 RID: 36 RVA: 0x000027F8 File Offset: 0x000009F8
	public static string \u0003(string \u0002)
	{
		int num = 0;
		checked
		{
			string result;
			for (;;)
			{
				try
				{
					byte[] bytes = Convert.FromBase64String(\u0002);
					result = Encoding.UTF8.GetString(bytes);
				}
				catch (Exception ex)
				{
					num++;
					if (num != 3)
					{
						\u0002 += \u0006\u2001.\u0002(-1829139452);
						continue;
					}
					result = null;
				}
				break;
			}
			return result;
		}
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002868 File Offset: 0x00000A68
	public static string \u0002(long \u0002)
	{
		if (\u0002.ToString().Length < 4)
		{
			return Conversions.ToString(\u0002) + \u0006\u2001.\u0002(-1829139428);
		}
		string str = string.Empty;
		double num = (double)\u0002 / 1024.0;
		if (num < 1024.0)
		{
			str = \u0006\u2001.\u0002(-1829139345);
		}
		else
		{
			num /= 1024.0;
			if (num < 1024.0)
			{
				str = \u0006\u2001.\u0002(-1829139354);
			}
			else
			{
				num /= 1024.0;
				str = \u0006\u2001.\u0002(-1829139331);
			}
		}
		return num.ToString(\u0006\u2001.\u0002(-1829139340)) + \u0006\u2001.\u0002(-1829139381) + str;
	}

	// Token: 0x04000006 RID: 6
	public static long \u0002 = 0L;
}
