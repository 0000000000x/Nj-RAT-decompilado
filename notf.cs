using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace njRAT
{
	// Token: 0x02000043 RID: 67
	[DesignerGenerated]
	public partial class notf : Form
	{
		// Token: 0x06000351 RID: 849 RVA: 0x000255D0 File Offset: 0x000237D0
		public notf()
		{
			base.Load += this.\u0003;
			this.\u0005 = true;
			this.Items = new List<notf.\u0002>();
			this.\u0002();
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0002564C File Offset: 0x0002384C
		[DebuggerStepThrough]
		private void \u0002()
		{
			this.rcwt3ggdl7sj2jy8ygczwqkrlwq3k78p\u200A\u2009\u2000\u2005\u0002(new PictureBox());
			((ISupportInitialize)this.rcwt3ggdl7sj2jy8ygczwqkrlwq3k78p\u200A\u2009\u2000\u2005\u0002()).BeginInit();
			this.SuspendLayout();
			this.rcwt3ggdl7sj2jy8ygczwqkrlwq3k78p\u200A\u2009\u2000\u2005\u0002().BackColor = Color.Black;
			this.rcwt3ggdl7sj2jy8ygczwqkrlwq3k78p\u200A\u2009\u2000\u2005\u0002().Cursor = Cursors.Hand;
			this.rcwt3ggdl7sj2jy8ygczwqkrlwq3k78p\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Fill;
			Control control = this.rcwt3ggdl7sj2jy8ygczwqkrlwq3k78p\u200A\u2009\u2000\u2005\u0002();
			Point location = new Point(0, 0);
			control.Location = location;
			this.rcwt3ggdl7sj2jy8ygczwqkrlwq3k78p\u200A\u2009\u2000\u2005\u0002().Name = \u0006\u2001.\u0002(-1829129003);
			Control control2 = this.rcwt3ggdl7sj2jy8ygczwqkrlwq3k78p\u200A\u2009\u2000\u2005\u0002();
			Size size = new Size(251, 100);
			control2.Size = size;
			this.rcwt3ggdl7sj2jy8ygczwqkrlwq3k78p\u200A\u2009\u2000\u2005\u0002().SizeMode = PictureBoxSizeMode.StretchImage;
			this.rcwt3ggdl7sj2jy8ygczwqkrlwq3k78p\u200A\u2009\u2000\u2005\u0002().TabIndex = 0;
			this.rcwt3ggdl7sj2jy8ygczwqkrlwq3k78p\u200A\u2009\u2000\u2005\u0002().TabStop = false;
			SizeF autoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			size = new Size(251, 100);
			this.ClientSize = size;
			this.Controls.Add(this.rcwt3ggdl7sj2jy8ygczwqkrlwq3k78p\u200A\u2009\u2000\u2005\u0002());
			this.FormBorderStyle = FormBorderStyle.None;
			this.Name = \u0006\u2001.\u0002(-1829119179);
			this.Opacity = 0.8;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.TopMost = true;
			this.TransparencyKey = Color.Transparent;
			((ISupportInitialize)this.rcwt3ggdl7sj2jy8ygczwqkrlwq3k78p\u200A\u2009\u2000\u2005\u0002()).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x000257A8 File Offset: 0x000239A8
		internal virtual PictureBox rcwt3ggdl7sj2jy8ygczwqkrlwq3k78p\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0003;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x000257BC File Offset: 0x000239BC
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void rcwt3ggdl7sj2jy8ygczwqkrlwq3k78p\u200A\u2009\u2000\u2005\u0002(PictureBox \u0002)
		{
			EventHandler value = new EventHandler(this.\u0002);
			if (this.\u0003 != null)
			{
				this.\u0003.Click -= value;
			}
			this.\u0003 = \u0002;
			if (this.\u0003 != null)
			{
				this.\u0003.Click += value;
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0002580C File Offset: 0x00023A0C
		private void \u0002(object \u0002, EventArgs \u0003)
		{
			List<notf.\u0002> items = this.Items;
			lock (items)
			{
				this.Items.Clear();
			}
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00025850 File Offset: 0x00023A50
		public void wrk()
		{
			checked
			{
				for (;;)
				{
					Thread.Sleep(50);
					if (this.Items.Count == 0)
					{
						this.go();
					}
					else
					{
						try
						{
							Bitmap bitmap = new Bitmap(this.rcwt3ggdl7sj2jy8ygczwqkrlwq3k78p\u200A\u2009\u2000\u2005\u0002().Width, this.rcwt3ggdl7sj2jy8ygczwqkrlwq3k78p\u200A\u2009\u2000\u2005\u0002().Height);
							Graphics graphics = Graphics.FromImage(bitmap);
							graphics.Clear(this.rcwt3ggdl7sj2jy8ygczwqkrlwq3k78p\u200A\u2009\u2000\u2005\u0002().BackColor);
							List<notf.\u0002> items = this.Items;
							lock (items)
							{
								try
								{
									foreach (notf.\u0002 u in this.Items)
									{
										if (u.\u0002 <= 2)
										{
											u.\u0002 = 2;
											notf.\u0002 u2 = u;
											u2.\u0008++;
										}
										else
										{
											int count = this.Items.Count;
											if (count > 30)
											{
												u.\u0002 = 2;
											}
											else if (count > 20)
											{
												notf.\u0002 u2 = u;
												u2.\u0002 += -20;
											}
											else if (count > 10)
											{
												notf.\u0002 u2 = u;
												u2.\u0002 += -10;
											}
											else
											{
												notf.\u0002 u2 = u;
												u2.\u0002 += -2;
											}
											if (u.\u0002 < 2)
											{
												u.\u0002 = 2;
											}
										}
										Size size = TextRenderer.MeasureText(u.\u0005, this.Font);
										size.Width = bitmap.Width;
										size.Height += 5;
										Graphics graphics2 = graphics;
										Brush black = Brushes.Black;
										Rectangle rectangle = new Rectangle(0, u.\u0002 - 2, this.Width, size.Height);
										graphics2.FillRectangle(black, rectangle);
										Graphics graphics3 = graphics;
										rectangle = new Rectangle(0, u.\u0002 - 2, this.Width, size.Height);
										ControlPaint.DrawLockedFrame(graphics3, rectangle, false);
										object instance = graphics;
										Type type = null;
										string memberName = \u0006\u2001.\u0002(-1829119133);
										object[] array = new object[2];
										array[0] = RuntimeHelpers.GetObjectValue(u.\u0003.Clone());
										object[] array2 = array;
										int num = 1;
										Point point = new Point(5, u.\u0002 - 2);
										array2[num] = point;
										NewLateBinding.LateCall(instance, type, memberName, array, null, null, null, true);
										graphics.DrawString(u.\u0005, this.Font, Brushes.LightSteelBlue, 5f, (float)u.\u0002);
										if (u.\u0002 > this.Height - 50)
										{
											break;
										}
									}
								}
								finally
								{
									List<notf.\u0002>.Enumerator enumerator;
									((IDisposable)enumerator).Dispose();
								}
								for (;;)
								{
									IL_25E:
									try
									{
										foreach (notf.\u0002 u3 in this.Items)
										{
											if (u3.\u0008 == 40)
											{
												this.Items.Remove(u3);
												goto IL_25E;
											}
										}
									}
									finally
									{
										List<notf.\u0002>.Enumerator enumerator2;
										((IDisposable)enumerator2).Dispose();
									}
									break;
								}
								if (this.Items.Count == 0 & this.\u0005)
								{
									this.go();
								}
								if (this.Items.Count > 0 & !this.\u0005)
								{
									this.back();
								}
							}
							graphics.Flush(FlushIntention.Sync);
							graphics.Dispose();
							this.rcwt3ggdl7sj2jy8ygczwqkrlwq3k78p\u200A\u2009\u2000\u2005\u0002().Image = bitmap;
						}
						catch (Exception ex)
						{
						}
					}
				}
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00025BFC File Offset: 0x00023DFC
		public void go()
		{
			this.\u0005 = false;
			Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
			this.Left = workingArea.Width;
			this.Top = workingArea.Height;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00025C38 File Offset: 0x00023E38
		public void back()
		{
			this.\u0005 = true;
			Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
			checked
			{
				this.Left = workingArea.Width - this.Width - 5;
				this.Top = workingArea.Height - this.Height - 5;
			}
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00025C84 File Offset: 0x00023E84
		private void \u0003(object \u0002, EventArgs \u0003)
		{
			this.rcwt3ggdl7sj2jy8ygczwqkrlwq3k78p\u200A\u2009\u2000\u2005\u0002().BackColor = Color.Pink;
			this.TransparencyKey = Color.Pink;
			this.back();
			Control.CheckForIllegalCrossThreadCalls = false;
			Thread thread = new Thread(new ThreadStart(this.wrk));
			thread.Start();
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00025CD4 File Offset: 0x00023ED4
		public void AddItem(Bitmap img, string Text)
		{
			List<notf.\u0002> items = this.Items;
			lock (items)
			{
				if (this.Items.Count > 50)
				{
					this.Items.RemoveAt(0);
				}
				this.Items.Add(new notf.\u0002
				{
					\u0003 = (Bitmap)img.Clone(),
					\u0005 = Text
				});
			}
		}

		// Token: 0x04000209 RID: 521
		[AccessedThroughProperty("P")]
		private PictureBox \u0003;

		// Token: 0x0400020A RID: 522
		private bool \u0005;

		// Token: 0x0400020B RID: 523
		public List<notf.\u0002> Items;

		// Token: 0x02000044 RID: 68
		public sealed class \u0002
		{
			// Token: 0x0600035C RID: 860 RVA: 0x00025D54 File Offset: 0x00023F54
			public \u0002()
			{
				this.\u0002 = global::\u0005.\u0002().\u0002().Height;
				this.\u0008 = 0;
			}

			// Token: 0x0400020C RID: 524
			public int \u0002;

			// Token: 0x0400020D RID: 525
			public Bitmap \u0003;

			// Token: 0x0400020E RID: 526
			public string \u0005;

			// Token: 0x0400020F RID: 527
			public int \u0008;
		}
	}
}
