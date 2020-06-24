using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x0200000F RID: 15
[DesignerGenerated]
public sealed class \u000F\u2000 : ListView
{
	// Token: 0x0600005D RID: 93 RVA: 0x0000B584 File Offset: 0x00009784
	public \u000F\u2000()
	{
		base.ParentChanged += this.\u0002;
		base.MouseMove += this.\u0003;
		base.MouseUp += this.\u0005;
		base.ColumnClick += this.\u0002;
		base.KeyDown += this.\u0002;
		base.MouseDown += this.\u0002;
		this.\u0003 = null;
		this.\u0005 = Point.Empty;
		this.\u0008 = Point.Empty;
		this.AllowDrop = false;
		this.Font = new Font(\u0006\u2001.\u0002(-1829129742), 8f, FontStyle.Bold);
		this.Dock = DockStyle.Fill;
		this.FullRowSelect = true;
		this.View = View.Details;
		this.OwnerDraw = true;
		this.SetStyle(ControlStyles.UserPaint, false);
		this.DoubleBuffered = true;
		this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		this.SetStyle(ControlStyles.EnableNotifyMessage, true);
	}

	// Token: 0x0600005E RID: 94 RVA: 0x0000B68C File Offset: 0x0000988C
	[DebuggerNonUserCode]
	protected override void Dispose(bool \u0002)
	{
		try
		{
			if (\u0002 && this.\u0002 != null)
			{
				this.\u0002.Dispose();
			}
		}
		finally
		{
			base.Dispose(\u0002);
		}
	}

	// Token: 0x0600005F RID: 95 RVA: 0x0000B6D4 File Offset: 0x000098D4
	[DebuggerStepThrough]
	private void \u0002()
	{
		this.\u0002 = new Container();
	}

	// Token: 0x06000060 RID: 96 RVA: 0x0000B6E4 File Offset: 0x000098E4
	public void \u0003()
	{
		this.\u0005();
	}

	// Token: 0x06000061 RID: 97 RVA: 0x0000B6EC File Offset: 0x000098EC
	private void \u0002(object \u0002, KeyEventArgs \u0003)
	{
		if (\u0003.KeyCode == Keys.Space)
		{
			this.\u0005();
		}
		if (\u0003.KeyCode == Keys.A & \u0003.Control)
		{
			try
			{
				foreach (object obj in this.Items)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					listViewItem.Selected = true;
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

	// Token: 0x06000062 RID: 98 RVA: 0x0000B77C File Offset: 0x0000997C
	private void \u0002(object \u0002, MouseEventArgs \u0003)
	{
		if (\u0003.Button == MouseButtons.Left)
		{
			this.\u0003 = this.GetItemAt(\u0003.X, \u0003.Y);
			this.\u0005 = \u0003.Location;
		}
	}

	// Token: 0x06000063 RID: 99 RVA: 0x0000B7B4 File Offset: 0x000099B4
	protected override void OnDrawItem(DrawListViewItemEventArgs \u0002)
	{
		\u0002.DrawDefault = true;
		base.OnDrawItem(\u0002);
	}

	// Token: 0x06000064 RID: 100 RVA: 0x0000B7C4 File Offset: 0x000099C4
	protected override void OnDrawSubItem(DrawListViewSubItemEventArgs \u0002)
	{
		\u0002.DrawDefault = true;
		base.OnDrawSubItem(\u0002);
	}

	// Token: 0x06000065 RID: 101 RVA: 0x0000B7D4 File Offset: 0x000099D4
	private void \u0003(object \u0002, MouseEventArgs \u0003)
	{
		this.\u0008 = \u0003.Location;
		if (this.\u0005 == Point.Empty)
		{
			return;
		}
		if (this.\u0003 != null && this.\u0003.Index == -1)
		{
			this.\u0003 = null;
		}
		checked
		{
			if ((\u0003.Button == MouseButtons.Left & this.\u0003 != null) && this.\u0003 != null)
			{
				ListViewItem itemAt = this.GetItemAt(\u0003.X, \u0003.Y);
				if (itemAt != null)
				{
					if (itemAt.Index > this.\u0003.Index)
					{
						int index = this.\u0003.Index;
						int index2 = itemAt.Index;
						for (int i = index; i <= index2; i++)
						{
							if (!this.SelectedIndices.Contains(i))
							{
								this.SelectedIndices.Add(i);
							}
						}
						try
						{
							foreach (object obj in this.SelectedIndices)
							{
								object objectValue = RuntimeHelpers.GetObjectValue(obj);
								if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(objectValue, this.\u0003.Index, false), Operators.CompareObjectGreater(objectValue, itemAt.Index, false))))
								{
									this.SelectedIndices.Remove(Conversions.ToInteger(objectValue));
								}
							}
							return;
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
					int index3 = itemAt.Index;
					int index4 = this.\u0003.Index;
					for (int j = index3; j <= index4; j++)
					{
						if (!this.SelectedIndices.Contains(j))
						{
							this.SelectedIndices.Add(j);
						}
					}
					try
					{
						foreach (object obj2 in this.SelectedIndices)
						{
							object objectValue2 = RuntimeHelpers.GetObjectValue(obj2);
							if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(objectValue2, itemAt.Index, false), Operators.CompareObjectGreater(objectValue2, this.\u0003.Index, false))))
							{
								this.SelectedIndices.Remove(Conversions.ToInteger(objectValue2));
							}
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
				}
			}
		}
	}

	// Token: 0x06000066 RID: 102 RVA: 0x0000BA44 File Offset: 0x00009C44
	private void \u0005(object \u0002, MouseEventArgs \u0003)
	{
		this.\u0003 = null;
		this.\u0005 = Point.Empty;
	}

	// Token: 0x06000067 RID: 103 RVA: 0x0000BA58 File Offset: 0x00009C58
	public ListViewItem[] \u0002()
	{
		checked
		{
			ListViewItem[] result;
			lock (this)
			{
				List<ListViewItem> list = new List<ListViewItem>();
				if (this.Items.Count == 0)
				{
					result = list.ToArray();
				}
				else
				{
					try
					{
						ListViewItem listViewItem = this.TopItem;
						list.Add(listViewItem);
						int num = listViewItem.Index + 1;
						int num2 = this.Items.Count - 1;
						for (int i = num; i <= num2; i++)
						{
							try
							{
								listViewItem = this.Items[i];
								if (!this.Bounds.IntersectsWith(this.Items[i].Bounds))
								{
									break;
								}
								list.Add(listViewItem);
							}
							catch (Exception ex)
							{
								break;
							}
						}
					}
					catch (Exception ex2)
					{
					}
					result = list.ToArray();
				}
			}
			return result;
		}
	}

	// Token: 0x06000068 RID: 104 RVA: 0x0000BB70 File Offset: 0x00009D70
	public void \u0005()
	{
		checked
		{
			try
			{
				if (this.Columns.Count != 0)
				{
					if (this.Items.Count == 0)
					{
						this.Columns[this.Columns.Count - 1].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
					}
					else
					{
						int num = 0;
						int num2 = this.Columns.Count - 1;
						for (int i = num; i <= num2; i++)
						{
							this.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}
	}

	// Token: 0x06000069 RID: 105 RVA: 0x0000BC1C File Offset: 0x00009E1C
	protected override void OnDrawColumnHeader(DrawListViewColumnHeaderEventArgs \u0002)
	{
		try
		{
			StringFormat stringFormat = new StringFormat();
			stringFormat.FormatFlags = StringFormatFlags.NoWrap;
			stringFormat.Trimming = StringTrimming.EllipsisCharacter;
			stringFormat.Alignment = StringAlignment.Near;
			stringFormat.LineAlignment = StringAlignment.Near;
			Graphics graphics = \u0002.Graphics;
			Brush brush = new Pen(ControlPaint.Light(this.BackColor, 0.1f)).Brush;
			Rectangle bounds = new Rectangle(\u0002.Bounds.X, \u0002.Bounds.Y, \u0002.Bounds.Width, \u0002.Bounds.Height);
			graphics.FillRectangle(brush, bounds);
			\u0002.Graphics.DrawString(\u0002.Header.Text, this.Font, new Pen(this.ForeColor).Brush, \u0002.Bounds, stringFormat);
			Graphics graphics2 = \u0002.Graphics;
			Pen pen = new Pen(this.ForeColor);
			int x = \u0002.Bounds.X;
			int y = \u0002.Bounds.Y;
			int x2 = \u0002.Bounds.X;
			bounds = \u0002.Bounds;
			graphics2.DrawLine(pen, x, y, x2, checked(bounds.Y + \u0002.Bounds.Height));
			\u0002.DrawDefault = false;
		}
		catch (Exception ex)
		{
		}
		base.OnDrawColumnHeader(\u0002);
	}

	// Token: 0x0600006A RID: 106 RVA: 0x0000BD94 File Offset: 0x00009F94
	protected override void OnNotifyMessage(Message \u0002)
	{
		if (\u0002.Msg != 20)
		{
			base.OnNotifyMessage(\u0002);
		}
	}

	// Token: 0x0600006B RID: 107 RVA: 0x0000BDAC File Offset: 0x00009FAC
	public void \u0002(object \u0002, ColumnClickEventArgs \u0003)
	{
		lock (this)
		{
			if (\u0003.Column != -1)
			{
				try
				{
					ColumnHeader columnHeader = (ColumnHeader)NewLateBinding.LateGet(\u0002, null, \u0006\u2001.\u0002(-1829123412), new object[]
					{
						\u0003.Column
					}, null, null, null);
					SortOrder u;
					if (this.\u0006 == null)
					{
						u = SortOrder.Ascending;
						columnHeader.Tag = \u0006\u2001.\u0002(-1829128662);
					}
					else if (columnHeader.Equals(this.\u0006))
					{
						if (Operators.ConditionalCompareObjectEqual(this.\u0006.Tag, \u0006\u2001.\u0002(-1829128662), false))
						{
							u = SortOrder.Descending;
							this.\u0006.Tag = \u0006\u2001.\u0002(-1829128670);
						}
						else
						{
							this.\u0006.Tag = \u0006\u2001.\u0002(-1829128662);
							u = SortOrder.Ascending;
						}
					}
					else
					{
						u = SortOrder.Ascending;
					}
					this.\u0006 = columnHeader;
					if (this.\u0006.Tag == null)
					{
						this.\u0006.Tag = \u0006\u2001.\u0002(-1829128662);
					}
					if (\u0002 != null)
					{
						NewLateBinding.LateSet(\u0002, null, \u0006\u2001.\u0002(-1829123394), new object[]
						{
							new \u000F\u2000.\u0002(\u0003.Column, u)
						}, null, null);
						NewLateBinding.LateCall(\u0002, null, \u0006\u2001.\u0002(-1829123451), new object[0], null, null, null, true);
						NewLateBinding.LateSet(\u0002, null, \u0006\u2001.\u0002(-1829123394), new object[]
						{
							null
						}, null, null);
					}
				}
				catch (Exception ex)
				{
				}
			}
		}
	}

	// Token: 0x0600006C RID: 108 RVA: 0x0000BF88 File Offset: 0x0000A188
	private void \u0002(object \u0002, EventArgs \u0003)
	{
		try
		{
			if (this.Parent != null)
			{
				this.Parent.Resize -= delegate(object \u0002, EventArgs \u0003)
				{
					this.\u0003();
				};
			}
			this.Parent.Resize += delegate(object \u0002, EventArgs \u0003)
			{
				this.\u0003();
			};
		}
		catch (Exception ex)
		{
		}
	}

	// Token: 0x0400006E RID: 110
	private IContainer \u0002;

	// Token: 0x0400006F RID: 111
	private ListViewItem \u0003;

	// Token: 0x04000070 RID: 112
	private Point \u0005;

	// Token: 0x04000071 RID: 113
	private Point \u0008;

	// Token: 0x04000072 RID: 114
	public ColumnHeader \u0006;

	// Token: 0x02000014 RID: 20
	public sealed class \u0002 : IComparer
	{
		// Token: 0x06000077 RID: 119 RVA: 0x0000C3A0 File Offset: 0x0000A5A0
		public \u0002(int \u0002, SortOrder \u0003)
		{
			this.\u0002 = \u0002;
			this.\u0003 = \u0003;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000C3B8 File Offset: 0x0000A5B8
		public int Compare(object \u0002, object \u0003)
		{
			ListViewItem listViewItem = (ListViewItem)\u0002;
			ListViewItem listViewItem2 = (ListViewItem)\u0003;
			string text;
			if (listViewItem.SubItems.Count <= this.\u0002)
			{
				text = string.Empty;
			}
			else
			{
				text = listViewItem.SubItems[this.\u0002].Text;
			}
			string text2;
			if (listViewItem2.SubItems.Count <= this.\u0002)
			{
				text2 = string.Empty;
			}
			else
			{
				text2 = listViewItem2.SubItems[this.\u0002].Text;
			}
			if (this.\u0003 == SortOrder.Ascending)
			{
				if (Versioned.IsNumeric(text) & Versioned.IsNumeric(text2))
				{
					return Conversion.Val(text).CompareTo(Conversion.Val(text2));
				}
				if (Information.IsDate(text) & Information.IsDate(text2))
				{
					return DateTime.Parse(text).CompareTo(DateTime.Parse(text2));
				}
				return string.Compare(text, text2);
			}
			else
			{
				if (Versioned.IsNumeric(text) & Versioned.IsNumeric(text2))
				{
					return Conversion.Val(text2).CompareTo(Conversion.Val(text));
				}
				if (Information.IsDate(text) & Information.IsDate(text2))
				{
					return DateTime.Parse(text2).CompareTo(DateTime.Parse(text));
				}
				return string.Compare(text2, text);
			}
		}

		// Token: 0x04000085 RID: 133
		private int \u0002;

		// Token: 0x04000086 RID: 134
		private SortOrder \u0003;
	}
}
