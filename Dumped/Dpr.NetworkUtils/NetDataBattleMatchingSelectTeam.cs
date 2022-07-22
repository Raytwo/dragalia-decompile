namespace Dpr.NetworkUtils;

public class NetDataBattleMatchingSelectTeam : ANetData<StationIndexData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
