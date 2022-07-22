using System;
using System.Runtime.InteropServices;
using nn;
using nn.account;

namespace NexPlugin;

public static class NgsFacade
{
	public delegate void LoginCB(AsyncResult asyncResult, ulong principalId, IntPtr pNgsFacade);

	public delegate void TestConnectivityCB(AsyncResult asyncResult, bool result);

	public static bool RegisterNotificationEventHandler(NotificationEventCB callback)
	{
		return default(bool);
	}

	public static bool UnregisterNotificationEventHandler(NotificationEventCB callback)
	{
		return default(bool);
	}

	public static extern Result IsConnected(IntPtr pNgsFacade);

	public static extern ulong GetPrincipalID(IntPtr pNgsFacade);

	public static bool LoginAsync(out uint asyncId, uint gameServerId, string accessKey, NetworkServiceAccountId nsaId, byte[] nsaIdToken, int timeOut = 30000, [Optional] LoginCB callback)
	{
		return default(bool);
	}

	public static bool LogoutAsync(out uint asyncId, IntPtr pNgsFacade, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool TestConnectivityAsync(out uint asyncId, IntPtr pNgsFacade, [Optional] TestConnectivityCB callback)
	{
		return default(bool);
	}
}
