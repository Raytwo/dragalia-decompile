using System.Runtime.InteropServices;
using nn;
using nn.account;

namespace NexPlugin;

public static class SmartDeviceVoiceChat
{
	public enum ShowAppResultStatus
	{
		SHOW_APP_RESULT_STATUS_ERROR,
		SHOW_APP_RESULT_STATUS_CANCELED
	}

	public delegate void GetAvailabilityCB(AsyncResult asyncResult, bool availability);

	public delegate void JoinRoomCB(AsyncResult asyncResult, SmartDeviceVoiceChatJoinRoomResult result);

	public delegate void ShowAppPageCB(AsyncResult asyncResult, SmartDeviceVoiceChatShowAppPageResult result);

	public const uint DEFAULT_CHANNELID = 0u;

	public const uint DEFAULT_HTTP_THREAD_PRIORITY = 16u;

	public const uint INVALID_ROOMID = 0u;

	public static bool ShowAppPageAsync(out uint asyncId, SmartDeviceVoiceChatShowAppPageParam param, [Optional] ShowAppPageCB callback)
	{
		return default(bool);
	}

	public static bool ChangeVoiceChatChannelAsync(out uint asyncId, SmartDeviceVoiceChatChangeVoiceChatChannelParam param, int timeOut = 0, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool GetAvailabilityAsync(out uint asyncId, int timeOut = 0, [Optional] GetAvailabilityCB callback)
	{
		return default(bool);
	}

	public static bool JoinRoomAsync(out uint asyncId, SmartDeviceVoiceChatJoinRoomParam param, int timeOut = 0, [Optional] JoinRoomCB callback)
	{
		return default(bool);
	}

	public static bool LeaveRoomAsync(out uint asyncId, SmartDeviceVoiceChatLeaveRoomParam param, int timeOut = 0, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool LeaveRoom(SmartDeviceVoiceChatLeaveRoomParam param)
	{
		return default(bool);
	}

	public static extern bool GetLastAccountNnResult(ref Result result);

	public static extern bool GetHttpThreadPriority(ref uint priority);

	public static extern bool SetHttpThreadPriority(uint httpThreadPriority);

	public static extern bool SetUserHandle(UserHandle userHandle);
}
