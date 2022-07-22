namespace Dpr.NetworkUtils;

public class NetDataBattleMatchingRule : ANetData<BattleMatchingRuleData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
