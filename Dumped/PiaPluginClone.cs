using System;

public class PiaPluginClone
{
	public class BroadcastEvent
	{
		public enum State
		{
			NotSynchronized,
			Synchronizing
		}

		private static extern uint GetPayloadSizeMaxNative(ushort port);

		public static uint GetPayloadSizeMax(ushort port)
		{
			return default(uint);
		}

		private static extern State GetEventStateStationNative(ushort port, ulong constantId);

		public static State GetEventState(ushort port, ulong constantId)
		{
			return default(State);
		}

		private static extern bool IsInCommunicationNative(ushort port, ulong constantId);

		public static bool IsInCommunication(ushort port, ulong constantId)
		{
			return default(bool);
		}

		private static extern bool IsSynchronizingNative(ushort port);

		public static bool IsSynchronizing(ushort port)
		{
			return default(bool);
		}

		private static extern PiaPlugin.Result ReceiveNative(ushort port, out ulong srcConstantId, IntPtr pRecvBuf, out uint recvDataSize, uint recvBufSize);

		public static PiaPlugin.Result Receive(ushort port, out ulong srcConstantId, byte[] recvBuf, out uint recvDataSize)
		{
			return default(PiaPlugin.Result);
		}

		private static extern PiaPlugin.Result SendNative(ushort port, IntPtr pData, uint dataSize);

		public static PiaPlugin.Result Send(ushort port, byte[] data, uint dataSize)
		{
			return default(PiaPlugin.Result);
		}

		private static extern PiaPlugin.Result ReadySendNative(ushort port, uint dataSize);

		public static PiaPlugin.Result ReadySend(ushort port, uint dataSize)
		{
			return default(PiaPlugin.Result);
		}

		private static extern PiaPlugin.Result ReadyReceiveNative(ushort port, uint dataSize);

		public static PiaPlugin.Result ReadyReceive(ushort port, uint dataSize)
		{
			return default(PiaPlugin.Result);
		}

		private static extern void SetThroughputLimitNative(ushort port, uint throughputLimit);

		public static void SetThroughputLimit(ushort port, uint throughputLimit)
		{
		}
	}

	public class Atomic
	{
		public enum LockStatus
		{
			LockStatus_Unlocked,
			LockStatus_TryLock,
			LockStatus_Locked
		}

		private static extern void TryLockNative(uint id, uint priority);

		public static void TryLock(uint id, uint priority)
		{
		}

		private static extern void UnlockNative(uint id);

		public static void Unlock(uint id)
		{
		}

		private static extern LockStatus GetLockStatusNative(uint id);

		public static LockStatus GetLockStatus(uint id)
		{
			return default(LockStatus);
		}
	}

	public class Clock
	{
		public const ulong InvalidClock = ulong.MaxValue;

		private static extern PiaPlugin.Result GetClockNative(ref ulong pClock);

		public static PiaPlugin.Result GetClock(ref ulong pClock)
		{
			return default(PiaPlugin.Result);
		}

		private static extern bool IsSynchronizingClockNative();

		public static bool IsSynchronizingClock()
		{
			return default(bool);
		}

		private static extern PiaPlugin.Result SynchronizeClockNative();

		public static PiaPlugin.Result SynchronizeClock()
		{
			return default(PiaPlugin.Result);
		}

		private static extern void UpdateClockNative(ulong elapsedTime, ulong increaseTimeMin, ulong increaseTimeMax);

		public static void UpdateClock(ulong elapsedTime, ulong increaseTimeMin, ulong increaseTimeMax)
		{
		}
	}
}
