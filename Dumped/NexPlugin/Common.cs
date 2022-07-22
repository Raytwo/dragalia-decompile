using System;
using System.Runtime.InteropServices;

namespace NexPlugin;

public static class Common
{
	[Flags]
	public enum ThreadMode
	{
		ThreadModeSafeTransportBuffer = 1,
		ThreadModeUnsafeTransportBuffer = 2
	}

	[Flags]
	public enum DispachFlag
	{
		ContinueWhenEmpty = 1,
		DispatchKeepAliveOnly = 2
	}

	public enum NotificationEvents
	{
		ParticipationEvent = 3,
		OwnershipChangeEvent = 4,
		GatheringUnregistered = 109,
		HostChangeEvent = 110,
		GameNotificationLogout = 111,
		SubscriptionEvent = 112,
		GameServerMaintenance = 113,
		MaintenanceAnnouncement = 114,
		RoundStarted = 116,
		FirstRoundReportReceived = 117,
		RoundSummarized = 118,
		MatchmakeSystemConfigurationNotification = 119,
		MatchmakeSessionSystemPasswordSet = 120,
		MatchmakeSessionSystemPasswordClear = 121,
		AddedToGathering = 122,
		UserStatusUpdatedEvent = 128
	}

	public enum ParticipationEvents
	{
		Participate = 1,
		Disconnect = 7,
		EndParticipation = 8
	}

	public const ulong INVALID_PRINCIPALID = 0uL;

	public const ulong INVALID_UNIQUEID = 0uL;

	public const int DEFAULT_CORE_NO = 1;

	public const uint INFINITE_TIME_INTERVAL = 2147483647u;

	public static extern bool IsInitializedNex();

	public static extern bool IsNetworkConnected();

	public static extern bool InitializeNexPlugin(uint pluginMemSize);

	public static extern bool FinalizeNexPlugin();

	public static bool InitializeNexAsync(out uint asyncId, ThreadMode threadMode, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static extern bool InitializeNex(ThreadMode threadMode);

	public static bool FinalizeNexAsync(out uint asyncId, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static extern bool FinalizeNex();

	public static void SetTerminateImmediately(bool bTerminate)
	{
	}

	public static extern bool GetTerminateImmediately();

	public static extern bool SetThreadCoreNo(int coreNo);

	public static uint Dispatch(uint dispatchTimeout, [Optional] DispachFlag? dispatchFlags)
	{
		return default(uint);
	}

	public static void DispatchAll()
	{
	}

	public static uint GetReadyJobsSize()
	{
		return default(uint);
	}

	public static bool UpdateAsyncResult()
	{
		return default(bool);
	}

	public static void Wait(uint dispatchTimeout = 0u, [Optional] DispachFlag? dispatchFlags)
	{
	}

	public static extern void DumpMemory();

	public static int GetNexAsyncCallCount()
	{
		return default(int);
	}

	public static void DumpNexAsyncCallList()
	{
	}

	public static int GetAllocedCount()
	{
		return default(int);
	}

	public static int GetUsedAllocsize()
	{
		return default(int);
	}
}
