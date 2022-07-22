namespace Dpr.NetworkUtils;

public class NetDataBattleRuleCancelData : ANetData<BattleCancelData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
