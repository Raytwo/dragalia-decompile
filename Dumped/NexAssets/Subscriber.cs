using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using NexPlugin;
using UnityEngine;
using nn;

namespace NexAssets;

public class Subscriber : Common
{
	private class POSTCONTENT_ARG : CORE_ARG
	{
		public SubscriberPostContentParam param;

		public int timeOut;

		public NexPlugin.Subscriber.PostContentCB callback;
	}

	private class GETCONTENT_ARG : CORE_ARG
	{
		public SubscriberGetContentParam param;

		public int timeOut;

		public NexPlugin.Subscriber.GetContentCB callback;
	}

	private class GETCONTENTS_ARG : CORE_ARG
	{
		public List<SubscriberGetContentParam> paramList;

		public int timeOut;

		public NexPlugin.Subscriber.GetContentsCB callback;
	}

	private class DELETECONTENT_ARG : CORE_ARG
	{
		public List<uint> topics;

		public ulong contentId;

		public int timeOut;

		public AsyncResultCB callback;
	}

	private class GETFRIENDUSERSTATUSES_ARG : CORE_ARG
	{
		public int timeOut;

		public List<byte> keys;

		public List<ulong> users;

		public NexPlugin.Subscriber.GetSubscriberUserStatusInfoCB callback;
	}

	private class UPDATEUSERSTATUS_ARG : CORE_ARG
	{
		public int timeOut;

		public List<SubscriberUserStatusParam> param;

		public bool isNotify;

		public AsyncResultCB callback;
	}

	private enum Functions
	{
		PostContent,
		GetContent,
		GetContents,
		DeleteContent,
		UpdateUserStatus,
		GetFriendUserStatuses,
		GetUserStatuses
	}

	[SerializeField]
	private bool m_IsPeriodObject;

	private Dictionary<int, FunctionInfo> FunctionInfos;

	private static List<ApiCallsFrequency> s_ApiCallsFrequencyList;

	public ASYNCSTATE PostContentAsync(SubscriberPostContentParam param, [Optional] NexPlugin.Subscriber.PostContentCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE PostContentAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE GetContentAsync(SubscriberGetContentParam param, [Optional] NexPlugin.Subscriber.GetContentCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE GetContentAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE GetContentsAsync(List<SubscriberGetContentParam> paramList, [Optional] NexPlugin.Subscriber.GetContentsCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE GetContentsAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE DeleteContentAsync(List<uint> topics, ulong contentId, [Optional] AsyncResultCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE DeleteContentAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE GetFriendUserStatusesAsync([Optional] NexPlugin.Subscriber.GetSubscriberUserStatusInfoCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE GetFriendUserStatusesAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE GetFriendUserStatusesAsync(List<byte> keys, [Optional] NexPlugin.Subscriber.GetSubscriberUserStatusInfoCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE GetFriendUserStatusesWithKeyAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE GetUserStatusesAsync(List<ulong> users, List<byte> keys, [Optional] NexPlugin.Subscriber.GetSubscriberUserStatusInfoCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE GetUserStatusesAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE UpdateUserStatusAsync(List<SubscriberUserStatusParam> param, bool isNotify = false, [Optional] AsyncResultCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE UpdateUserStatusAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public bool EnableFriendUserStatusesCache([Optional] IntPtr pNgsFacade)
	{
		return default(bool);
	}

	public bool DisableFriendUserStatusesCache([Optional] IntPtr pNgsFacade)
	{
		return default(bool);
	}

	public bool GetFriendUserStatusesCacheMode(out bool result, [Optional] IntPtr pNgsFacade)
	{
		return default(bool);
	}

	public bool GetFriendUserStatusesCacheLastResult(out Result result, [Optional] IntPtr pNgsFacade)
	{
		return default(bool);
	}

	public bool GetFriendUserStatuses(out List<SubscriberUserStatusInfo> infos, out Result result, [Optional] IntPtr pNgsFacade)
	{
		return default(bool);
	}

	public bool GetFriendUserStatuses(List<ulong> users, out List<SubscriberUserStatusInfo> infos, out Result result, [Optional] IntPtr pNgsFacade)
	{
		return default(bool);
	}

	public bool GetUserStatusRevision(out uint revision, [Optional] IntPtr pNgsFacade)
	{
		return default(bool);
	}

	private bool ApiCallsFrequencyCheck(int type)
	{
		return default(bool);
	}
}
