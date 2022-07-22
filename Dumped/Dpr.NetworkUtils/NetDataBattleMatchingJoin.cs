namespace Dpr.NetworkUtils;

public class NetDataBattleMatchingJoin : ANetData<JoinPlayerData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
