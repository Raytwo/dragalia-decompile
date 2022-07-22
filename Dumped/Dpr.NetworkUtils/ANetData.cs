using INL1;

namespace Dpr.NetworkUtils;

public abstract class ANetData<T> : INetData where T : struct
{
	public static byte DataID;

	public T data;

	private int fromStationIndex;

	private static byte[] dataBuffer;

	private static int dataSize;

	public virtual byte GetDataID => default(byte);

	public int FromStationIndex => default(int);

	public ANetData()
	{
	}

	private void CreateDataBuffer()
	{
	}

	public void _Debug_ChangeFromStarionIndex(int idx)
	{
	}

	public int SendReliableData(int sendStationIndex, TransportType transportType = TransportType.Station)
	{
		return default(int);
	}

	public int SendReliableDataToAll(TransportType transportType = TransportType.Station)
	{
		return default(int);
	}

	public int SendUnReliableData(int sendStationIndex, TransportType transportType = TransportType.Station)
	{
		return default(int);
	}

	public int SendUnReliableDataToAll(TransportType transportType = TransportType.Station)
	{
		return default(int);
	}

	public PacketWriterRe CreateReliableData()
	{
		return null;
	}

	protected virtual PacketWriter CreateUnReliableData()
	{
		return null;
	}

	protected virtual void WriteSendData(PacketWriter appendTarget)
	{
	}

	protected byte[] ConvertStructToBytes()
	{
		return null;
	}

	public void ReceivePacket(PacketReader pr)
	{
	}

	protected virtual void ReadRecieveData(PacketReader pr)
	{
	}

	protected T ConvertBytesToStruct(PacketReader pr)
	{
		return (T)null;
	}
}
