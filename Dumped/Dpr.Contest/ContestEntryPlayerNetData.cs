using Dpr.NetworkUtils;

namespace Dpr.Contest;

public class ContestEntryPlayerNetData : ANetData<ContestEntryPlayerData>
{
	public override byte GetDataID => default(byte);
}
