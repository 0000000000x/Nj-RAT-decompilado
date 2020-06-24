using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

// Token: 0x02000002 RID: 2
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class \u0002 : WindowsFormsApplicationBase
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[DebuggerStepThrough]
	public \u0002() : base(AuthenticationMode.Windows)
	{
		this.IsSingleInstance = false;
		this.EnableVisualStyles = true;
		this.SaveMySettingsOnExit = true;
		this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002078 File Offset: 0x00000278
	[DebuggerHidden]
	[STAThread]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static void \u0002(string[] \u0002)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
		}
		finally
		{
		}
		\u0005.\u0002().Run(\u0002);
	}

	// Token: 0x06000003 RID: 3 RVA: 0x000020B0 File Offset: 0x000002B0
	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		this.MainForm = \u0005.\u0002().\u0002();
	}
}
