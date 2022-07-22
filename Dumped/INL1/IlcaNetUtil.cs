using System;
using System.Collections;
using NexPlugin;
using UnityEngine;
using nn.account;

namespace INL1;

public class IlcaNetUtil : IlcaNetServer
{
	public delegate void IlcaNetUtilInternetGoCallBack(bool isSuccess, IlcaNetUtilInternetGoResult res, ulong nexUniqueId, ulong nexUniqueIdPassword);

	public enum IlcaNetUtilConnectStatusEnum
	{
		None,
		Initialized,
		LoggedIn
	}

	public delegate void IlcaNetUtilInternetBackCallBack(bool isSuccess);

	private static bool next;

	private static bool abort;

	private static IlcaNetUtilInternetBackCallBack s_backCallback;

	public static bool InternetGo(MonoBehaviour callobj, UserHandle uh, ulong nexUniqueId, ulong nexUniqueIdPassword, bool ngsLogin, IlcaNetUtilInternetGoCallBack userCallback, bool freePass = false)
	{
		return default(bool);
	}

	private static IEnumerator InternetGoCore(MonoBehaviour callobj, UserHandle uh, ulong nexUniqueId, ulong nexUniqueIdPassword, bool ngsLogin, IlcaNetUtilInternetGoCallBack userCallback, bool freePass = false)
	{
		return null;
	}

	private static void InternetGoCallbackNEXUID(bool isSuccess, ulong nexUniqueId, ulong nexUniqueIdPassword)
	{
	}

	private static void InternetGoCallbackNSAIDT(bool isSuccess, IlcaNetServerCallbackEventType eve, IlcaNetServerCallbackResult result, long responseCode, string responseStr)
	{
	}

	private static void InternetGoNexFinalizeCallback()
	{
	}

	private static void InternetGoNexInitializeCallback(AsyncResult asyncResult)
	{
	}

	private static void InternetGoCallbackNGSlogin(AsyncResult asyncResult, ulong principalId, IntPtr pNgsFacade)
	{
	}

	private static void NextAbort(bool isSuccess)
	{
	}

	private static void FocusHandleNotify()
	{
	}

	public static IlcaNetUtilConnectStatusEnum InternetConnectStatus()
	{
		return default(IlcaNetUtilConnectStatusEnum);
	}

	public static bool InternetBack(MonoBehaviour callobj, IlcaNetUtilInternetBackCallBack userCallback)
	{
		return default(bool);
	}

	private static void InternetBackCallback()
	{
	}
}
