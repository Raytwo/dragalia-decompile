using INL1;

namespace Dpr.NetworkUtils;

public interface INetData
{
	int FromStationIndex { get; }

	byte GetDataID { get; }

	void ReceivePacket(PacketReader pr);
}
