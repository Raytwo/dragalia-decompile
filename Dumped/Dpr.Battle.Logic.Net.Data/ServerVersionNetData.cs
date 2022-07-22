using Dpr.NetworkUtils;

namespace Dpr.Battle.Logic.Net.Data;

public class ServerVersionNetData : ANetData<ServerVersion>
{
	public override byte GetDataID => default(byte);
}
