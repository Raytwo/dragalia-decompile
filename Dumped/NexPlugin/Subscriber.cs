using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using nn;

namespace NexPlugin;

public static class Subscriber
{
	public delegate void PostContentCB(AsyncResult asyncResult, ulong contentId);

	public delegate void GetContentCB(AsyncResult asyncResult, List<SubscriberContent> contents);

	public delegate void GetContentsCB(AsyncResult asyncResult, List<List<SubscriberContent>> contents);

	public delegate void GetSubscriberUserStatusInfoCB(AsyncResult asyncResult, List<SubscriberUserStatusInfo> infos);

	public const uint MAX_TOPIC_CONTENT_SIZE = 100u;

	public const uint MAX_TIMELINE_CONTENT_SIZE = 100u;

	public const uint MAX_FOLLOWING_SIZE = 20u;

	public const uint NUM_RESERVED_TOPICS = 128u;

	public const uint INVALID_RESERVED_TOPIC_NUM = uint.MaxValue;

	public const uint MAX_GET_FOLLOWER_SIZE = 1000u;

	public const uint MAX_CONTENT_MESSAGE_LEN = 140u;

	public const uint MAX_CONTENT_BINARY_SIZE = 256u;

	public const uint MAX_POST_CONTENT_TOPIC_SIZE = 10u;

	public const uint MAX_GET_CONTENT_PARAMS_SIZE = 3u;

	public const byte STATUS_KEY_SIZE = 8;

	public const uint MAX_STATUS_BINARY_SIZE = 128u;

	public const uint MAX_GET_STATUS_USER_SIZE = 100u;

	public const uint DEFAULT_RMC_INTERVAL = 5000u;

	public static bool PostContentAsync(out uint asyncId, IntPtr pNgsFacade, SubscriberPostContentParam param, int timeOut = 0, [Optional] PostContentCB callback)
	{
		return default(bool);
	}

	public static bool GetContentAsync(out uint asyncId, IntPtr pNgsFacade, SubscriberGetContentParam param, int timeOut = 0, [Optional] GetContentCB callback)
	{
		return default(bool);
	}

	public static bool GetContentAsync(out uint asyncId, IntPtr pNgsFacade, List<SubscriberGetContentParam> param, int timeOut = 0, [Optional] GetContentsCB callback)
	{
		return default(bool);
	}

	public static bool DeleteContentAsync(out uint asyncId, IntPtr pNgsFacade, List<uint> topics, ulong contentId, int timeOut = 0, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool GetFriendUserStatusesAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0, [Optional] GetSubscriberUserStatusInfoCB callback)
	{
		return default(bool);
	}

	public static bool GetFriendUserStatusesAsync(out uint asyncId, IntPtr pNgsFacade, List<byte> keys, int timeOut = 0, [Optional] GetSubscriberUserStatusInfoCB callback)
	{
		return default(bool);
	}

	public static bool GetUserStatusesAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> users, List<byte> keys, int timeOut = 0, [Optional] GetSubscriberUserStatusInfoCB callback)
	{
		return default(bool);
	}

	public static bool UpdateUserStatusAsync(out uint asyncId, IntPtr pNgsFacade, List<SubscriberUserStatusParam> param, bool isNotify = false, int timeOut = 0, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static extern bool EnableFriendUserStatusesCache(IntPtr pNgsFacade);

	public static extern bool DisableFriendUserStatusesCache(IntPtr pNgsFacade);

	public static bool GetFriendUserStatusesCacheMode(IntPtr pNgsFacade, out bool result)
	{
		return default(bool);
	}

	public static bool GetFriendUserStatusesCacheLastResult(IntPtr pNgsFacade, out Result result)
	{
		return default(bool);
	}

	public static bool GetFriendUserStatuses(IntPtr pNgsFacade, out List<SubscriberUserStatusInfo> infos, out Result result)
	{
		return default(bool);
	}

	public static bool GetFriendUserStatuses(IntPtr pNgsFacade, List<ulong> users, out List<SubscriberUserStatusInfo> infos, out Result result)
	{
		return default(bool);
	}

	public static extern bool GetUserStatusRevision(IntPtr pNgsFacade, out uint revision);
}
