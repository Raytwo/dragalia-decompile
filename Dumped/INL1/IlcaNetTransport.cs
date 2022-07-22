using System.ComponentModel;

namespace INL1;

public class IlcaNetTransport : IlcaNetBase
{
	private ushort myPort;

	protected int stationIndex;

	protected ulong constantId;

	private static PiaPlugin.Result result;

	private static ulong[] ValidityConstantID;

	private static int hostStationIndex;

	private static int thisStationIndex;

	private static ulong hostStationConstantID;

	private static ulong thisStationConstantID;

	public static ulong debug_SendPeakCount;

	public static ulong debug_RecvPeakCount;

	public static ulong debug_SendPeakByte;

	public static ulong debug_RecvPeakByte;

	public static ulong debug_SendSecCount;

	public static ulong debug_RecvSecCount;

	public static ulong debug_SendSecByte;

	public static ulong debug_RecvSecByte;

	private static ulong debug_SendCount;

	private static ulong debug_SendCountRe;

	private static ulong debug_SendByte;

	private static ulong debug_SendByteRe;

	private static ulong debug_SendCountPort;

	private static ulong debug_SendBytePort;

	private static ulong debug_SendToCount;

	private static ulong debug_SendToCountRe;

	private static ulong debug_SendToByte;

	private static ulong debug_SendToByteRe;

	private static ulong debug_RecvCount;

	private static ulong debug_RecvCountRe;

	private static ulong debug_RecvByte;

	private static ulong debug_RecvByteRe;

	private static ulong debug_SendOldCount;

	private static ulong debug_RecvOldCount;

	private static ulong debug_SendOldByte;

	private static ulong debug_RecvOldByte;

	private static int debugAnalysisIntervalCount;

	private const int debugAnalysisInterval = 30;

	~IlcaNetTransport()
	{
	}

	static IlcaNetTransport()
	{
	}

	public static void DebugCountReset()
	{
	}

	public static void DebugCountPrinf()
	{
	}

	public static void AnalysisInterval()
	{
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static void StationAndConstantIdClear()
	{
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void StationIndexSet(int host)
	{
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ConstantIdSet(ulong cid)
	{
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public int StationIndexGet(int host)
	{
		return default(int);
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ulong ConstantIdGet(ulong cid)
	{
		return default(ulong);
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static void HostStationSet(int index, ulong constantID)
	{
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static ulong HostStationConstantIDGet()
	{
		return default(ulong);
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static int HostStationIndexGet()
	{
		return default(int);
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static void ThisStationSet(int index, ulong constantID)
	{
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static ulong ThisStationConstantIDGet()
	{
		return default(ulong);
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static int ThisStationIndexGet()
	{
		return default(int);
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static void ValidityConstantIDSet(int index, ulong constantId)
	{
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static ulong ValidityConstantIDGet(int index)
	{
		return default(ulong);
	}

	protected void MyPortSet(ushort port)
	{
	}

	public virtual int Send(PacketWriter pw, IlcaNetPacketType type)
	{
		return default(int);
	}

	public virtual int SendPeriodic(PacketWriter pw)
	{
		return default(int);
	}

	protected virtual int SendCore(PacketWriter pw, IlcaNetPacketType type, bool notStrict = false)
	{
		return default(int);
	}

	public virtual int SendTo(PacketWriter pw, IlcaNetPacketType type, int sendStationIndex)
	{
		return default(int);
	}

	public virtual int Recv(ref PacketReader pr)
	{
		return default(int);
	}

	public static void NetworkBadEmulationSetting(int level)
	{
	}

	public static void InternetNatTraversalBadEmulationSetting(int percent)
	{
	}
}
