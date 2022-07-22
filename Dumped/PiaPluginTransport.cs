using System;
using System.Runtime.InteropServices;

public class PiaPluginTransport
{
	[StructLayout(0)]
	public class EmulationSetting
	{
		public int sendThreadPacketLossRatio;

		public int receiveThreadPacketLossRatio;

		public int sendThreadLatencyEmulationMin;

		public int sendThreadLatencyEmulationMax;

		public int receiveThreadLatencyEmulationMin;

		public int receiveThreadLatencyEmulationMax;
	}

	public struct TransportAnalysisData
	{
		public PacketAnalysisData sendPacketAnalysisData;

		public PacketAnalysisData sendUnicastPacketAnalysisData;

		public PacketAnalysisData sendBroadcastPacketAnalysisData;

		public PacketAnalysisData recvPacketAnalysisData;

		public ConnectionAnalysisData connectionAnalysisData;

		public uint dispatchCount;

		private static extern void PrintNative([In] IntPtr data, bool isDetail, bool isTotalOnly);

		public void Print(bool isDetail, bool isTotalOnly)
		{
		}
	}

	public struct ConnectionAnalysisData
	{
		public struct Entry
		{
			public int rtt;

			public int rttMin;

			public int rttMax;

			public uint prevTotalUnicastPacketNum;

			public uint currTotalUnicastPacketNum;

			public uint prevUnicastPacketLossNum;

			public uint currUnicastPacketLossNum;

			public uint prevTotalBroadcastPacketNum;

			public uint currTotalBroadcastPacketNum;

			public uint prevBroadcastPacketLossNum;

			public uint currBroadcastPacketLossNum;

			public bool isValid;
		}

		public Entry[] entry;

		public uint passedMilliSec;

		private static extern void PrintNative2([In] IntPtr connectionAnalysisData);

		public void Print()
		{
		}
	}

	public struct ProtocolId
	{
		public uint value;
	}

	public struct PacketAnalysisData
	{
		public struct Entry
		{
			public ProtocolId protocolId;

			public uint totalNum;

			public uint totalDataSize;

			public uint sumTotalNum;

			public ulong sumTotalDataSize;
		}

		public Entry[] entry;

		public int nowEntryNum;

		public int passedMilliSec;

		public string name;

		public int totalPacketNum;

		public int totalPacketSize;

		public int sumTotalPacketNum;

		public long sumTotalPacketSize;

		private static extern void PrintNative3([In] IntPtr packetAnalysisData, bool isDetail);

		public void Print(bool isDetail)
		{
		}
	}

	public class Unreliable
	{
		private static extern uint GetSendUnreliableDataSizeMaxNative();

		public static uint GetSendUnreliableDataSizeMax()
		{
			return default(uint);
		}

		private static extern PiaPlugin.Result SendToAllUnreliableNative(ushort port, IntPtr pData, uint dataSize);

		public static PiaPlugin.Result SendToAll(ushort port, byte[] data, uint dataSize)
		{
			return default(PiaPlugin.Result);
		}

		private static extern PiaPlugin.Result SendUnreliableNative(ushort port, ulong destConstantId, IntPtr pData, uint dataSize);

		public static PiaPlugin.Result Send(ushort port, ulong destConstantId, byte[] data, uint dataSize)
		{
			return default(PiaPlugin.Result);
		}

		private static extern PiaPlugin.Result ReceiveUnreliableNative(ushort port, out ulong srcConstantId, IntPtr pRecvBuf, out uint recvDataSize, uint recvBufSize);

		public static PiaPlugin.Result Receive(ushort port, out ulong srcConstantId, byte[] recvBuf, out uint recvDataSize)
		{
			return default(PiaPlugin.Result);
		}
	}

	public class Reliable
	{
		private static extern PiaPlugin.Result SendReliableNative(ushort port, ulong destConstantId, IntPtr pData, uint dataSize);

		public static PiaPlugin.Result Send(ushort port, ulong destConstantId, byte[] data, uint dataSize)
		{
			return default(PiaPlugin.Result);
		}

		private static extern PiaPlugin.Result ReceiveReliableNative(ushort port, out ulong srcConstantId, IntPtr pRecvBuf, out uint recvDataSize, uint recvBufSize);

		public static PiaPlugin.Result Receive(ushort port, out ulong srcConstantId, byte[] recvBuf, out uint recvDataSize)
		{
			return default(PiaPlugin.Result);
		}

		private static extern void SetReliableThroughputLimitNative(ushort port, uint throughputLimit);

		public static void SetThroughputLimit(ushort port, uint throughputLimit)
		{
		}

		private static extern PiaPlugin.Result ReadySendReliableNative(ushort port, ulong destConstantId, uint dataSize);

		public static PiaPlugin.Result ReadySend(ushort port, ulong destConstantId, uint dataSize)
		{
			return default(PiaPlugin.Result);
		}

		private static extern PiaPlugin.Result ReadyReceiveReliableNative(ushort port);

		public static PiaPlugin.Result ReadyReceive(ushort port)
		{
			return default(PiaPlugin.Result);
		}
	}

	public class BroadcastReliable
	{
		private static extern PiaPlugin.Result SendBroadcastReliableNative(ushort port, ulong destConstantId, IntPtr pData, uint dataSize);

		public static PiaPlugin.Result Send(ushort port, ulong destConstantId, byte[] data, uint dataSize)
		{
			return default(PiaPlugin.Result);
		}

		private static extern PiaPlugin.Result SendToAllBroadcastReliableNative(ushort port, IntPtr pData, uint dataSize);

		public static PiaPlugin.Result SendToAll(ushort port, byte[] data, uint dataSize)
		{
			return default(PiaPlugin.Result);
		}

		private static extern PiaPlugin.Result ReceiveBroadcastReliableNative(ushort port, out ulong srcConstantId, IntPtr pRecvBuf, out uint recvDataSize, uint recvBufSize);

		public static PiaPlugin.Result Receive(ushort port, out ulong srcConstantId, byte[] recvBuf, out uint recvDataSize)
		{
			return default(PiaPlugin.Result);
		}

		private static extern void SetBroadcastReliableThroughputLimitNative(ushort port, uint throughputLimit);

		public static void SetThroughputLimit(ushort port, uint throughputLimit)
		{
		}

		private static extern PiaPlugin.Result ReadySendBroadcastReliableNative(ushort port, ulong destConstantId, uint dataSize);

		public static PiaPlugin.Result ReadySend(ushort port, ulong destConstantId, uint dataSize)
		{
			return default(PiaPlugin.Result);
		}

		private static extern PiaPlugin.Result ReadySendToAllBroadcastReliableNative(ushort port, uint dataSize);

		public static PiaPlugin.Result ReadySendToAll(ushort port, uint dataSize)
		{
			return default(PiaPlugin.Result);
		}

		private static extern PiaPlugin.Result ReadyReceiveBroadcastReliableNative(ushort port);

		public static PiaPlugin.Result ReadyReceive(ushort port)
		{
			return default(PiaPlugin.Result);
		}
	}

	public class StreamBroadcastReliable
	{
		public enum State
		{
			None,
			Sending,
			WaitingSendAck,
			SendSuccess,
			WaitingReceive,
			Receiving,
			ReceiveSuccess,
			RequestFailure,
			CancelingSend,
			CancelingRequest,
			WaitingCancelAck,
			CancelSuccess,
			Failure
		}

		private static extern PiaPlugin.Result Stream_RequestNative(ushort port, ulong destinationConstantId, IntPtr pBuffer, uint bufferSize, byte id);

		public static PiaPlugin.Result Request(ushort port, ulong destinationConstantId, byte[] pBuffer, byte id)
		{
			return default(PiaPlugin.Result);
		}

		private static extern bool Stream_IsRequestedNative(ushort port, ulong constantId, byte id);

		public static bool IsRequested(ushort port, ulong constantId, byte id)
		{
			return default(bool);
		}

		private static extern PiaPlugin.Result Stream_StartSendNative(ushort port, IntPtr cpData, uint dataSize, byte id);

		public static PiaPlugin.Result StartSend(ushort port, byte[] data, uint dataSize, byte id)
		{
			return default(PiaPlugin.Result);
		}

		private static extern PiaPlugin.Result Stream_CancelNative(ushort port);

		public static PiaPlugin.Result Cancel(ushort port)
		{
			return default(PiaPlugin.Result);
		}

		private static extern State Stream_GetStateNative(ushort port);

		public static State GetState(ushort port)
		{
			return default(State);
		}

		private static extern bool Stream_IsRunningNative(ushort port);

		public static bool IsRunning(ushort port)
		{
			return default(bool);
		}

		private static extern byte Stream_GetProgressNative(ushort port);

		public static byte GetProgress(ushort port)
		{
			return default(byte);
		}

		private static extern void Stream_SetThroughputLimitNative(ushort port, uint throughputLimit);

		public static void SetThroughputLimit(ushort port, uint throughputLimit)
		{
		}

		private static extern PiaPlugin.Result Stream_ReadyRequestNative(ushort port, ulong destinationConstantId);

		public static PiaPlugin.Result ReadyRequest(ushort port, ulong destinationConstantId)
		{
			return default(PiaPlugin.Result);
		}

		private static extern PiaPlugin.Result Stream_ReadyStartSendNative(ushort port);

		public static PiaPlugin.Result ReadyStartSend(ushort port)
		{
			return default(PiaPlugin.Result);
		}
	}

	public const int PacketAnalysisDataEntriesMax = 128;

	public const int PacketAnalysisDataNameLengthMax = 32;

	public const int ConnectionAnalysisDataEntriesMax = 32;

	public const uint ThroughputLimitMax = 268435455u;

	private static extern PiaPlugin.Result SetEmulationSettingNative([In] EmulationSetting setting);

	public static PiaPlugin.Result SetEmulationSetting(EmulationSetting setting)
	{
		return default(PiaPlugin.Result);
	}

	private static extern PiaPlugin.Result UpdateTransportAnalyzerNative();

	public static PiaPlugin.Result UpdateTransportAnalyzer()
	{
		return default(PiaPlugin.Result);
	}

	private static extern TransportAnalysisData GetTransportAnalysisDataNative();

	public static TransportAnalysisData GetTransportAnalysisDataOld()
	{
		return default(TransportAnalysisData);
	}

	private static extern void GetTransportAnalysisDataNative2(IntPtr transportAnalysisData);

	public static TransportAnalysisData GetTransportAnalysisData()
	{
		return default(TransportAnalysisData);
	}
}
