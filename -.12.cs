using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x0200000D RID: 13
public sealed class \u0008\u2000 : PictureBox
{
	// Token: 0x06000050 RID: 80 RVA: 0x00005F64 File Offset: 0x00004164
	public \u0008\u2000()
	{
		this.\u0002 = new List<object[]>();
		this.\u0005 = new Font(\u0006\u2001.\u0002(-1829129742), 8f, FontStyle.Bold);
		this.\u0008\u2000\u200A\u2009\u2000\u2005\u0002(new Timer
		{
			Interval = 50,
			Enabled = false
		});
		this.SizeMode = PictureBoxSizeMode.Normal;
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00005FC0 File Offset: 0x000041C0
	public void \u0002(object[] \u0002)
	{
		checked
		{
			lock (this)
			{
				for (int i = 0; i < \u0002.Length; i++)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(\u0002[i]);
					if (objectValue is Bitmap)
					{
						try
						{
							objectValue = RuntimeHelpers.GetObjectValue(((Bitmap)objectValue).Clone());
						}
						catch (Exception ex)
						{
						}
					}
				}
				this.\u0002.Add(\u0002);
				if (this.\u0002.Count == 100)
				{
					this.\u0002.RemoveAt(0);
				}
			}
		}
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00006078 File Offset: 0x00004278
	public Timer \u0008\u2000\u200A\u2009\u2000\u2005\u0002()
	{
		return this.\u0008;
	}

	// Token: 0x06000053 RID: 83 RVA: 0x0000608C File Offset: 0x0000428C
	[MethodImpl(MethodImplOptions.Synchronized)]
	public void \u0008\u2000\u200A\u2009\u2000\u2005\u0002(Timer \u0002)
	{
		EventHandler value = delegate(object \u0002, EventArgs \u0003)
		{
			this.\u0002();
		};
		if (this.\u0008 != null)
		{
			this.\u0008.Tick -= value;
		}
		this.\u0008 = \u00022;
		if (this.\u0008 != null)
		{
			this.\u0008.Tick += value;
		}
	}

	// Token: 0x06000054 RID: 84 RVA: 0x000060DC File Offset: 0x000042DC
	public void \u0002()
	{
		if (Operators.ConditionalCompareObjectEqual(\u000E\u2000.\u000F.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().Tag, \u0006\u2001.\u0002(-1829139276), false))
		{
			return;
		}
		this.\u0008\u2000\u200A\u2009\u2000\u2005\u0002().Enabled = false;
		if (this.Width < 1 | this.Height < 1)
		{
			return;
		}
		checked
		{
			lock (this)
			{
				try
				{
					Bitmap image = new Bitmap(this.Width, this.Height);
					this.\u0003 = Graphics.FromImage(image);
					this.\u0003.Clear(this.BackColor);
					int num = 3;
					int height = TextRenderer.MeasureText(\u0006\u2001.\u0002(-1829129786), this.\u0005).Height;
					Color color = Color.White;
					for (int i = this.\u0002.Count - 1; i >= 0; i += -1)
					{
						int num2 = 3;
						int num3 = 0;
						object[] array = this.\u0002[i];
						for (int j = 0; j < array.Length; j++)
						{
							object objectValue = RuntimeHelpers.GetObjectValue(array[j]);
							num3++;
							string left = objectValue.GetType().ToString();
							if (Operators.CompareString(left, typeof(Bitmap).ToString(), false) == 0)
							{
								Bitmap bitmap = (Bitmap)((Bitmap)objectValue).Clone();
								if (bitmap.Height > height)
								{
									IntPtr callbackData;
									bitmap = (Bitmap)bitmap.GetThumbnailImage(height, height, null, callbackData);
								}
								this.\u0003.DrawImage(bitmap, num2, num);
								num2 += bitmap.Width + 3;
							}
							else if (Operators.CompareString(left, typeof(string).ToString(), false) == 0)
							{
								string text = Conversions.ToString(objectValue);
								if (Operators.CompareString(text, \u0006\u2001.\u0002(-1829139159), false) == 0)
								{
									num2 = 0;
									int num4 = 0;
									object[] array2 = this.\u0002[i];
									for (int k = 0; k < array2.Length; k++)
									{
										object objectValue2 = RuntimeHelpers.GetObjectValue(array2[k]);
										num3++;
										if (num4 == num3)
										{
											break;
										}
										string left2 = objectValue2.GetType().ToString();
										if (Operators.CompareString(left2, typeof(Bitmap).ToString(), false) == 0)
										{
											num2 += ((Bitmap)objectValue2).Width + 3;
										}
										else if (Operators.CompareString(left2, typeof(string).ToString(), false) == 0)
										{
											num2 += TextRenderer.MeasureText(text, this.\u0005).Width + 3;
										}
									}
									num += height;
								}
								else
								{
									Size size = TextRenderer.MeasureText(text, this.\u0005);
									this.\u0003.DrawString(text, this.\u0005, new Pen(color).Brush, (float)num2, (float)num);
									if (size.Height - height > 0)
									{
										num += size.Height - height;
										num2 = 3;
									}
									else
									{
										num2 += size.Width + 3;
									}
								}
							}
							else if (Operators.CompareString(left, typeof(Color).ToString(), false) == 0)
							{
								object obj = objectValue;
								Color color2;
								color = ((obj != null) ? ((Color)obj) : color2);
							}
						}
						num += height;
					}
					this.\u0003.Dispose();
					this.Image = image;
				}
				catch (Exception ex)
				{
				}
			}
			this.\u0008\u2000\u200A\u2009\u2000\u2005\u0002().Enabled = true;
		}
	}

	// Token: 0x0400004F RID: 79
	public List<object[]> \u0002;

	// Token: 0x04000050 RID: 80
	public Graphics \u0003;

	// Token: 0x04000051 RID: 81
	public Font \u0005;

	// Token: 0x04000052 RID: 82
	[AccessedThroughProperty("T")]
	private Timer \u0008;
}
