namespace Dpr.NetworkUtils;

public class NetDataBattleTypeData : ANetData<BattleTypeData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
