namespace Dpr.NetworkUtils;

public class NetDataBattleMatchingCountDown : ANetData<BattleMatchingCountDownData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
