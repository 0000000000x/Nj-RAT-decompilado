using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000017 RID: 23
public sealed class \u0005\u2001 : DataGridView
{
	// Token: 0x06000083 RID: 131 RVA: 0x0000C6B0 File Offset: 0x0000A8B0
	public \u0005\u2001()
	{
		this.\u0002 = new Collection();
		this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
		this.RowHeadersVisible = false;
		this.DoubleBuffered = true;
		this.ShowCellErrors = true;
		this.ShowEditingIcon = true;
		this.ShowRowErrors = true;
		this.Font = new Font(\u0006\u2001.\u0002(-1829129742), 8f, FontStyle.Bold);
		this.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
		this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.EnableNotifyMessage | ControlStyles.OptimizedDoubleBuffer, true);
	}

	// Token: 0x06000084 RID: 132 RVA: 0x0000C734 File Offset: 0x0000A934
	public DataGridViewRow \u0002(int \u0002)
	{
		return (DataGridViewRow)this.\u0002[checked(\u0002 + 1)];
	}

	// Token: 0x06000085 RID: 133 RVA: 0x0000C754 File Offset: 0x0000A954
	public DataGridViewRow \u0002(string \u0002)
	{
		return (DataGridViewRow)this.\u0002[\u0002];
	}

	// Token: 0x06000086 RID: 134 RVA: 0x0000C774 File Offset: 0x0000A974
	public bool \u0002(string \u0002)
	{
		return this.\u0002.Contains(\u0002);
	}

	// Token: 0x06000087 RID: 135 RVA: 0x0000C790 File Offset: 0x0000A990
	public DataGridViewRow[] \u0002()
	{
		List<DataGridViewRow> list = new List<DataGridViewRow>();
		if (this.RowCount == 0)
		{
			return list.ToArray();
		}
		checked
		{
			try
			{
				int firstDisplayedScrollingRowIndex = this.FirstDisplayedScrollingRowIndex;
				int num = this.FirstDisplayedScrollingRowIndex + this.DisplayedRowCount(false);
				for (int i = firstDisplayedScrollingRowIndex; i <= num; i++)
				{
					if (i > this.RowCount - 1)
					{
						break;
					}
					try
					{
						list.Add(this.Rows[i]);
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
			return list.ToArray();
		}
	}

	// Token: 0x06000088 RID: 136 RVA: 0x0000C850 File Offset: 0x0000AA50
	public void \u0002()
	{
		Collection u = this.\u0002;
		lock (u)
		{
			this.Rows.Clear();
			this.\u0002.Clear();
		}
	}

	// Token: 0x06000089 RID: 137 RVA: 0x0000C89C File Offset: 0x0000AA9C
	public DataGridViewRow \u0002(object[] \u0002)
	{
		if (this.InvokeRequired)
		{
			Collection u = this.\u0002;
			lock (u)
			{
				return (DataGridViewRow)this.Invoke(new \u0005\u2001.\u0002(this.\u0002), \u0002);
			}
		}
		DataGridViewRow dataGridViewRow = new DataGridViewRow();
		int num = 0;
		checked
		{
			int num2 = this.ColumnCount - 1;
			for (int i = num; i <= num2; i++)
			{
				switch (Conversions.ToInteger(this.Columns[i].Tag))
				{
				case 0:
					dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
					{
						Value = RuntimeHelpers.GetObjectValue(\u0002[i])
					});
					break;
				case 1:
					dataGridViewRow.Cells.Add(new DataGridViewLinkCell
					{
						Value = RuntimeHelpers.GetObjectValue(\u0002[i])
					});
					break;
				case 2:
					dataGridViewRow.Cells.Add(new DataGridViewImageCell
					{
						Value = RuntimeHelpers.GetObjectValue(\u0002[i]),
						ImageLayout = DataGridViewImageCellLayout.Normal
					});
					break;
				case 3:
					dataGridViewRow.Cells.Add(new DataGridViewImageCell
					{
						Value = RuntimeHelpers.GetObjectValue(\u0002[i]),
						ImageLayout = DataGridViewImageCellLayout.Stretch
					});
					break;
				}
			}
			dataGridViewRow.Resizable = DataGridViewTriState.False;
			this.\u0002.Add(dataGridViewRow, null, null, null);
			this.Rows.Add(dataGridViewRow);
			return dataGridViewRow;
		}
	}

	// Token: 0x0600008A RID: 138 RVA: 0x0000CA24 File Offset: 0x0000AC24
	public int \u0002()
	{
		return this.RowTemplate.Height;
	}

	// Token: 0x0600008B RID: 139 RVA: 0x0000CA3C File Offset: 0x0000AC3C
	public void \u0002(int \u0002)
	{
		this.RowTemplate.Height = \u0002;
	}

	// Token: 0x0600008C RID: 140 RVA: 0x0000CA4C File Offset: 0x0000AC4C
	protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs \u0002)
	{
		try
		{
			DataGridViewRow dataGridViewRow = this.Rows[\u0002.RowIndex];
			if (dataGridViewRow.Height != this.\u0002())
			{
				dataGridViewRow.Height = this.\u0002();
			}
		}
		catch (Exception ex)
		{
		}
		base.OnRowPostPaint(\u0002);
	}

	// Token: 0x0600008D RID: 141 RVA: 0x0000CAB8 File Offset: 0x0000ACB8
	public DataGridViewRow \u0002(string \u0002, object[] \u0003)
	{
		if (this.InvokeRequired)
		{
			Collection u = this.\u0002;
			lock (u)
			{
				return (DataGridViewRow)this.Invoke(new \u0005\u2001.\u0003(this.\u0002), new object[]
				{
					\u0002,
					\u0003
				});
			}
		}
		DataGridViewRow dataGridViewRow = new DataGridViewRow();
		dataGridViewRow.Height = this.\u0002();
		int num = 0;
		checked
		{
			int num2 = this.ColumnCount - 1;
			for (int i = num; i <= num2; i++)
			{
				switch (Conversions.ToInteger(this.Columns[i].Tag))
				{
				case 0:
					dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
					{
						Value = RuntimeHelpers.GetObjectValue(\u0003[i])
					});
					break;
				case 1:
					dataGridViewRow.Cells.Add(new DataGridViewLinkCell
					{
						Value = RuntimeHelpers.GetObjectValue(\u0003[i])
					});
					break;
				case 2:
					dataGridViewRow.Cells.Add(new DataGridViewImageCell
					{
						Value = RuntimeHelpers.GetObjectValue(\u0003[i]),
						ImageLayout = DataGridViewImageCellLayout.Zoom
					});
					break;
				case 3:
					dataGridViewRow.Cells.Add(new DataGridViewImageCell
					{
						Value = RuntimeHelpers.GetObjectValue(\u0003[i]),
						ImageLayout = DataGridViewImageCellLayout.Stretch
					});
					break;
				}
			}
			dataGridViewRow.Resizable = DataGridViewTriState.False;
			this.\u0002.Add(dataGridViewRow, \u0002, null, null);
			this.Rows.Add(dataGridViewRow);
			return dataGridViewRow;
		}
	}

	// Token: 0x0600008E RID: 142 RVA: 0x0000CC60 File Offset: 0x0000AE60
	public void \u0002(DataGridViewRow \u0002)
	{
		if (this.InvokeRequired)
		{
			Collection u = this.\u0002;
			lock (u)
			{
				this.Invoke(new \u0005\u2001.\u0005(this.\u0002), new object[]
				{
					\u0002
				});
				return;
			}
		}
		this.Rows.Remove(\u0002);
	}

	// Token: 0x0600008F RID: 143 RVA: 0x0000CCD4 File Offset: 0x0000AED4
	public void \u0003(int \u0002)
	{
		if (this.InvokeRequired)
		{
			Collection u = this.\u0002;
			lock (u)
			{
				this.Invoke(new \u0005\u2001.\u0008(this.\u0003), new object[]
				{
					\u0002
				});
				return;
			}
		}
		this.Rows.RemoveAt(\u0002);
	}

	// Token: 0x06000090 RID: 144 RVA: 0x0000CD4C File Offset: 0x0000AF4C
	public void \u0002(string \u0002, \u0005\u2001.\u0006 \u0003, DataGridViewAutoSizeColumnMode \u0005)
	{
		Collection u = this.\u0002;
		lock (u)
		{
			DataGridViewColumn dataGridViewColumn = null;
			switch (\u0003)
			{
			case \u0005\u2001.\u0006.Text:
				dataGridViewColumn = new DataGridViewTextBoxColumn();
				break;
			case \u0005\u2001.\u0006.Link:
				dataGridViewColumn = new DataGridViewLinkColumn();
				break;
			case \u0005\u2001.\u0006.Image:
				dataGridViewColumn = new DataGridViewImageColumn
				{
					ImageLayout = DataGridViewImageCellLayout.Zoom
				};
				break;
			case \u0005\u2001.\u0006.StretchImage:
				dataGridViewColumn = new DataGridViewImageColumn
				{
					ImageLayout = DataGridViewImageCellLayout.Stretch
				};
				break;
			}
			dataGridViewColumn.AutoSizeMode = \u0005;
			dataGridViewColumn.Tag = \u0003;
			dataGridViewColumn.HeaderText = \u0002;
			this.Columns.Add(dataGridViewColumn);
		}
	}

	// Token: 0x06000091 RID: 145 RVA: 0x0000CE00 File Offset: 0x0000B000
	protected override void OnMouseUp(MouseEventArgs \u0002)
	{
		if (\u0002.Button == MouseButtons.Right)
		{
			try
			{
				DataGridView.HitTestInfo hitTestInfo = this.HitTest(\u0002.X, \u0002.Y);
				if (hitTestInfo.RowIndex != -1)
				{
					DataGridViewRow dataGridViewRow = this.Rows[hitTestInfo.RowIndex];
					if (!dataGridViewRow.Selected)
					{
						this.ClearSelection();
						dataGridViewRow.Selected = true;
					}
				}
			}
			catch (Exception ex)
			{
			}
		}
		base.OnMouseUp(\u0002);
	}

	// Token: 0x06000092 RID: 146 RVA: 0x0000CE94 File Offset: 0x0000B094
	protected override void OnMouseWheel(MouseEventArgs \u0002)
	{
		base.OnMouseWheel(\u0002);
		checked
		{
			try
			{
				int delta = \u0002.Delta;
				if (delta == 120)
				{
					this.FirstDisplayedScrollingRowIndex = Math.Max(0, this.FirstDisplayedScrollingRowIndex - SystemInformation.MouseWheelScrollLines);
				}
				else if (delta == -120)
				{
					this.FirstDisplayedScrollingRowIndex += SystemInformation.MouseWheelScrollLines;
				}
			}
			catch (Exception ex)
			{
			}
		}
	}

	// Token: 0x04000089 RID: 137
	private Collection \u0002;

	// Token: 0x0200001C RID: 28
	// (Invoke) Token: 0x060000A0 RID: 160
	private delegate DataGridViewRow \u0002(object[] \u0002);

	// Token: 0x0200001D RID: 29
	// (Invoke) Token: 0x060000A4 RID: 164
	private delegate DataGridViewRow \u0003(string \u0002, object[] \u0003);

	// Token: 0x0200001E RID: 30
	// (Invoke) Token: 0x060000A8 RID: 168
	private delegate void \u0005(DataGridViewRow \u0002);

	// Token: 0x0200001F RID: 31
	public enum \u0006
	{
		// Token: 0x04000096 RID: 150
		Text,
		// Token: 0x04000097 RID: 151
		Link,
		// Token: 0x04000098 RID: 152
		Image,
		// Token: 0x04000099 RID: 153
		StretchImage
	}

	// Token: 0x02000020 RID: 32
	// (Invoke) Token: 0x060000AC RID: 172
	private delegate void \u0008(int \u0002);
}
