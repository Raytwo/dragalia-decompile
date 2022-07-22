using Dpr.NetworkUtils;

namespace Dpr.Contest;

public class NetPlayerInfo : ANetData<NetPlayerData>
{
	public override byte GetDataID => default(byte);
}
