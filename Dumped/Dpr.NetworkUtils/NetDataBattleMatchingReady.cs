namespace Dpr.NetworkUtils;

public class NetDataBattleMatchingReady : ANetData<BattleMatchingBaseData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
