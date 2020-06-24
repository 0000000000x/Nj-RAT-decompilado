using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace njRAT.My
{
	// Token: 0x02000041 RID: 65
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[CompilerGenerated]
	internal sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x06000344 RID: 836 RVA: 0x00025060 File Offset: 0x00023260
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[DebuggerNonUserCode]
		private static void AutoSaveSettings(object sender, EventArgs e)
		{
			if (\u0005.\u0002().SaveMySettingsOnExit)
			{
				\u0003\u2001.\u0002().Save();
			}
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000345 RID: 837 RVA: 0x0002507C File Offset: 0x0002327C
		public static MySettings Default
		{
			get
			{
				if (!MySettings.addedHandler)
				{
					object obj = MySettings.addedHandlerLockObject;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						if (!MySettings.addedHandler)
						{
							\u0005.\u0002().Shutdown += MySettings.AutoSaveSettings;
							MySettings.addedHandler = true;
						}
					}
				}
				return MySettings.defaultInstance;
			}
		}

		// Token: 0x040001FF RID: 511
		private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

		// Token: 0x04000200 RID: 512
		private static bool addedHandler;

		// Token: 0x04000201 RID: 513
		private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
	}
}
