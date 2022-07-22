using INL1;

namespace Dpr.NetworkUtils;

public class StationWaitFrameData : ANetData<StationWaitFrameParam>
{
	public override byte GetDataID => default(byte);

	public float CalcWaitTime()
	{
		return default(float);
	}

	public void SendWaitFrameData(TransportType transportType = TransportType.Station)
	{
	}

	public void RecieveWaitFrameData(PacketReader pr)
	{
	}
}
