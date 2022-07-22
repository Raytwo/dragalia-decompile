namespace Dpr.NetworkUtils;

public class NetDataIsMatchWaitData : ANetData<MatchWaitData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
