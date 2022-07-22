namespace Dpr.NetworkUtils;

public class NetDataBattleMatchingState : ANetData<StationIndexData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
