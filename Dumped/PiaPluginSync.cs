using System;
using System.Runtime.InteropServices;

public class PiaPluginSync
{
	public enum State
	{
		NotSynchronized,
		Starting,
		Synchronizing,
		Ending
	}

	[Serializable]
	[StructLayout(0)]
	public class SyncStartArgument
	{
		public int usingDataIdBitmap;

		public byte delay;

		public byte sendPeriod;
	}

	public struct SetDataArgument
	{
		public byte dataId;

		public uint dataSize;

		public IntPtr pData;
	}

	public struct GetDataArgument
	{
		public ulong constantId;

		public byte dataId;

		public uint dataSize;

		public IntPtr pData;
	}

	public const uint FrameDelayMax = 32u;

	private static extern PiaPlugin.Result StepNative();

	public static PiaPlugin.Result Step()
	{
		return default(PiaPlugin.Result);
	}

	private static extern PiaPlugin.Result StartNative([In] SyncStartArgument syncStartArg);

	public static PiaPlugin.Result Start(SyncStartArgument syncStartArg)
	{
		return default(PiaPlugin.Result);
	}

	private static extern PiaPlugin.Result EndNative();

	public static PiaPlugin.Result End()
	{
		return default(PiaPlugin.Result);
	}

	private static extern PiaPlugin.Result EndAllNative();

	public static PiaPlugin.Result EndAll()
	{
		return default(PiaPlugin.Result);
	}

	private static extern PiaPlugin.Result SetDataNative([In] SetDataArgument arg);

	public static PiaPlugin.Result SetData(SetDataArgument arg)
	{
		return default(PiaPlugin.Result);
	}

	private static extern PiaPlugin.Result GetDataNative([In] GetDataArgument arg);

	public static PiaPlugin.Result GetData(GetDataArgument arg)
	{
		return default(PiaPlugin.Result);
	}

	private static extern PiaPlugin.Result ReadySetDataNative();

	public static PiaPlugin.Result ReadySetData()
	{
		return default(PiaPlugin.Result);
	}

	private static extern PiaPlugin.Result ReadySetDataNative2(byte dataId);

	public static PiaPlugin.Result ReadySetData(byte dataId)
	{
		return default(PiaPlugin.Result);
	}

	private static extern PiaPlugin.Result ReadyGetDataNative(ulong constantId);

	public static PiaPlugin.Result ReadyGetData(ulong constantId)
	{
		return default(PiaPlugin.Result);
	}

	private static extern State GetSyncStateNative();

	public static State GetSyncState()
	{
		return default(State);
	}

	private static extern bool CheckEntryNative(ulong constantId);

	public static bool CheckEntry(ulong constantId)
	{
		return default(bool);
	}

	private static extern uint GetFrameNoNative();

	public static uint GetFrameNo()
	{
		return default(uint);
	}

	private static extern byte GetDelayNative();

	public static byte GetDelay()
	{
		return default(byte);
	}

	private static extern byte GetDelayMaxNative();

	public static byte GetDelayMax()
	{
		return default(byte);
	}

	private static extern PiaPlugin.Result RequestToChangeDelayNative(byte newDelay);

	public static PiaPlugin.Result RequestToChangeDelay(byte newDelay)
	{
		return default(PiaPlugin.Result);
	}
}
